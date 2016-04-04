namespace kemen
{
  partial class Datos
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos));
      this.vwDatos = new System.Windows.Forms.ListView();
      this.hd1 = new System.Windows.Forms.ColumnHeader();
      this.hd2 = new System.Windows.Forms.ColumnHeader();
      this.btnExportar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // vwDatos
      // 
      this.vwDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hd1,
            this.hd2});
      this.vwDatos.Location = new System.Drawing.Point(-1, 2);
      this.vwDatos.Name = "vwDatos";
      this.vwDatos.Size = new System.Drawing.Size(242, 303);
      this.vwDatos.TabIndex = 0;
      this.vwDatos.UseCompatibleStateImageBehavior = false;
      this.vwDatos.View = System.Windows.Forms.View.Details;
      // 
      // hd1
      // 
      this.hd1.Text = "Fecha";
      this.hd1.Width = 102;
      // 
      // hd2
      // 
      this.hd2.Text = "Peso";
      this.hd2.Width = 135;
      // 
      // btnExportar
      // 
      this.btnExportar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnExportar.Location = new System.Drawing.Point(80, 313);
      this.btnExportar.Name = "btnExportar";
      this.btnExportar.Size = new System.Drawing.Size(75, 23);
      this.btnExportar.TabIndex = 1;
      this.btnExportar.Text = "Exportar";
      this.btnExportar.UseVisualStyleBackColor = true;
      // 
      // Datos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(240, 346);
      this.Controls.Add(this.btnExportar);
      this.Controls.Add(this.vwDatos);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Datos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Datos Solicitados";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView vwDatos;
    private System.Windows.Forms.ColumnHeader hd1;
    private System.Windows.Forms.ColumnHeader hd2;
    private System.Windows.Forms.Button btnExportar;
  }
}