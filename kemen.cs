using System;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using System.Net;
using System.IO;
using log4net;

namespace kemen
{
    public partial class kemen : Form
    {
        private NameValueCollection cnfValues = ConfigurationManager.AppSettings;
        private ILog log = log4net.LogManager.GetLogger(typeof(kemen));
        private Thread threadPiMonitor = null;
        private Thread threadMaxDayMonitor = null;
        private DateTime lastGrabado;
        public bool seguir = true;
        public kemen()
        {
            InitializeComponent();

            lblFecha.Text = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            threadPiMonitor = new Thread(this.executePiMonitor);
            threadMaxDayMonitor = new Thread(this.executeMaxDayMonitor);
            threadPiMonitor.Start();
            lastGrabado = DateTime.Now;
            //threadMaxDayMonitor.Start();
            
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVer_Click(object sender, EventArgs e)
        {
          String startTimeSt = this.startDate.Text;
          String endTimeSt = this.endDate.Text;
          try
          {
            DateTime dbDate = Convert.ToDateTime(endTimeSt);
            //DateTime dbDate = new DateTime(2013, 11, 07, 00, 00, 00);
            String stDateFinal = String.Format("{0:yyyy-MM-dd}", dbDate);
            dbDate = Convert.ToDateTime(startTimeSt);
            String stDateInicial = String.Format("{0:yyyy-MM-dd}", dbDate);
            List<GruaTrenData> datos = leerDatosGrua(stDateInicial, stDateFinal);
            if (datos != null && datos.Count > 0)            {             
                Datos datosDialog = new Datos();
                datosDialog.CargarDatos(datos);
                // Show testDialog as a modal dialog and determine if DialogResult = OK.
                if (datosDialog.ShowDialog(this) == DialogResult.OK) {
                  this.volcarDatosGrua(datos);
                }
                datosDialog.Dispose();
            }
            else  MessageBox.Show("No hay datos para las fechas seleccionadas");
            
          }
          catch (Exception ex)
          {
            log.Error("Error al exportar: " + ex.Message);
          }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {
          String startTimeSt = this.startDate.Text;
          String endTimeSt = this.endDate.Text;
          try{
            DateTime dbDate = Convert.ToDateTime(endTimeSt);
            //DateTime dbDate = new DateTime(2013, 11, 07, 00, 00, 00);
            String stDateFinal = String.Format("{0:yyyy-MM-dd}", dbDate);
            dbDate = Convert.ToDateTime(startTimeSt);
            String stDateInicial = String.Format("{0:yyyy-MM-dd}", dbDate);
            List<GruaTrenData> datos = leerDatosGrua(stDateInicial, stDateFinal);
            volcarDatosGrua(datos);
          }
          catch (Exception ex) {
            log.Error("Error al exportar: " + ex.Message);
          }
          
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private List <GruaTrenData> leerDatosGrua(string startDate, string endDate)
        {
          List <GruaTrenData> datos = new  List <GruaTrenData>();
          GruaTrenData d = new GruaTrenData();
   
          
          string query = "op=historico&startdate="+startDate+"&enddate="+endDate;
          string url = cnfValues["remoteUrl"] +  query;
          try {
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            string result = null;
            using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)    {
              StreamReader reader = new StreamReader(resp.GetResponseStream());
              result = reader.ReadToEnd();
              datos = extraerDatos(result);
            }
          }                                                       
          catch (Exception ex) {
            MessageBox.Show("Error al realizar llamada al servidor: " + cnfValues["remoteUrl"] + query);
            datos = null;
            log.Error("Error en Thread PiMonitor: " + ex.Message);
          }
          return datos;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rawData"></param>
        /// <returns></returns>
        private List<GruaTrenData> extraerDatos(string rawData)
        {
          List<GruaTrenData> datos = null;
          string[] split = rawData.Split(new Char[] { '\n'});
          foreach (string s in split)
          {
            string[] items = s.Split(new Char[] { ';' });
            if (items.Length >=2){
              GruaTrenData d = new GruaTrenData();
              d.Fecha = items[2];
              d.Valor = items[1];
              if (datos == null) datos = new List<GruaTrenData>();
              datos.Add(d);
            }            
          }
          return datos;
        }
      /// <summary>
      /// 
      /// 
      /// </summary>
      /// <param name="rawData"></param>
      /// <returns></returns>
        private List<GruaTrenData> extraerDatosTiempoReal(string rawData)
        {
          List<GruaTrenData> datos = null;
          string[] split = rawData.Split(new Char[] { '\n' });
          char signo;
          foreach (string s in split)
          { 
            string[] items = s.Split(new Char[] { ';' });
            if (items.Length >= 2)
            {
              GruaTrenData d = new GruaTrenData();
              d.Fecha = items[4];
              d.Valor = items[3];
              d.Signo = items[2];
              d.Carro = Convert.ToInt32(items[5]);
              d.Palpa = Convert.ToInt32(items[6]);
              d.Twisl = Convert.ToInt32(items[7]);
              d.Subir = Convert.ToInt32(items[8]);
              d.Tw1 = (int)Convert.ToDouble(items[9]);
              d.Tw2 = (int)Convert.ToDouble(items[10]);
              d.Tw3 = (int)Convert.ToDouble(items[11]);
              d.Tw4 = (int)Convert.ToDouble(items[12]);
              if (datos == null) datos = new List<GruaTrenData>();
              datos.Add(d);
            }
          }
          return datos;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volcarDatosGrua(List <GruaTrenData> datos)
        {     
          try  {
            String fileName = cnfValues["exportDir"] + "\\kemenexport." + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + cnfValues["nombre"] + ".csv";
            System.IO.StreamWriter file  = new System.IO.StreamWriter(fileName);
            file.WriteLine("Fecha;Peso");
            foreach  (GruaTrenData d in datos)
            {
              String line = d.Fecha + ";" + d.Valor ;
              file.WriteLine(line);
            }
            file.Close();
            MessageBox.Show("Fichero export generado con exito: " + fileName);
          }                                                         
          catch (Exception ex)
          {
            log.Error("Error al volcar datos: " + ex.Message);
          }
        }
        /// <summary>
        /// 
        /// </summary>
        private void executePiMonitor()
        {
          string query = "";
          string url = "";
          int contador = 0;
          while (seguir){
            try {              
              query = "op=ultimo";
              url = cnfValues["remoteUrl"] + query;
              HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
              string result = null;
              using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
              {
                StreamReader reader = new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
                List <GruaTrenData> datos = extraerDatosTiempoReal(result);
                if (datos[0].Signo.CompareTo("-")==0) 
                  scPesaje.Value = (-1) * Convert.ToDouble(datos[0].Valor);
                else
                  scPesaje.Value = Convert.ToDouble(datos[0].Valor);
                if (scPesaje.Value >= Convert.ToInt32(cnfValues["rangoalto"])) scPesaje.BackColor = Color.Red;
                else if (scPesaje.Value >= Convert.ToInt32(cnfValues["rangomedio"])) scPesaje.BackColor = Color.Orange;
                else scPesaje.BackColor = Color.Lime;

                if (datos[0].Signo.CompareTo("-") == 0) 
                  lblPeso.Text = datos[0].Signo + datos[0].Valor;
                else
                  lblPeso.Text = datos[0].Valor;
                lblTw1.Text = Convert.ToString(datos[0].Tw1);
                lblTw2.Text = Convert.ToString(datos[0].Tw2);
                lblTw3.Text = Convert.ToString(datos[0].Tw3);
                lblTw4.Text = Convert.ToString(datos[0].Tw4);
                lblFecha.Text = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
                lblComunica.Text = "COMUNICA";
              }
              if (contador++ >= 10) {
                contador = 0;
                query = "op=ultimosdiez";
                url = cnfValues["remoteUrl"] + query;
                req = WebRequest.Create(url) as HttpWebRequest;
                result = null;
                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse) {
                  StreamReader reader = new StreamReader(resp.GetResponseStream());
                  result = reader.ReadToEnd();
                  List<GruaTrenData> datos = extraerDatos(result);
                  DateTime dbDate = Convert.ToDateTime(datos[0].Fecha);
                  if (dbDate.CompareTo(lastGrabado) != 0) {
                    lastGrabado = dbDate;
                    vwUltimos.Items.Clear();
                    foreach (GruaTrenData d in datos) {

                      ListViewItem item = new ListViewItem(d.Fecha);
                      item.SubItems.Add(d.Valor);
                      vwUltimos.Items.Add(item);
                    }
                  }
                  
                }
              }
              
            }//while conectado                                                         
            catch (Exception ex){
              lblComunica.Text = "NO COMUNICA";
              lblFecha.Text = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
              log.Error("Error en Thread PiMonitor: " + ex.Message);
            }
            finally {
              Thread.Sleep(1000);
            }
          } //while (seguir)
          Thread.Sleep(1000);  
          log.Info("Finalizado thread PiMonitor.");
        }
        /// <summary>
        /// 
        /// </summary>
        private void executeMaxDayMonitor()
        {
          String startTimeSt = this.startDate.Text;
          String endTimeSt = this.endDate.Text;

          DateTime dbDate = Convert.ToDateTime(endTimeSt);
          //DateTime dbDate = new DateTime(2013, 11, 07, 00, 00, 00);
          String stDateFinal = String.Format("{0:yyyy-MM-dd}", dbDate);
          dbDate = Convert.ToDateTime(startTimeSt);
          String stDateInicial = String.Format("{0:yyyy-MM-dd}", dbDate);

          string query = "op=max&startdate=" + stDateInicial + "&enddate=" + stDateFinal + "&count=" + cnfValues["valormax30"];
          string url = cnfValues["remoteUrl"] + query;
          HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
          string result = null;                                 
          
          try {
            using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
            {
              StreamReader reader = new StreamReader(resp.GetResponseStream());
              result = reader.ReadToEnd();
              List<GruaTrenData> datos = extraerDatos(result);
              if (datos == null || datos.Count == 0)
                MessageBox.Show("No hay datos para las fechas seleccionadas");
               else{
                Datos datosDialog = new Datos();
                datosDialog.CargarDatos(datos);
                // Show testDialog as a modal dialog and determine if DialogResult = OK.
                if (datosDialog.ShowDialog(this) == DialogResult.OK) {
                  this.volcarDatosGrua(datos);
                }
                datosDialog.Dispose();
               }
             }
          }                                                                     
          catch (Exception ex) {
              //lblMaxPesoHora.Text = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            MessageBox.Show("Error al acceder a URL: " + url );
            log.Error("Error en URL : " + ex.Message);
          }
          finally {
            Thread.Sleep(1000);
          }                      
          Thread.Sleep(1000);
          log.Info("Finalizado thread MaxDay Monitor.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void kemen_FormClosed(object sender, FormClosedEventArgs e)
        {
          seguir = false;
        }

        private void kemen_Load(object sender, EventArgs e)
        {

        }

        private void lstUltimos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          executeMaxDayMonitor();
        }
    }
}
