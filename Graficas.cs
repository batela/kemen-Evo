using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Configuration;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using ZedGraph;
using log4net;

namespace kemen
{
  public partial class Graficas : Form
  {
    private GraphPane realTimePanel = null;
    private GraphPane realTimePanelTOTAL = null;
    private LineItem muestraTOTAL = null;
    private LineItem muestraTOTALinicioPesaje = null;
    private LineItem muestraTOTALfinPesaje = null;
    private LineItem muestraTWinicioPesaje = null;
    private LineItem muestraTWfinPesaje = null;

    private LineItem muestraTw1 = null;
    private LineItem muestraTw2= null;
    private LineItem muestraTw3 = null;
    private LineItem muestraTw4 = null;
    private ILog log = log4net.LogManager.GetLogger(typeof(kemen));
    private NameValueCollection cnfValues = ConfigurationManager.AppSettings;

    private PointPairList listGraphTOTAL ;
    private PointPairList listGraphTw1;
    private PointPairList listGraphTw2;
    private PointPairList listGraphTw3;
    private PointPairList listGraphTw4;

    public Graficas()
    {
      InitializeComponent();
      realTimePanel = this.zedGraphTw.GraphPane;
      realTimePanelTOTAL = this.zedGraphTOTAL.GraphPane;
      
      realTimePanel.XAxis.Title.Text = "Fecha - Hora";
      realTimePanel.XAxis.Scale.MinorStep = 1;
      realTimePanel.XAxis.Scale.MajorStep = 1;
      realTimePanel.XAxis.Scale.Min = 0;
      realTimePanel.XAxis.Scale.Max = 20;
      realTimePanel.YAxis.Scale.Min = -100;
      realTimePanel.YAxis.Scale.Max = 10500;
      realTimePanel.YAxis.Scale.MinorStep = 500;
      realTimePanel.YAxis.Scale.MajorStep = 1000;
      realTimePanel.YAxis.Title.Text = "REGISTRO TW";
      realTimePanel.YAxis.Title.IsVisible = false;
      realTimePanel.XAxis.Title.IsVisible = false;
      realTimePanel.Title.IsVisible = false;

      // Graficos TOTAL
      
      realTimePanelTOTAL.XAxis.Title.Text = "Fecha - Hora";
      realTimePanelTOTAL.XAxis.Scale.MinorStep = 1;
      realTimePanelTOTAL.XAxis.Scale.MajorStep = 1;
      realTimePanelTOTAL.XAxis.Scale.Min = 0;
      realTimePanelTOTAL.XAxis.Scale.Max = 20;
      realTimePanelTOTAL.YAxis.Scale.Min = -100;
      realTimePanelTOTAL.YAxis.Scale.Max = 35000;
      realTimePanelTOTAL.YAxis.Scale.MinorStep = 500;
      realTimePanelTOTAL.YAxis.Scale.MajorStep = 1000;
      realTimePanelTOTAL.YAxis.Title.Text = "REGISTRO TOTAL";
      realTimePanelTOTAL.YAxis.Title.IsVisible = false;
      realTimePanelTOTAL.XAxis.Title.IsVisible = false;
      realTimePanelTOTAL.Title.IsVisible = false;
      //Para cargar la grafica al lanzar la ventana
      btnTest_Click(null, null);
          
    }

    private void Graficas_Load(object sender, EventArgs e)
    {
     
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      listGraphTOTAL = new PointPairList();
      listGraphTw1 = new PointPairList();
      listGraphTw2 = new PointPairList();
      listGraphTw3 = new PointPairList();
      listGraphTw4 = new PointPairList();

      PointPairList listGraphTOTALinicioPesaje = new PointPairList();
      PointPairList listGraphTOTALfinPesaje = new PointPairList();

      PointPairList listGraphTWinicioPesaje = new PointPairList();
      PointPairList listGraphTWfinPesaje = new PointPairList();

      GraficaData datos;
      string query = "op=grafica";
      string url = cnfValues["remoteUrl"] + query;
      try
      {
        if (muestraTOTAL != null)             realTimePanelTOTAL.CurveList.Remove(muestraTOTAL);
        if (muestraTOTALinicioPesaje != null) realTimePanelTOTAL.CurveList.Remove(muestraTOTALinicioPesaje);
        if (muestraTOTALfinPesaje != null)    realTimePanelTOTAL.CurveList.Remove(muestraTOTALfinPesaje);

        if (muestraTWinicioPesaje != null) realTimePanel.CurveList.Remove(muestraTWinicioPesaje);
        if (muestraTWfinPesaje != null) realTimePanel.CurveList.Remove(muestraTWfinPesaje);

        if (muestraTw1 != null) realTimePanel.CurveList.Remove(muestraTw1);
        if (muestraTw2 != null) realTimePanel.CurveList.Remove(muestraTw2);
        if (muestraTw3 != null) realTimePanel.CurveList.Remove(muestraTw3);
        if (muestraTw4 != null) realTimePanel.CurveList.Remove(muestraTw4);
         HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;            //Pruebas fichero
        string result = null;
        using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)         //Pruebas fichero
        {
          StreamReader reader = new StreamReader(resp.GetResponseStream());        
          //StreamReader reader = new StreamReader("D:\\Batela\\BASCULA\\Datos.txt");   //Pruebas fichero
          result = reader.ReadToEnd();
          datos = this.extraerDatos(result);
          double idx = 0;
          for (int i = 0; i < datos.Ndatos; i++)
          {
            listGraphTOTAL.Add(idx,(int) datos.Ptotal[i]);
            listGraphTw1.Add(idx,(int) datos.Ptw1[i]);
            listGraphTw2.Add(idx, (int) datos.Ptw2[i]);
            listGraphTw3.Add(idx,(int) datos.Ptw3[i]);
            listGraphTw4.Add(idx,(int) datos.Ptw4[i]);
            idx=idx+0.2;
          }
          
          listGraphTOTALinicioPesaje.Add(datos.Tinicio , 0);
          listGraphTOTALinicioPesaje.Add(datos.Tinicio , 35000);
          listGraphTOTALfinPesaje.Add(datos.Tinicio + (datos.Npesadas * 0.2) , 0);
          listGraphTOTALfinPesaje.Add(datos.Tinicio + (datos.Npesadas * 0.2), 35000);
          
          listGraphTWinicioPesaje.Add(datos.Tinicio, 0);
          listGraphTWinicioPesaje.Add(datos.Tinicio, 30000);
          listGraphTWfinPesaje.Add(datos.Tinicio + (datos.Npesadas * 0.2), 0);
          listGraphTWfinPesaje.Add(datos.Tinicio + (datos.Npesadas * 0.2), 30000);
          
          realTimePanel.XAxis.Scale.Max = datos.Ndatos*2/10;
          realTimePanelTOTAL.XAxis.Scale.Max = datos.Ndatos*2/10;

          muestraTOTAL = realTimePanelTOTAL.AddCurve("TOTAL", listGraphTOTAL, Color.Green, SymbolType.Diamond);
          muestraTOTALinicioPesaje = realTimePanelTOTAL.AddCurve("Inicio Pesaje", listGraphTOTALinicioPesaje, Color.Black, SymbolType.None);
          muestraTOTALfinPesaje = realTimePanelTOTAL.AddCurve("Fin Pesaje", listGraphTOTALfinPesaje, Color.Black, SymbolType.None);

          muestraTWinicioPesaje = realTimePanel.AddCurve("Inicio Pesaje", listGraphTWinicioPesaje, Color.Black, SymbolType.None);
          muestraTWfinPesaje = realTimePanel.AddCurve("Fin Pesaje", listGraphTWfinPesaje, Color.Black, SymbolType.None);

          muestraTOTALinicioPesaje.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;
          muestraTWinicioPesaje.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;

          muestraTw1 = realTimePanel.AddCurve("Tw1", listGraphTw1, Color.Blue, SymbolType.Diamond);
          muestraTw2 = realTimePanel.AddCurve("Tw2", listGraphTw2, Color.Green, SymbolType.Diamond);
          muestraTw3 = realTimePanel.AddCurve("Tw3", listGraphTw3, Color.Red, SymbolType.Diamond);
          muestraTw4 = realTimePanel.AddCurve("Tw4", listGraphTw4, Color.Black, SymbolType.Diamond);

          this.zedGraphTw.Refresh();
          this.zedGraphTOTAL.Refresh();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al realizar llamada al servidor: " + cnfValues["remoteUrl"] + query+ex.Message);
        datos = null;
        log.Error("Error en Thread PiMonitor: " + ex.Message);
      }
    }

    private GraficaData extraerDatos(string rawData)
    {
      string[] split = rawData.Split(new Char[] { '\n' });
      int indice = 0;
      GraficaData d = new GraficaData();
      foreach (string s in split)
      {
        string[] items = s.Split(new Char[] { ';' });
        switch (indice++){
          case 0:
            d.Ndatos  = Convert.ToInt32(items[3]);
            d.Npesadas = Convert.ToInt32(items[2]);
            d.Tinicio = Convert.ToInt32(items[1]);
          break;
          case 1:
          for (int i = 0; i < d.Ndatos; i++)
          {
              d.Ptotal.Add(Convert.ToInt32(items[i]));
            }
          break;
          case 2:
          for (int i = 0; i < d.Ndatos; i++)
            {
              d.Ptw1.Add(Convert.ToInt32(items[i]));
            }
          break;
          case 3:
          for (int i = 0; i < d.Ndatos; i++)
            {
              d.Ptw2.Add(Convert.ToInt32(items[i]));
            }
          break;
          case 4:
          for (int i = 0; i < d.Ndatos; i++)
            {
              d.Ptw3.Add(Convert.ToInt32(items[i]));
            }
          break;
          case 5:
          for (int i = 0; i < d.Ndatos; i++)
            {
              d.Ptw4.Add(Convert.ToInt32(items[i]));
            }
          break;
        }       
      }
      return d;
 
    }
    private string  pruebasfichero()
    {
      int counter = 0;
      string line;
      string res="";

      // Read the file and display it line by line.
      System.IO.StreamReader file =
         new System.IO.StreamReader("c:\\test.txt");
      while ((line = file.ReadLine()) != null)
      {
        res = res + line;
      }

      file.Close();
      return res;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        String fileName = cnfValues["exportDir"] + "\\kemengraficasexport." + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + cnfValues["nombre"] + ".csv";
        System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
        file.WriteLine("Elemeto->pesajes");
        String line = "Pesaje Acumulado->";
        foreach (PointPair d in this.listGraphTOTAL)
        {
          line = line + ";" + d.Y;

        }
        file.WriteLine(line);

        line = "Pesaje TWL 01->";
        foreach (PointPair d in this.listGraphTw1)
        {
          line = line + ";" + d.Y;

        }
        file.WriteLine(line);

        line = "Pesaje TWL 02->";
        foreach (PointPair d in this.listGraphTw2)
        {
          line = line + ";" + d.Y;

        }
        file.WriteLine(line);

        line = "Pesaje TWL 03->";
        foreach (PointPair d in this.listGraphTw3)
        {
          line = line + ";" + d.Y;

        }
        file.WriteLine(line);

        line = "Pesaje TWL 04->";
        foreach (PointPair d in this.listGraphTw4)
        {
          line = line + ";" + d.Y;

        }
        file.WriteLine(line);


        file.Close();
        MessageBox.Show("Fichero export generado con exito: " + fileName);
      }
      catch (Exception ex) {
        MessageBox.Show("Error a crear export: " + ex.Message);
      }
    }
  
  }
}

    
  
