namespace kemen
{
  partial class Launcher
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
      this.btnLanzar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnLanzar
      // 
      this.btnLanzar.Location = new System.Drawing.Point(45, 191);
      this.btnLanzar.Name = "btnLanzar";
      this.btnLanzar.Size = new System.Drawing.Size(75, 23);
      this.btnLanzar.TabIndex = 0;
      this.btnLanzar.Text = "Lanzar";
      this.btnLanzar.UseVisualStyleBackColor = true;
      this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
      // 
      // Launcher
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(173, 216);
      this.Controls.Add(this.btnLanzar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Launcher";
      this.Text = "Lanzador KEMEN";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnLanzar;
  }
}