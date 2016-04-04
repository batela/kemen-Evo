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
        private int tamano = 1;
        public bool seguir = true;
        private String remoteUrl;
        GruaTrenData datosGruaTren;
        private Launcher lch;
        private Periferia periWnd = new Periferia();

        public String getLblPesoValue() { 
          return this.lblPeso.Text; 
        }
        public String getLblUltimoPesoValue(){
          return this.lblUltimo.Text;
        }
        public Color getED1Value() {
          return this.btnED1.BackColor;
        }
        public Color getED2Value(){
          return this.btnED2.BackColor;
        }
        public Color getED3Value(){
          return this.btnED3.BackColor;
        }
        public Color getED4Value() {
          return this.btnED4.BackColor;
        }

        public kemen(String url,Launcher l)
        {
          InitializeComponent();
          this.remoteUrl = url;
          lblFecha.Text = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
          threadPiMonitor = new Thread(this.executePiMonitor);
          threadMaxDayMonitor = new Thread(this.executeMaxDayMonitor);
          threadPiMonitor.Start();
          lastGrabado = DateTime.Now;
          if (Convert.ToInt16(cnfValues["displayGrua"]) == 1) // Deshabilitamos controles en caso de ser aplicativo de cabina
          {
            btnVer.Enabled = false;
            btnExportar.Enabled = false;
            button1.Enabled = false;
            btnConfig.Enabled = false;
          }
          datosGruaTren = new GruaTrenData();
          //threadMaxDayMonitor.Start();
          this.lch = l;

        }
        public kemen()
        {
            InitializeComponent();
            this.remoteUrl = cnfValues["remoteUrl"];
            lblFecha.Text = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            threadPiMonitor = new Thread(this.executePiMonitor);
            threadMaxDayMonitor = new Thread(this.executeMaxDayMonitor);
            threadPiMonitor.Start();
            lastGrabado = DateTime.Now;
            if (Convert.ToInt16(cnfValues["displayGrua"]) == 1) // Deshabilitamos controles en caso de ser aplicativo de cabina
            {
              btnVer.Enabled = false;
              btnExportar.Enabled = false;
              button1.Enabled = false;
              btnConfig.Enabled = false;
            }
            datosGruaTren = new GruaTrenData();
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
        ///       
        private List <GruaTrenData> leerDatosGrua(string startDate, string endDate)
        {
          List <GruaTrenData> datos = new  List <GruaTrenData>();
          GruaTrenData d = new GruaTrenData();
   
          
          string query = "op=historico&startdate="+startDate+"&enddate="+endDate;
          string url =this.remoteUrl +  query;
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
            MessageBox.Show("Error al realizar llamada al servidor: " +this.remoteUrl + query);
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
              d.Pesaje = items[1];
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
              d.CMx = (int)Convert.ToDouble(items[13]);
              d.CMy = (int)Convert.ToDouble(items[14]);
              d.Atw1 = items[15];
              d.Atw2 = items[16];
              d.Atw3 = items[17];
              d.Atw4 = items[18];
              d.Aradio = items[19];
              d.Acm = items[20];
              d.Acamion = items[21];
              d.Acontenedor = items[22];
              d.Ageneral = items[23];
              d.Ultimo = items[24];
              d.Ed5 = items[25];
              d.Ed6 = items[26];
              d.Ed7 = items[27];
              d.Ed8 = items[28];
              d.Ed9 = items[29];
              d.Ed10 = items[30];
              d.Ed11 = items[31];
              d.Ed12 = items[32];


            if (datos == null) datos = new List<GruaTrenData>();
              datos.Add(d);
              PibBola.Parent = PibContenedor;
              PibBola.BackColor = Color.Transparent;

              // error en sensores
              
              if (d.Atw1 == "F") //Tw01
              {
                lblSensor1.BackColor = Color.Lime;
                lblSensor1.ForeColor = Color.Black;
               // lblTw1.BackColor = Color.FromArgb(244, 244, 244);
               // lblKg1.BackColor = Color.FromArgb(244, 244, 244);
              }
              if (d.Atw1 == "V")
              {
                lblSensor1.BackColor = Color.Red;
                lblSensor1.ForeColor = Color.White;
              //  lblTw1.BackColor = Color.Red;
              //  lblKg1.BackColor = Color.Red;
              }
              if (d.Atw2 == "F") //Tw02 
              {
                lblSensor2.BackColor = Color.Lime;
                lblSensor2.ForeColor = Color.Black;
              //  lblTw2.BackColor = Color.FromArgb(244, 244, 244);
              //  lblKg2.BackColor = Color.FromArgb(244, 244, 244);
              }
              if (d.Atw2 == "V")
              {
                lblSensor2.BackColor = Color.Red;
                lblSensor2.ForeColor = Color.White;
              //  lblTw2.BackColor = Color.Red;
              //  lblKg2.BackColor = Color.Red;
              }
              if (d.Atw3 == "F") //Tw03
              {
                lblSensor3.BackColor = Color.Lime;
                lblSensor3.ForeColor = Color.Black;
               // lblTw3.BackColor = Color.FromArgb(244, 244, 244);
               // lblKg3.BackColor = Color.FromArgb(244, 244, 244);
              }
              if (d.Atw3 == "V")
              {
                lblSensor3.BackColor = Color.Red;
                lblSensor3.ForeColor = Color.White;
              //  lblTw3.BackColor = Color.Red;
              //  lblKg3.BackColor = Color.Red;
              }
              if (d.Atw4 == "F") //Tw04
              {
                lblSensor4.BackColor = Color.Lime;
                lblSensor4.ForeColor = Color.Black;
              //  lblTw4.BackColor = Color.FromArgb(244, 244, 244);
              //  lblKg4.BackColor = Color.FromArgb(244, 244, 244);
              }
              if (d.Atw4 == "V")
              {
                lblSensor4.BackColor = Color.Red;
                lblSensor4.ForeColor = Color.White;
              //  lblTw4.BackColor = Color.Red;
              //  lblKg4.BackColor = Color.Red;
              }

              // ENTRADAS DE CONTROL
              if (d.Carro == 1)                //ED_1 
              {
                btnED1.BackColor = Color.Lime;
                lblED1.ForeColor = Color.Lime;
              } 
              if (d.Carro == 0) //ED_1
              {
                btnED1.BackColor = Color.Gray;
                lblED1.ForeColor = Color.Black;                
              }

              if (d.Twisl == 1)                //ED_2 
              {
                btnED2.BackColor = Color.Lime;
                lblED2.ForeColor = Color.Lime;
              }
              if (d.Twisl == 0) //ED_2
              {
                btnED2.BackColor = Color.Gray;
                lblED2.ForeColor = Color.Black; 
              }

              if (d.Palpa  == 1)               //ED_3 
              {
                btnED3.BackColor = Color.Lime;
                lblED3.ForeColor = Color.Lime;
              }
              if (d.Palpa == 0) //ED_3
              {
                btnED3.BackColor = Color.Gray;
                lblED3.ForeColor = Color.Black;
              }

              if (d.Subir == 1)                //ED_4
              {
                btnED4.BackColor = Color.Lime;
                lblED4.ForeColor = Color.Lime;
              }
              if (d.Subir == 0) //ED_4
              {
                btnED4.BackColor = Color.Gray;
                lblED4.ForeColor = Color.Black;
              }

              // ALARMAS
              if (d.Acm == "V")                //ALM_1
              {
                btnAlarm1.BackColor = Color.Red;
                lblAlarm1.ForeColor = Color.Red;
              }
              if (d.Acm == "F") //ALM_1
              {
                btnAlarm1.BackColor = Color.Gray;
                lblAlarm1.ForeColor = Color.Black;
              }

              // ALARMAS
              if (d.Acamion == "V")                //ALM_2
              {
                btnAlarm2.BackColor = Color.Red;
                lblAlarm2.ForeColor = Color.Red;
              }
              if (d.Acamion == "F") //ALM_2
              {
                btnAlarm2.BackColor = Color.Gray;
                lblAlarm1.ForeColor = Color.Black;
              }

              // ALARMAS
              if (d.Aradio == "V")                //ALM_3
              {
                btnAlarm3.BackColor = Color.Red;
                lblAlarm3.ForeColor = Color.Red;
              }
              if (d.Aradio == "F") //ALM_3
              {
                btnAlarm3.BackColor = Color.Gray;
                lblAlarm3.ForeColor = Color.Black;
              }

              // ALARMAS
              if (d.Ageneral == "V")                //ALM_4
              {
                btnAlarm4.BackColor = Color.Red;
                lblAlarm4.ForeColor = Color.Red;
              }
              if (d.Ageneral == "F") //ALM_4
              {
                btnAlarm4.BackColor = Color.Gray;
                lblAlarm4.ForeColor = Color.Black;
              }
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
              url =this.remoteUrl + query;
              HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
              string result = null;
              using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
              {
                StreamReader reader = new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
                List <GruaTrenData> datos = extraerDatosTiempoReal(result);
                //Actualiza la ventana de periferia
                periWnd.executePeriferiaMonitor(datos[0]);
                if (datos[0].Pesaje == "V") //contenedor liberado
                {
                  lblPeso.BackColor = Color.LightGray;
                  lblUltimo.BackColor = Color.LightGray;
                  lblUltimo.Text = "------";
                }

                if (datos[0].Pesaje == "F") //contenedor enganchado (pesaje realizado)
                {
                  lblPeso.BackColor = Color.White;
                  lblUltimo.BackColor = Color.White;
                }

                  if (datos[0].Signo.CompareTo("-") == 0)
                    scPesaje.Value = (-1) * Convert.ToDouble(datos[0].Valor);
                  else
                    scPesaje.Value = Convert.ToDouble(datos[0].Valor);

                  if (scPesaje.Value >= Convert.ToInt32(cnfValues["rangoalto"])) scPesaje.BackColor = Color.Red;
                  else if (scPesaje.Value >= Convert.ToInt32(cnfValues["rangomedio"])) scPesaje.BackColor = Color.Orange;
                  else scPesaje.BackColor = Color.Lime;
                
                
                if (datos[0].Signo.CompareTo("-") == 0) 
                  lblPeso.Text = datos[0].Signo + datos[0].Valor;
                else
                lblPeso.Text = datos[0].Valor;        //Peso Actual

                if (datos[0].Pesaje == "F") lblUltimo.Text = datos[0].Ultimo;     //Si contenedor enganchado actualizo ultimo
             
                lblTw1.Text = Convert.ToString(datos[0].Tw1);
                lblTw2.Text = Convert.ToString(datos[0].Tw2);
                lblTw3.Text = Convert.ToString(datos[0].Tw3);
                lblTw4.Text = Convert.ToString(datos[0].Tw4);
                lblCMx.Text = Convert.ToString(datos[0].CMx);
                lblCMy.Text = Convert.ToString(datos[0].CMy);
                lblFecha.Text = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
                lblComunica.Text = "COMUNICA";
                PibCom.BackColor = Color.Lime;
               // PibBola.Visible = true;

                PibBola.Location = new Point (Convert.ToInt32(292+(1.4*datos[0].CMx)) , Convert.ToInt32(108-(0.7*datos[0].CMy)));
                
               // lblCMx.Location = new Point(Convert.ToInt32(317 + (1.4 * datos[0].CMx)), Convert.ToInt32(136 - (0.7 * datos[0].CMy)));
               // lblCMy.Location = new Point(Convert.ToInt32(317 + (1.4 * datos[0].CMx)), Convert.ToInt32(153 - (0.7 * datos[0].CMy)));
              }
                           
              if (contador++ >= 10) {
                contador = 0;
                query = "op=ultimosdiez";
                url =this.remoteUrl + query;
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
              PibCom.BackColor =Color.Red;
              //PibBola.Visible = false;
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
          string url =this.remoteUrl + query;
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
          periWnd.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
          executeMaxDayMonitor();
        }

        private void vwUltimos_MouseClick(object sender, MouseEventArgs e)
        {
          
          if ( tamano == 1) 
            vwUltimos.Size = new Size(275, 210);
          else
            vwUltimos.Size = new Size(275, 117);
          tamano  = tamano * (-1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfig_Click(object sender, EventArgs e)
        {
          System.Diagnostics.Process.Start(cnfValues["configUrl"]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGraficas_Click(object sender, EventArgs e)
        {
          Graficas graficaDialog = new Graficas();
          // Show testDialog as a modal dialog and determine if DialogResult = OK.
          if (graficaDialog.ShowDialog(this) == DialogResult.OK)
          {
           
          }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          try
          {
            periWnd.Show();
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
        private void btnVerMini_Click(object sender, EventArgs e)
        {
         
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(MiniWindowThread));
            t.Start();                                  
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        private void MiniWindowThread()
        {
          this.WindowState = FormWindowState.Minimized;
          Application.Run(new KemenMini(this,this.lch.getIndiceKemen(this.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
          this.lch.Visible = true;
        }
    }
}
