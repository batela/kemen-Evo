namespace kemen
{
  partial class Graficas
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graficas));
      this.zedGraphTw = new ZedGraph.ZedGraphControl();
      this.btnTest = new System.Windows.Forms.Button();
      this.zedGraphTOTAL = new ZedGraph.ZedGraphControl();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // zedGraphTw
      // 
      this.zedGraphTw.Location = new System.Drawing.Point(9, 2);
      this.zedGraphTw.Name = "zedGraphTw";
      this.zedGraphTw.ScrollGrace = 0;
      this.zedGraphTw.ScrollMaxX = 0;
      this.zedGraphTw.ScrollMaxY = 0;
      this.zedGraphTw.ScrollMaxY2 = 0;
      this.zedGraphTw.ScrollMinX = 0;
      this.zedGraphTw.ScrollMinY = 0;
      this.zedGraphTw.ScrollMinY2 = 0;
      this.zedGraphTw.Size = new System.Drawing.Size(642, 275);
      this.zedGraphTw.TabIndex = 0;
      // 
      // btnTest
      // 
      this.btnTest.Location = new System.Drawing.Point(657, 456);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(61, 39);
      this.btnTest.TabIndex = 1;
      this.btnTest.Text = "Actualizar Datos";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // zedGraphTOTAL
      // 
      this.zedGraphTOTAL.Location = new System.Drawing.Point(10, 279);
      this.zedGraphTOTAL.Name = "zedGraphTOTAL";
      this.zedGraphTOTAL.ScrollGrace = 0;
      this.zedGraphTOTAL.ScrollMaxX = 0;
      this.zedGraphTOTAL.ScrollMaxY = 0;
      this.zedGraphTOTAL.ScrollMaxY2 = 0;
      this.zedGraphTOTAL.ScrollMinX = 0;
      this.zedGraphTOTAL.ScrollMinY = 0;
      this.zedGraphTOTAL.ScrollMinY2 = 0;
      this.zedGraphTOTAL.Size = new System.Drawing.Size(641, 275);
      this.zedGraphTOTAL.TabIndex = 2;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(657, 515);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(61, 39);
      this.button1.TabIndex = 3;
      this.button1.Text = "Exportar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Graficas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(207)))), ((int)(((byte)(107)))));
      this.ClientSize = new System.Drawing.Size(719, 572);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.zedGraphTOTAL);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.zedGraphTw);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(725, 600);
      this.MinimumSize = new System.Drawing.Size(725, 600);
      this.Name = "Graficas";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "KEMEN - Gráficas de control";
      this.Load += new System.EventHandler(this.Graficas_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private ZedGraph.ZedGraphControl zedGraphTw;
    private System.Windows.Forms.Button btnTest;
    private ZedGraph.ZedGraphControl zedGraphTOTAL;
    private System.Windows.Forms.Button button1;

  }
}