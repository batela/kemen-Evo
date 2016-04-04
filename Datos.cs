using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kemen
{
  public partial class Datos : Form
  {
    public Datos()
    {
      InitializeComponent();
    }
    /// <summary>
    /// 
    /// </summary>
    public void CargarDatos(List<GruaTrenData> datos) 
    {
      vwDatos.Items.Clear();
      foreach (GruaTrenData d in datos) {        
        ListViewItem item = new ListViewItem(d.Fecha);
        item.SubItems.Add(d.Valor);
        vwDatos.Items.Add(item);
        //Console.WriteLine("Linea:" + d.Fecha + ":" + d.Valor);
      }
      
    }
  }
}
