using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace kemen
{
  public partial class Launcher : Form
  {
    private ArrayList lstCB = new ArrayList();
    private ArrayList lstKEMEN = new ArrayList();
    private NameValueCollection cnfValues = ConfigurationManager.AppSettings;
    private Thread threadKEMENMonitor = null;
    public Launcher()
    {
      InitializeComponent();
      LoadKemenLaucherList();
    }
    /// <summary>
    /// 
    /// </summary>
    private void LoadKemenLaucherList() {
      int centro = this.ClientSize.Height /2 ;
      int mitadDeControles = Convert.ToInt16(cnfValues["numGruas"]) / 2;
      int posicionTop = (this.ClientSize.Height / 2) - (mitadDeControles * 2);
      for (int i = 0; i < Convert.ToInt16(cnfValues["numGruas"]); i++)
      {
        System.Windows.Forms.CheckBox txt = new System.Windows.Forms.CheckBox ();
        this.Controls.Add(txt);
        this.lstCB.Add(txt);
        String idconfig = "nombreGrua"+i;
        txt.Text = cnfValues[idconfig];

        txt.Left = (this.ClientSize.Width - txt.Width) / 2;
        txt.Top = (posicionTop + i * 50 - txt.Height) / 2;
      }
      
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnLanzar_Click(object sender, EventArgs e)
    {
      int i = 0;
      foreach (System.Windows.Forms.CheckBox item in lstCB)
      {
        if (item.Checked == true) {
          Boolean found = false;
          foreach (kemen kem in lstKEMEN)
          {
            if (kem.Text.CompareTo(cnfValues["nombreGrua" + i]) == 0){
              found = true;
              break;
            }
          }
          if (found == false) {
            kemen kk = new kemen(cnfValues["urlGrua" + i],this);
            kk.Show();
            kk.Text = cnfValues["nombreGrua" + i];
            lstKEMEN.Add(kk);
          }
        }
        i++;
      }
      if (threadKEMENMonitor == null){
        threadKEMENMonitor = new Thread(this.executeKEMENMonitor);
        threadKEMENMonitor.Start();
      }
      this.Hide();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="caption"></param>
    /// <returns></returns>
    public int getIndiceKemen(string caption) 
    {
      int res = 0;
      foreach (kemen kem in lstKEMEN)
      {
        if (kem.Text.CompareTo(caption) == 0)
        {
          break;
        }
        res++;
      }
      return res;
    }
    /// <summary>
    /// 
    /// </summary>
    private void executeKEMENMonitor()
    {
      bool seguir = true;
      while (seguir == true) {
        bool isVisible = false;
        foreach (kemen item in lstKEMEN){
          if (isVisible == false )isVisible = item.Visible;
        }
        if (isVisible == false) {         
          seguir = false;
        }
        else Thread.Sleep(500);
      }
      Environment.Exit(0);
    }
  }
}
