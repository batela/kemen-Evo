using System;
using System.Collections.Generic;
using System.Collections.Specialized;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using log4net;

namespace kemen
{
  public partial class Periferia : Form
  {
    private NameValueCollection cnfValues = ConfigurationManager.AppSettings;
    private ILog log = log4net.LogManager.GetLogger(typeof(kemen));

    public Periferia()
    {
      InitializeComponent();
      this.lblED5.Text = cnfValues["ed5"];
      this.lblED6.Text = cnfValues["ed6"];
      this.lblED7.Text = cnfValues["ed7"];
      this.lblED8.Text = cnfValues["ed8"];
      this.lblED9.Text = cnfValues["ed9"];
      this.lblED10.Text = cnfValues["ed10"];
      this.lblED11.Text = cnfValues["ed11"];
      this.lblED12.Text = cnfValues["ed12"];
          
    }

    public void executePeriferiaMonitor(GruaTrenData data)
    {
      try
      {
        
          if (data.Ed5 == "F") {
            this.btnED5.BackColor = Color.Red;
            this.lblED5.ForeColor = Color.Black;
          }
          else {
            this.btnED5.BackColor = Color.Lime;
            this.lblED5.ForeColor = Color.Lime;
          }
          if (data.Ed6 == "F")
          {
            this.btnED6.BackColor = Color.Red;
            this.lblED6.ForeColor = Color.Black;
          }
          else
          {
            this.btnED6.BackColor = Color.Lime;
            this.lblED6.ForeColor = Color.Lime;
          }
          if (data.Ed7 == "F")
          {
            this.btnED7.BackColor = Color.Red;
            this.lblED7.ForeColor = Color.Black;
          }
          else
          {
            this.btnED7.BackColor = Color.Lime;
            this.lblED7.ForeColor = Color.Lime;
          }
          if (data.Ed8 == "F")
          {
            this.btnED8.BackColor = Color.Red;
            this.lblED8.ForeColor = Color.Black;
          }
          else
          {
            this.btnED8.BackColor = Color.Lime;
            this.lblED8.ForeColor = Color.Lime;
          }
          if (data.Ed9 == "F")
          {
            this.btnED9.BackColor = Color.Red;
            this.lblED9.ForeColor = Color.Black;
          }
          else
          {
            this.btnED9.BackColor = Color.Lime;
            this.lblED9.ForeColor = Color.Lime;
          }
          if (data.Ed10 == "F")
          {
            this.btnED10.BackColor = Color.Red;
            this.lblED10.ForeColor = Color.Black;
          }
          else
          {
            this.btnED10.BackColor = Color.Lime;
            this.lblED10.ForeColor = Color.Lime;
          }
          if (data.Ed11== "F")
          {
            this.btnED111.BackColor = Color.Red;
            this.lblED11.ForeColor = Color.Black;
          }
          else
          {
            this.btnED111.BackColor = Color.Lime;
            this.lblED11.ForeColor = Color.Lime;
          }
          if (data.Ed12 == "F")
          {
            this.btnED12.BackColor = Color.Red;
            this.lblED12.ForeColor = Color.Black;
          }
          else
          {
            this.btnED12.BackColor = Color.Lime;
            this.lblED12.ForeColor = Color.Lime;
          }
         
        
      }
      catch (Exception ex)
      {
        //lblMaxPesoHora.Text = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
        //MessageBox.Show("Error al acceder a URL: " + url);
        log.Error("Error al actualizar estado de IOs : " + ex.Message);
      }
      finally
      {
       
      }
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

  }
}
