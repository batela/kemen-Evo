using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace kemen
{
  class GraficaData
  {
    private int tinicio;

    public int Tinicio
    {
      get { return tinicio; }
      set { tinicio = value; }
    }
    private int npesadas;

    public int Npesadas
    {
      get { return npesadas; }
      set { npesadas = value; }
    }
    private int ndatos;

    public int Ndatos
    {
      get { return ndatos; }
      set { ndatos = value; }
    }
    private ArrayList ptotal;

    public ArrayList Ptotal
    {
      get { return ptotal; }
      set { ptotal = value; }
    }
    private ArrayList ptw1;

    public ArrayList Ptw1
    {
      get { return ptw1; }
      set { ptw1 = value; }
    }
    private ArrayList ptw2;

    public ArrayList Ptw2
    {
      get { return ptw2; }
      set { ptw2 = value; }
    }
    private ArrayList ptw3;

    public ArrayList Ptw3
    {
      get { return ptw3; }
      set { ptw3 = value; }
    }
    private ArrayList ptw4;

    public ArrayList Ptw4
    {
      get { return ptw4; }
      set { ptw4 = value; }
    }

    public GraficaData()
    {
      Ptotal = new ArrayList();
      Ptw1 = new ArrayList();
      Ptw2 = new ArrayList();
      Ptw3 = new ArrayList();
      Ptw4 = new ArrayList();         
    }

  }
}
