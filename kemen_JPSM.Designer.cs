namespace kemen
{
    partial class kemen
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kemen));
          this.startDate = new System.Windows.Forms.DateTimePicker();
          this.endDate = new System.Windows.Forms.DateTimePicker();
          this.btnExportar = new System.Windows.Forms.Button();
          this.label5 = new System.Windows.Forms.Label();
          this.label6 = new System.Windows.Forms.Label();
          this.btnVer = new System.Windows.Forms.Button();
          this.scPesaje = new TB.Instruments.SlidingScale();
          this.vwUltimos = new System.Windows.Forms.ListView();
          this.clFecha = new System.Windows.Forms.ColumnHeader();
          this.clPesaje = new System.Windows.Forms.ColumnHeader();
          this.lblPeso = new System.Windows.Forms.Label();
          this.lblFecha = new System.Windows.Forms.Label();
          this.lblComunica = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.button1 = new System.Windows.Forms.Button();
          this.label4 = new System.Windows.Forms.Label();
          this.label7 = new System.Windows.Forms.Label();
          this.govBascula = new System.Windows.Forms.GroupBox();
          this.lblTextoUltimo = new System.Windows.Forms.Label();
          this.lblTextoActual = new System.Windows.Forms.Label();
          this.label3 = new System.Windows.Forms.Label();
          this.lblUltimo = new System.Windows.Forms.Label();
          this.label1 = new System.Windows.Forms.Label();
          this.PibCom = new System.Windows.Forms.PictureBox();
          this.govHistoricos = new System.Windows.Forms.GroupBox();
          this.btnVerMini = new System.Windows.Forms.Button();
          this.lblTw1 = new System.Windows.Forms.Label();
          this.lblKg2 = new System.Windows.Forms.Label();
          this.lblTw2 = new System.Windows.Forms.Label();
          this.lblTw3 = new System.Windows.Forms.Label();
          this.lblTw4 = new System.Windows.Forms.Label();
          this.lblSensor2 = new System.Windows.Forms.Label();
          this.govContenedor = new System.Windows.Forms.GroupBox();
          this.lblCMy = new System.Windows.Forms.Label();
          this.lblCMx = new System.Windows.Forms.Label();
          this.lblCMasas2 = new System.Windows.Forms.Label();
          this.lblCMasas = new System.Windows.Forms.Label();
          this.PibBola = new System.Windows.Forms.PictureBox();
          this.lblSensor1 = new System.Windows.Forms.Label();
          this.lblKg1 = new System.Windows.Forms.Label();
          this.lblSensor4 = new System.Windows.Forms.Label();
          this.lblKg4 = new System.Windows.Forms.Label();
          this.lblSensor3 = new System.Windows.Forms.Label();
          this.lblKg3 = new System.Windows.Forms.Label();
          this.PibContenedor = new System.Windows.Forms.PictureBox();
          this.lblBatelaVersion = new System.Windows.Forms.Label();
          this.btnED1 = new System.Windows.Forms.Button();
          this.lblED1 = new System.Windows.Forms.Label();
          this.lblED2 = new System.Windows.Forms.Label();
          this.btnED2 = new System.Windows.Forms.Button();
          this.lblED3 = new System.Windows.Forms.Label();
          this.btnED3 = new System.Windows.Forms.Button();
          this.lblED4 = new System.Windows.Forms.Label();
          this.btnED4 = new System.Windows.Forms.Button();
          this.govEDs = new System.Windows.Forms.GroupBox();
          this.govAlarm = new System.Windows.Forms.GroupBox();
          this.lblAlarm4 = new System.Windows.Forms.Label();
          this.btnAlarm4 = new System.Windows.Forms.Button();
          this.lblAlarm3 = new System.Windows.Forms.Label();
          this.btnAlarm3 = new System.Windows.Forms.Button();
          this.lblAlarm2 = new System.Windows.Forms.Label();
          this.btnAlarm2 = new System.Windows.Forms.Button();
          this.lblAlarm1 = new System.Windows.Forms.Label();
          this.btnAlarm1 = new System.Windows.Forms.Button();
          this.button2 = new System.Windows.Forms.Button();
          this.btnGraficas = new System.Windows.Forms.Button();
          this.btnConfig = new System.Windows.Forms.Button();
          this.picBATELA = new System.Windows.Forms.PictureBox();
          this.pictureBox5 = new System.Windows.Forms.PictureBox();
          this.pictureBox1 = new System.Windows.Forms.PictureBox();
          this.pictureBox6 = new System.Windows.Forms.PictureBox();
          this.button3 = new System.Windows.Forms.Button();
          this.govBascula.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.PibCom)).BeginInit();
          this.govHistoricos.SuspendLayout();
          this.govContenedor.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.PibBola)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.PibContenedor)).BeginInit();
          this.govEDs.SuspendLayout();
          this.govAlarm.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.picBATELA)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
          this.SuspendLayout();
          // 
          // startDate
          // 
          this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
          this.startDate.Location = new System.Drawing.Point(30, 156);
          this.startDate.Name = "startDate";
          this.startDate.Size = new System.Drawing.Size(115, 20);
          this.startDate.TabIndex = 4;
          // 
          // endDate
          // 
          this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
          this.endDate.Location = new System.Drawing.Point(188, 156);
          this.endDate.Name = "endDate";
          this.endDate.Size = new System.Drawing.Size(115, 20);
          this.endDate.TabIndex = 5;
          // 
          // btnExportar
          // 
          this.btnExportar.Location = new System.Drawing.Point(142, 182);
          this.btnExportar.Name = "btnExportar";
          this.btnExportar.Size = new System.Drawing.Size(65, 41);
          this.btnExportar.TabIndex = 6;
          this.btnExportar.Text = "Exportar";
          this.btnExportar.UseVisualStyleBackColor = true;
          this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
          // 
          // label5
          // 
          this.label5.AutoSize = true;
          this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label5.Location = new System.Drawing.Point(28, 137);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(88, 16);
          this.label5.TabIndex = 8;
          this.label5.Text = "Fecha Inicio";
          // 
          // label6
          // 
          this.label6.AutoSize = true;
          this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label6.Location = new System.Drawing.Point(186, 137);
          this.label6.Name = "label6";
          this.label6.Size = new System.Drawing.Size(72, 16);
          this.label6.TabIndex = 9;
          this.label6.Text = "Fecha Fin";
          // 
          // btnVer
          // 
          this.btnVer.Location = new System.Drawing.Point(97, 182);
          this.btnVer.Name = "btnVer";
          this.btnVer.Size = new System.Drawing.Size(42, 41);
          this.btnVer.TabIndex = 11;
          this.btnVer.Text = "Ver";
          this.btnVer.UseVisualStyleBackColor = true;
          this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
          // 
          // scPesaje
          // 
          this.scPesaje.BackColor = System.Drawing.Color.Lime;
          this.scPesaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.scPesaje.ForeColor = System.Drawing.Color.Black;
          this.scPesaje.LargeTicksCount = 6;
          this.scPesaje.Location = new System.Drawing.Point(96, 61);
          this.scPesaje.Name = "scPesaje";
          this.scPesaje.ScaleRange = 60000;
          this.scPesaje.Size = new System.Drawing.Size(537, 39);
          this.scPesaje.TabIndex = 12;
          // 
          // vwUltimos
          // 
          this.vwUltimos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clFecha,
            this.clPesaje});
          this.vwUltimos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.vwUltimos.FullRowSelect = true;
          this.vwUltimos.Location = new System.Drawing.Point(15, 19);
          this.vwUltimos.Name = "vwUltimos";
          this.vwUltimos.Scrollable = false;
          this.vwUltimos.Size = new System.Drawing.Size(301, 117);
          this.vwUltimos.TabIndex = 13;
          this.vwUltimos.UseCompatibleStateImageBehavior = false;
          this.vwUltimos.View = System.Windows.Forms.View.Details;
          this.vwUltimos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vwUltimos_MouseClick);
          // 
          // clFecha
          // 
          this.clFecha.Text = "Fecha y Hora";
          this.clFecha.Width = 170;
          // 
          // clPesaje
          // 
          this.clPesaje.Text = "Peso";
          this.clPesaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
          this.clPesaje.Width = 100;
          // 
          // lblPeso
          // 
          this.lblPeso.AutoSize = true;
          this.lblPeso.BackColor = System.Drawing.Color.White;
          this.lblPeso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblPeso.Location = new System.Drawing.Point(177, 21);
          this.lblPeso.MinimumSize = new System.Drawing.Size(140, 0);
          this.lblPeso.Name = "lblPeso";
          this.lblPeso.Size = new System.Drawing.Size(143, 39);
          this.lblPeso.TabIndex = 14;
          this.lblPeso.Text = "88888.8";
          this.lblPeso.TextAlign = System.Drawing.ContentAlignment.TopRight;
          // 
          // lblFecha
          // 
          this.lblFecha.AutoSize = true;
          this.lblFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblFecha.Location = new System.Drawing.Point(259, 104);
          this.lblFecha.Name = "lblFecha";
          this.lblFecha.Size = new System.Drawing.Size(23, 14);
          this.lblFecha.TabIndex = 15;
          this.lblFecha.Text = "dd";
          // 
          // lblComunica
          // 
          this.lblComunica.Anchor = System.Windows.Forms.AnchorStyles.None;
          this.lblComunica.BackColor = System.Drawing.Color.White;
          this.lblComunica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.lblComunica.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Italic);
          this.lblComunica.Location = new System.Drawing.Point(5, 98);
          this.lblComunica.Name = "lblComunica";
          this.lblComunica.Size = new System.Drawing.Size(87, 16);
          this.lblComunica.TabIndex = 16;
          this.lblComunica.Text = "COMUNICA";
          this.lblComunica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label2.Location = new System.Drawing.Point(200, 104);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(53, 14);
          this.label2.TabIndex = 18;
          this.label2.Text = "FECHA:";
          // 
          // button1
          // 
          this.button1.Location = new System.Drawing.Point(22, 183);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(72, 41);
          this.button1.TabIndex = 20;
          this.button1.Text = "Ver Valores Máximos";
          this.button1.UseVisualStyleBackColor = true;
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
          this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label4.Location = new System.Drawing.Point(344, 17);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(233, 17);
          this.label4.TabIndex = 24;
          this.label4.Text = "Sistemas de pesaje industrial";
          // 
          // label7
          // 
          this.label7.AutoSize = true;
          this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
          this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label7.Location = new System.Drawing.Point(388, 34);
          this.label7.Name = "label7";
          this.label7.Size = new System.Drawing.Size(151, 17);
          this.label7.TabIndex = 25;
          this.label7.Text = "www.dinaksa.com";
          // 
          // govBascula
          // 
          this.govBascula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
          this.govBascula.Controls.Add(this.lblTextoUltimo);
          this.govBascula.Controls.Add(this.lblTextoActual);
          this.govBascula.Controls.Add(this.label3);
          this.govBascula.Controls.Add(this.lblUltimo);
          this.govBascula.Controls.Add(this.label2);
          this.govBascula.Controls.Add(this.label1);
          this.govBascula.Controls.Add(this.lblComunica);
          this.govBascula.Controls.Add(this.PibCom);
          this.govBascula.Controls.Add(this.lblFecha);
          this.govBascula.Controls.Add(this.scPesaje);
          this.govBascula.Controls.Add(this.lblPeso);
          this.govBascula.Location = new System.Drawing.Point(9, 67);
          this.govBascula.Name = "govBascula";
          this.govBascula.Size = new System.Drawing.Size(659, 124);
          this.govBascula.TabIndex = 26;
          this.govBascula.TabStop = false;
          // 
          // lblTextoUltimo
          // 
          this.lblTextoUltimo.AutoSize = true;
          this.lblTextoUltimo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblTextoUltimo.Location = new System.Drawing.Point(445, 8);
          this.lblTextoUltimo.Name = "lblTextoUltimo";
          this.lblTextoUltimo.Size = new System.Drawing.Size(86, 13);
          this.lblTextoUltimo.TabIndex = 22;
          this.lblTextoUltimo.Text = "ULTIMO PESO";
          // 
          // lblTextoActual
          // 
          this.lblTextoActual.AutoSize = true;
          this.lblTextoActual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblTextoActual.Location = new System.Drawing.Point(211, 8);
          this.lblTextoActual.Name = "lblTextoActual";
          this.lblTextoActual.Size = new System.Drawing.Size(79, 13);
          this.lblTextoActual.TabIndex = 21;
          this.lblTextoActual.Text = "PESO TOTAL";
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label3.Location = new System.Drawing.Point(557, 33);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(37, 18);
          this.label3.TabIndex = 20;
          this.label3.Text = "Kg.";
          // 
          // lblUltimo
          // 
          this.lblUltimo.AutoSize = true;
          this.lblUltimo.BackColor = System.Drawing.Color.White;
          this.lblUltimo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.lblUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblUltimo.Location = new System.Drawing.Point(414, 21);
          this.lblUltimo.MinimumSize = new System.Drawing.Size(140, 0);
          this.lblUltimo.Name = "lblUltimo";
          this.lblUltimo.Size = new System.Drawing.Size(143, 39);
          this.lblUltimo.TabIndex = 19;
          this.lblUltimo.Text = "88888.8";
          this.lblUltimo.TextAlign = System.Drawing.ContentAlignment.TopRight;
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label1.Location = new System.Drawing.Point(320, 33);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(37, 18);
          this.label1.TabIndex = 16;
          this.label1.Text = "Kg.";
          // 
          // PibCom
          // 
          this.PibCom.BackColor = System.Drawing.Color.White;
          this.PibCom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.PibCom.Image = global::kemen.Properties.Resources.bascula;
          this.PibCom.Location = new System.Drawing.Point(14, 25);
          this.PibCom.Name = "PibCom";
          this.PibCom.Size = new System.Drawing.Size(68, 65);
          this.PibCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
          this.PibCom.TabIndex = 15;
          this.PibCom.TabStop = false;
          // 
          // govHistoricos
          // 
          this.govHistoricos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
          this.govHistoricos.Controls.Add(this.button3);
          this.govHistoricos.Controls.Add(this.btnVerMini);
          this.govHistoricos.Controls.Add(this.vwUltimos);
          this.govHistoricos.Controls.Add(this.btnVer);
          this.govHistoricos.Controls.Add(this.label6);
          this.govHistoricos.Controls.Add(this.label5);
          this.govHistoricos.Controls.Add(this.button1);
          this.govHistoricos.Controls.Add(this.btnExportar);
          this.govHistoricos.Controls.Add(this.endDate);
          this.govHistoricos.Controls.Add(this.startDate);
          this.govHistoricos.Location = new System.Drawing.Point(684, 69);
          this.govHistoricos.Name = "govHistoricos";
          this.govHistoricos.Size = new System.Drawing.Size(327, 235);
          this.govHistoricos.TabIndex = 27;
          this.govHistoricos.TabStop = false;
          this.govHistoricos.Text = "REGISTRO DE VALORES";
          // 
          // btnVerMini
          // 
          this.btnVerMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btnVerMini.Location = new System.Drawing.Point(210, 182);
          this.btnVerMini.Name = "btnVerMini";
          this.btnVerMini.Size = new System.Drawing.Size(51, 41);
          this.btnVerMini.TabIndex = 21;
          this.btnVerMini.Text = "MINI";
          this.btnVerMini.UseVisualStyleBackColor = true;
          this.btnVerMini.Click += new System.EventHandler(this.btnVerMini_Click);
          // 
          // lblTw1
          // 
          this.lblTw1.Anchor = System.Windows.Forms.AnchorStyles.Right;
          this.lblTw1.BackColor = System.Drawing.Color.White;
          this.lblTw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblTw1.Location = new System.Drawing.Point(476, 63);
          this.lblTw1.Name = "lblTw1";
          this.lblTw1.Size = new System.Drawing.Size(141, 37);
          this.lblTw1.TabIndex = 19;
          this.lblTw1.Text = "88888.8";
          this.lblTw1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // lblKg2
          // 
          this.lblKg2.AutoSize = true;
          this.lblKg2.BackColor = System.Drawing.Color.White;
          this.lblKg2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblKg2.Location = new System.Drawing.Point(151, 63);
          this.lblKg2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
          this.lblKg2.MinimumSize = new System.Drawing.Size(30, 37);
          this.lblKg2.Name = "lblKg2";
          this.lblKg2.Size = new System.Drawing.Size(30, 37);
          this.lblKg2.TabIndex = 19;
          this.lblKg2.Text = "Kg.";
          this.lblKg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // lblTw2
          // 
          this.lblTw2.Anchor = System.Windows.Forms.AnchorStyles.Right;
          this.lblTw2.BackColor = System.Drawing.Color.White;
          this.lblTw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblTw2.Location = new System.Drawing.Point(10, 63);
          this.lblTw2.MinimumSize = new System.Drawing.Size(100, 0);
          this.lblTw2.Name = "lblTw2";
          this.lblTw2.Size = new System.Drawing.Size(141, 37);
          this.lblTw2.TabIndex = 29;
          this.lblTw2.Text = "88888.8";
          this.lblTw2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // lblTw3
          // 
          this.lblTw3.Anchor = System.Windows.Forms.AnchorStyles.Right;
          this.lblTw3.BackColor = System.Drawing.Color.White;
          this.lblTw3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblTw3.Location = new System.Drawing.Point(10, 209);
          this.lblTw3.Name = "lblTw3";
          this.lblTw3.Size = new System.Drawing.Size(141, 37);
          this.lblTw3.TabIndex = 30;
          this.lblTw3.Text = "88888.8";
          this.lblTw3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // lblTw4
          // 
          this.lblTw4.Anchor = System.Windows.Forms.AnchorStyles.Right;
          this.lblTw4.BackColor = System.Drawing.Color.White;
          this.lblTw4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblTw4.Location = new System.Drawing.Point(476, 209);
          this.lblTw4.Name = "lblTw4";
          this.lblTw4.Size = new System.Drawing.Size(141, 37);
          this.lblTw4.TabIndex = 31;
          this.lblTw4.Text = "88888.8";
          this.lblTw4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // lblSensor2
          // 
          this.lblSensor2.AutoSize = true;
          this.lblSensor2.BackColor = System.Drawing.Color.Silver;
          this.lblSensor2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblSensor2.Location = new System.Drawing.Point(10, 47);
          this.lblSensor2.MinimumSize = new System.Drawing.Size(171, 15);
          this.lblSensor2.Name = "lblSensor2";
          this.lblSensor2.Size = new System.Drawing.Size(171, 16);
          this.lblSensor2.TabIndex = 34;
          this.lblSensor2.Text = "Sensor 2";
          this.lblSensor2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
          // 
          // govContenedor
          // 
          this.govContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
          this.govContenedor.Controls.Add(this.lblCMy);
          this.govContenedor.Controls.Add(this.lblCMx);
          this.govContenedor.Controls.Add(this.lblCMasas2);
          this.govContenedor.Controls.Add(this.lblCMasas);
          this.govContenedor.Controls.Add(this.PibBola);
          this.govContenedor.Controls.Add(this.lblSensor1);
          this.govContenedor.Controls.Add(this.lblKg1);
          this.govContenedor.Controls.Add(this.lblSensor4);
          this.govContenedor.Controls.Add(this.lblKg4);
          this.govContenedor.Controls.Add(this.lblSensor3);
          this.govContenedor.Controls.Add(this.lblKg3);
          this.govContenedor.Controls.Add(this.lblSensor2);
          this.govContenedor.Controls.Add(this.lblTw2);
          this.govContenedor.Controls.Add(this.lblKg2);
          this.govContenedor.Controls.Add(this.lblTw1);
          this.govContenedor.Controls.Add(this.lblTw4);
          this.govContenedor.Controls.Add(this.lblTw3);
          this.govContenedor.Controls.Add(this.PibContenedor);
          this.govContenedor.Location = new System.Drawing.Point(9, 204);
          this.govContenedor.Name = "govContenedor";
          this.govContenedor.Size = new System.Drawing.Size(659, 350);
          this.govContenedor.TabIndex = 34;
          this.govContenedor.TabStop = false;
          // 
          // lblCMy
          // 
          this.lblCMy.AutoSize = true;
          this.lblCMy.BackColor = System.Drawing.Color.Transparent;
          this.lblCMy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblCMy.ForeColor = System.Drawing.Color.White;
          this.lblCMy.Location = new System.Drawing.Point(388, 310);
          this.lblCMy.Name = "lblCMy";
          this.lblCMy.Size = new System.Drawing.Size(44, 16);
          this.lblCMy.TabIndex = 43;
          this.lblCMy.Text = "888.8";
          // 
          // lblCMx
          // 
          this.lblCMx.AutoSize = true;
          this.lblCMx.BackColor = System.Drawing.Color.Transparent;
          this.lblCMx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblCMx.ForeColor = System.Drawing.Color.White;
          this.lblCMx.Location = new System.Drawing.Point(277, 310);
          this.lblCMx.Name = "lblCMx";
          this.lblCMx.Size = new System.Drawing.Size(44, 16);
          this.lblCMx.TabIndex = 42;
          this.lblCMx.Text = "888.8";
          // 
          // lblCMasas2
          // 
          this.lblCMasas2.AutoSize = true;
          this.lblCMasas2.BackColor = System.Drawing.Color.Transparent;
          this.lblCMasas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblCMasas2.Location = new System.Drawing.Point(191, 310);
          this.lblCMasas2.MinimumSize = new System.Drawing.Size(282, 16);
          this.lblCMasas2.Name = "lblCMasas2";
          this.lblCMasas2.Size = new System.Drawing.Size(282, 16);
          this.lblCMasas2.TabIndex = 46;
          this.lblCMasas2.Text = "           Eje X                  Eje Y                    ";
          // 
          // lblCMasas
          // 
          this.lblCMasas.AutoSize = true;
          this.lblCMasas.BackColor = System.Drawing.Color.Transparent;
          this.lblCMasas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblCMasas.Location = new System.Drawing.Point(191, 294);
          this.lblCMasas.Name = "lblCMasas";
          this.lblCMasas.Size = new System.Drawing.Size(282, 16);
          this.lblCMasas.TabIndex = 45;
          this.lblCMasas.Text = "Desplazamiento del centro de masas %";
          // 
          // PibBola
          // 
          this.PibBola.BackColor = System.Drawing.Color.Transparent;
          this.PibBola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
          this.PibBola.Image = global::kemen.Properties.Resources.bola_31;
          this.PibBola.Location = new System.Drawing.Point(301, 128);
          this.PibBola.Name = "PibBola";
          this.PibBola.Size = new System.Drawing.Size(50, 50);
          this.PibBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
          this.PibBola.TabIndex = 44;
          this.PibBola.TabStop = false;
          // 
          // lblSensor1
          // 
          this.lblSensor1.AutoSize = true;
          this.lblSensor1.BackColor = System.Drawing.Color.Silver;
          this.lblSensor1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblSensor1.Location = new System.Drawing.Point(476, 47);
          this.lblSensor1.MinimumSize = new System.Drawing.Size(171, 15);
          this.lblSensor1.Name = "lblSensor1";
          this.lblSensor1.Size = new System.Drawing.Size(171, 16);
          this.lblSensor1.TabIndex = 41;
          this.lblSensor1.Text = "Sensor 1";
          this.lblSensor1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
          // 
          // lblKg1
          // 
          this.lblKg1.AutoSize = true;
          this.lblKg1.BackColor = System.Drawing.Color.White;
          this.lblKg1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblKg1.Location = new System.Drawing.Point(617, 63);
          this.lblKg1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
          this.lblKg1.MinimumSize = new System.Drawing.Size(30, 37);
          this.lblKg1.Name = "lblKg1";
          this.lblKg1.Size = new System.Drawing.Size(30, 37);
          this.lblKg1.TabIndex = 40;
          this.lblKg1.Text = "Kg.";
          this.lblKg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // lblSensor4
          // 
          this.lblSensor4.AutoSize = true;
          this.lblSensor4.BackColor = System.Drawing.Color.Silver;
          this.lblSensor4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblSensor4.Location = new System.Drawing.Point(476, 193);
          this.lblSensor4.MinimumSize = new System.Drawing.Size(171, 15);
          this.lblSensor4.Name = "lblSensor4";
          this.lblSensor4.Size = new System.Drawing.Size(171, 16);
          this.lblSensor4.TabIndex = 39;
          this.lblSensor4.Text = "Sensor 4";
          this.lblSensor4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
          // 
          // lblKg4
          // 
          this.lblKg4.AutoSize = true;
          this.lblKg4.BackColor = System.Drawing.Color.White;
          this.lblKg4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblKg4.Location = new System.Drawing.Point(617, 209);
          this.lblKg4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
          this.lblKg4.MinimumSize = new System.Drawing.Size(30, 37);
          this.lblKg4.Name = "lblKg4";
          this.lblKg4.Size = new System.Drawing.Size(30, 37);
          this.lblKg4.TabIndex = 38;
          this.lblKg4.Text = "Kg.";
          this.lblKg4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // lblSensor3
          // 
          this.lblSensor3.AutoSize = true;
          this.lblSensor3.BackColor = System.Drawing.Color.Silver;
          this.lblSensor3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblSensor3.Location = new System.Drawing.Point(10, 193);
          this.lblSensor3.MinimumSize = new System.Drawing.Size(171, 15);
          this.lblSensor3.Name = "lblSensor3";
          this.lblSensor3.Size = new System.Drawing.Size(171, 16);
          this.lblSensor3.TabIndex = 37;
          this.lblSensor3.Text = "Sensor 3";
          this.lblSensor3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
          // 
          // lblKg3
          // 
          this.lblKg3.AutoSize = true;
          this.lblKg3.BackColor = System.Drawing.Color.White;
          this.lblKg3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblKg3.Location = new System.Drawing.Point(151, 209);
          this.lblKg3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
          this.lblKg3.MinimumSize = new System.Drawing.Size(30, 37);
          this.lblKg3.Name = "lblKg3";
          this.lblKg3.Size = new System.Drawing.Size(30, 37);
          this.lblKg3.TabIndex = 36;
          this.lblKg3.Text = "Kg.";
          this.lblKg3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // PibContenedor
          // 
          this.PibContenedor.BackColor = System.Drawing.Color.Transparent;
          this.PibContenedor.Image = global::kemen.Properties.Resources.FondoContainerCM;
          this.PibContenedor.Location = new System.Drawing.Point(9, 20);
          this.PibContenedor.Name = "PibContenedor";
          this.PibContenedor.Size = new System.Drawing.Size(642, 325);
          this.PibContenedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
          this.PibContenedor.TabIndex = 35;
          this.PibContenedor.TabStop = false;
          // 
          // lblBatelaVersion
          // 
          this.lblBatelaVersion.AutoSize = true;
          this.lblBatelaVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(64)))), ((int)(((byte)(154)))));
          this.lblBatelaVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.lblBatelaVersion.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblBatelaVersion.ForeColor = System.Drawing.Color.White;
          this.lblBatelaVersion.Location = new System.Drawing.Point(923, 555);
          this.lblBatelaVersion.Name = "lblBatelaVersion";
          this.lblBatelaVersion.Size = new System.Drawing.Size(90, 12);
          this.lblBatelaVersion.TabIndex = 38;
          this.lblBatelaVersion.Text = "KEMEN CABIN V3.10";
          // 
          // btnED1
          // 
          this.btnED1.BackColor = System.Drawing.Color.Gray;
          this.btnED1.Location = new System.Drawing.Point(12, 19);
          this.btnED1.Name = "btnED1";
          this.btnED1.Size = new System.Drawing.Size(23, 23);
          this.btnED1.TabIndex = 40;
          this.btnED1.UseVisualStyleBackColor = false;
          // 
          // lblED1
          // 
          this.lblED1.AutoSize = true;
          this.lblED1.BackColor = System.Drawing.Color.White;
          this.lblED1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblED1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
          this.lblED1.Location = new System.Drawing.Point(35, 23);
          this.lblED1.MinimumSize = new System.Drawing.Size(160, 16);
          this.lblED1.Name = "lblED1";
          this.lblED1.Size = new System.Drawing.Size(160, 16);
          this.lblED1.TabIndex = 41;
          this.lblED1.Text = "Mando Subir";
          // 
          // lblED2
          // 
          this.lblED2.AutoSize = true;
          this.lblED2.BackColor = System.Drawing.Color.White;
          this.lblED2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblED2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
          this.lblED2.Location = new System.Drawing.Point(35, 47);
          this.lblED2.MinimumSize = new System.Drawing.Size(160, 16);
          this.lblED2.Name = "lblED2";
          this.lblED2.Size = new System.Drawing.Size(160, 16);
          this.lblED2.TabIndex = 43;
          this.lblED2.Text = "TwistLocks Cerrados";
          // 
          // btnED2
          // 
          this.btnED2.BackColor = System.Drawing.Color.Gray;
          this.btnED2.Location = new System.Drawing.Point(12, 43);
          this.btnED2.Name = "btnED2";
          this.btnED2.Size = new System.Drawing.Size(23, 23);
          this.btnED2.TabIndex = 42;
          this.btnED2.UseVisualStyleBackColor = false;
          // 
          // lblED3
          // 
          this.lblED3.AutoSize = true;
          this.lblED3.BackColor = System.Drawing.Color.White;
          this.lblED3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblED3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
          this.lblED3.Location = new System.Drawing.Point(35, 71);
          this.lblED3.MinimumSize = new System.Drawing.Size(160, 16);
          this.lblED3.Name = "lblED3";
          this.lblED3.Size = new System.Drawing.Size(160, 16);
          this.lblED3.TabIndex = 45;
          this.lblED3.Text = "Palpadores actuados";
          // 
          // btnED3
          // 
          this.btnED3.BackColor = System.Drawing.Color.Gray;
          this.btnED3.Location = new System.Drawing.Point(12, 67);
          this.btnED3.Name = "btnED3";
          this.btnED3.Size = new System.Drawing.Size(23, 23);
          this.btnED3.TabIndex = 44;
          this.btnED3.UseVisualStyleBackColor = false;
          // 
          // lblED4
          // 
          this.lblED4.AutoSize = true;
          this.lblED4.BackColor = System.Drawing.Color.White;
          this.lblED4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblED4.Location = new System.Drawing.Point(35, 95);
          this.lblED4.MinimumSize = new System.Drawing.Size(160, 16);
          this.lblED4.Name = "lblED4";
          this.lblED4.Size = new System.Drawing.Size(160, 16);
          this.lblED4.TabIndex = 47;
          this.lblED4.Text = "Modo 40 Pies";
          // 
          // btnED4
          // 
          this.btnED4.BackColor = System.Drawing.Color.Gray;
          this.btnED4.Location = new System.Drawing.Point(12, 91);
          this.btnED4.Name = "btnED4";
          this.btnED4.Size = new System.Drawing.Size(23, 23);
          this.btnED4.TabIndex = 46;
          this.btnED4.UseVisualStyleBackColor = false;
          // 
          // govEDs
          // 
          this.govEDs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
          this.govEDs.Controls.Add(this.btnED1);
          this.govEDs.Controls.Add(this.lblED1);
          this.govEDs.Controls.Add(this.btnED2);
          this.govEDs.Controls.Add(this.lblED2);
          this.govEDs.Controls.Add(this.btnED3);
          this.govEDs.Controls.Add(this.lblED3);
          this.govEDs.Controls.Add(this.btnED4);
          this.govEDs.Controls.Add(this.lblED4);
          this.govEDs.Location = new System.Drawing.Point(684, 309);
          this.govEDs.Name = "govEDs";
          this.govEDs.Size = new System.Drawing.Size(215, 120);
          this.govEDs.TabIndex = 56;
          this.govEDs.TabStop = false;
          this.govEDs.Text = "ENTRADAS DE CONTROL";
          // 
          // govAlarm
          // 
          this.govAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
          this.govAlarm.Controls.Add(this.lblAlarm4);
          this.govAlarm.Controls.Add(this.btnAlarm4);
          this.govAlarm.Controls.Add(this.lblAlarm3);
          this.govAlarm.Controls.Add(this.btnAlarm3);
          this.govAlarm.Controls.Add(this.lblAlarm2);
          this.govAlarm.Controls.Add(this.btnAlarm2);
          this.govAlarm.Controls.Add(this.lblAlarm1);
          this.govAlarm.Controls.Add(this.btnAlarm1);
          this.govAlarm.Location = new System.Drawing.Point(684, 434);
          this.govAlarm.Name = "govAlarm";
          this.govAlarm.Size = new System.Drawing.Size(215, 120);
          this.govAlarm.TabIndex = 58;
          this.govAlarm.TabStop = false;
          this.govAlarm.Text = "ALARMAS";
          // 
          // lblAlarm4
          // 
          this.lblAlarm4.AutoSize = true;
          this.lblAlarm4.BackColor = System.Drawing.Color.White;
          this.lblAlarm4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblAlarm4.Location = new System.Drawing.Point(35, 92);
          this.lblAlarm4.MinimumSize = new System.Drawing.Size(160, 16);
          this.lblAlarm4.Name = "lblAlarm4";
          this.lblAlarm4.Size = new System.Drawing.Size(160, 16);
          this.lblAlarm4.TabIndex = 63;
          this.lblAlarm4.Text = "Fallo COM Gateway";
          // 
          // btnAlarm4
          // 
          this.btnAlarm4.BackColor = System.Drawing.Color.Gray;
          this.btnAlarm4.Location = new System.Drawing.Point(12, 88);
          this.btnAlarm4.Name = "btnAlarm4";
          this.btnAlarm4.Size = new System.Drawing.Size(23, 23);
          this.btnAlarm4.TabIndex = 62;
          this.btnAlarm4.UseVisualStyleBackColor = false;
          // 
          // lblAlarm3
          // 
          this.lblAlarm3.AutoSize = true;
          this.lblAlarm3.BackColor = System.Drawing.Color.White;
          this.lblAlarm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblAlarm3.Location = new System.Drawing.Point(35, 68);
          this.lblAlarm3.MinimumSize = new System.Drawing.Size(160, 16);
          this.lblAlarm3.Name = "lblAlarm3";
          this.lblAlarm3.Size = new System.Drawing.Size(160, 16);
          this.lblAlarm3.TabIndex = 61;
          this.lblAlarm3.Text = "Fallo COM Nodo";
          // 
          // btnAlarm3
          // 
          this.btnAlarm3.BackColor = System.Drawing.Color.Gray;
          this.btnAlarm3.Location = new System.Drawing.Point(12, 64);
          this.btnAlarm3.Name = "btnAlarm3";
          this.btnAlarm3.Size = new System.Drawing.Size(23, 23);
          this.btnAlarm3.TabIndex = 60;
          this.btnAlarm3.UseVisualStyleBackColor = false;
          // 
          // lblAlarm2
          // 
          this.lblAlarm2.AutoSize = true;
          this.lblAlarm2.BackColor = System.Drawing.Color.White;
          this.lblAlarm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblAlarm2.Location = new System.Drawing.Point(35, 44);
          this.lblAlarm2.MinimumSize = new System.Drawing.Size(160, 16);
          this.lblAlarm2.Name = "lblAlarm2";
          this.lblAlarm2.Size = new System.Drawing.Size(160, 16);
          this.lblAlarm2.TabIndex = 59;
          this.lblAlarm2.Text = "Alarma Enganche";
          // 
          // btnAlarm2
          // 
          this.btnAlarm2.BackColor = System.Drawing.Color.Gray;
          this.btnAlarm2.Location = new System.Drawing.Point(12, 40);
          this.btnAlarm2.Name = "btnAlarm2";
          this.btnAlarm2.Size = new System.Drawing.Size(23, 23);
          this.btnAlarm2.TabIndex = 58;
          this.btnAlarm2.UseVisualStyleBackColor = false;
          // 
          // lblAlarm1
          // 
          this.lblAlarm1.AutoSize = true;
          this.lblAlarm1.BackColor = System.Drawing.Color.White;
          this.lblAlarm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblAlarm1.Location = new System.Drawing.Point(35, 20);
          this.lblAlarm1.MinimumSize = new System.Drawing.Size(160, 16);
          this.lblAlarm1.Name = "lblAlarm1";
          this.lblAlarm1.Size = new System.Drawing.Size(160, 16);
          this.lblAlarm1.TabIndex = 57;
          this.lblAlarm1.Text = "Alarma Excentricidad";
          // 
          // btnAlarm1
          // 
          this.btnAlarm1.BackColor = System.Drawing.Color.Gray;
          this.btnAlarm1.Location = new System.Drawing.Point(12, 16);
          this.btnAlarm1.Name = "btnAlarm1";
          this.btnAlarm1.Size = new System.Drawing.Size(23, 23);
          this.btnAlarm1.TabIndex = 56;
          this.btnAlarm1.UseVisualStyleBackColor = false;
          // 
          // button2
          // 
          this.button2.Image = global::kemen.Properties.Resources.Eds60x60;
          this.button2.Location = new System.Drawing.Point(930, 381);
          this.button2.Name = "button2";
          this.button2.Size = new System.Drawing.Size(70, 65);
          this.button2.TabIndex = 60;
          this.button2.UseVisualStyleBackColor = true;
          this.button2.Click += new System.EventHandler(this.button2_Click);
          // 
          // btnGraficas
          // 
          this.btnGraficas.Image = global::kemen.Properties.Resources.Grafic60x60;
          this.btnGraficas.Location = new System.Drawing.Point(930, 452);
          this.btnGraficas.Name = "btnGraficas";
          this.btnGraficas.Size = new System.Drawing.Size(70, 70);
          this.btnGraficas.TabIndex = 59;
          this.btnGraficas.UseVisualStyleBackColor = true;
          this.btnGraficas.Click += new System.EventHandler(this.btnGraficas_Click);
          // 
          // btnConfig
          // 
          this.btnConfig.Image = global::kemen.Properties.Resources.Config60x60;
          this.btnConfig.Location = new System.Drawing.Point(930, 310);
          this.btnConfig.Name = "btnConfig";
          this.btnConfig.Size = new System.Drawing.Size(70, 70);
          this.btnConfig.TabIndex = 57;
          this.btnConfig.UseVisualStyleBackColor = true;
          this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
          // 
          // picBATELA
          // 
          this.picBATELA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.picBATELA.Image = ((System.Drawing.Image)(resources.GetObject("picBATELA.Image")));
          this.picBATELA.Location = new System.Drawing.Point(923, 523);
          this.picBATELA.Name = "picBATELA";
          this.picBATELA.Size = new System.Drawing.Size(90, 31);
          this.picBATELA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
          this.picBATELA.TabIndex = 23;
          this.picBATELA.TabStop = false;
          // 
          // pictureBox5
          // 
          this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
          this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
          this.pictureBox5.Location = new System.Drawing.Point(17, 8);
          this.pictureBox5.Name = "pictureBox5";
          this.pictureBox5.Size = new System.Drawing.Size(302, 51);
          this.pictureBox5.TabIndex = 36;
          this.pictureBox5.TabStop = false;
          // 
          // pictureBox1
          // 
          this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
          this.pictureBox1.Location = new System.Drawing.Point(876, 5);
          this.pictureBox1.Name = "pictureBox1";
          this.pictureBox1.Size = new System.Drawing.Size(137, 55);
          this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
          this.pictureBox1.TabIndex = 21;
          this.pictureBox1.TabStop = false;
          // 
          // pictureBox6
          // 
          this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
          this.pictureBox6.Location = new System.Drawing.Point(0, 5);
          this.pictureBox6.Name = "pictureBox6";
          this.pictureBox6.Size = new System.Drawing.Size(1025, 58);
          this.pictureBox6.TabIndex = 37;
          this.pictureBox6.TabStop = false;
          // 
          // button3
          // 
          this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.button3.Location = new System.Drawing.Point(264, 182);
          this.button3.Name = "button3";
          this.button3.Size = new System.Drawing.Size(57, 41);
          this.button3.TabIndex = 22;
          this.button3.Text = "INICIO";
          this.button3.UseVisualStyleBackColor = true;
          this.button3.Click += new System.EventHandler(this.button3_Click);
          // 
          // kemen
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(207)))), ((int)(((byte)(107)))));
          this.ClientSize = new System.Drawing.Size(1018, 572);
          this.Controls.Add(this.button2);
          this.Controls.Add(this.btnGraficas);
          this.Controls.Add(this.govAlarm);
          this.Controls.Add(this.btnConfig);
          this.Controls.Add(this.govEDs);
          this.Controls.Add(this.picBATELA);
          this.Controls.Add(this.lblBatelaVersion);
          this.Controls.Add(this.pictureBox5);
          this.Controls.Add(this.govContenedor);
          this.Controls.Add(this.govHistoricos);
          this.Controls.Add(this.govBascula);
          this.Controls.Add(this.label7);
          this.Controls.Add(this.label4);
          this.Controls.Add(this.pictureBox1);
          this.Controls.Add(this.pictureBox6);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.MaximizeBox = false;
          this.MaximumSize = new System.Drawing.Size(1024, 600);
          this.MinimumSize = new System.Drawing.Size(1024, 600);
          this.Name = "kemen";
          this.RightToLeft = System.Windows.Forms.RightToLeft.No;
          this.Text = "KEMEN - Pesaje Industrial";
          this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.kemen_FormClosed);
          this.govBascula.ResumeLayout(false);
          this.govBascula.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.PibCom)).EndInit();
          this.govHistoricos.ResumeLayout(false);
          this.govHistoricos.PerformLayout();
          this.govContenedor.ResumeLayout(false);
          this.govContenedor.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.PibBola)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.PibContenedor)).EndInit();
          this.govEDs.ResumeLayout(false);
          this.govEDs.PerformLayout();
          this.govAlarm.ResumeLayout(false);
          this.govAlarm.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.picBATELA)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVer;
        private TB.Instruments.SlidingScale scPesaje;
        private System.Windows.Forms.ListView vwUltimos;
        private System.Windows.Forms.ColumnHeader clPesaje;
        private System.Windows.Forms.ColumnHeader clFecha;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblComunica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBATELA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox govBascula;
        private System.Windows.Forms.PictureBox PibCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox govHistoricos;
        private System.Windows.Forms.PictureBox PibContenedor;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblTw1;
        private System.Windows.Forms.Label lblKg2;
        private System.Windows.Forms.Label lblTw2;
        private System.Windows.Forms.Label lblTw3;
        private System.Windows.Forms.Label lblTw4;
        private System.Windows.Forms.Label lblSensor2;
        private System.Windows.Forms.GroupBox govContenedor;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblBatelaVersion;
        private System.Windows.Forms.Label lblSensor1;
        private System.Windows.Forms.Label lblKg1;
        private System.Windows.Forms.Label lblSensor4;
        private System.Windows.Forms.Label lblKg4;
        private System.Windows.Forms.Label lblSensor3;
        private System.Windows.Forms.Label lblKg3;
        private System.Windows.Forms.Label lblCMx;
        private System.Windows.Forms.Label lblCMy;
        private System.Windows.Forms.PictureBox PibBola;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label lblCMasas;
        private System.Windows.Forms.Label lblCMasas2;
        private System.Windows.Forms.Button btnED1;
        private System.Windows.Forms.Label lblED1;
        private System.Windows.Forms.Label lblED2;
        private System.Windows.Forms.Button btnED2;
        private System.Windows.Forms.Label lblED3;
        private System.Windows.Forms.Button btnED3;
        private System.Windows.Forms.Label lblED4;
        private System.Windows.Forms.Button btnED4;
        private System.Windows.Forms.GroupBox govEDs;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.GroupBox govAlarm;
        private System.Windows.Forms.Label lblAlarm4;
        private System.Windows.Forms.Button btnAlarm4;
        private System.Windows.Forms.Label lblAlarm3;
        private System.Windows.Forms.Button btnAlarm3;
        private System.Windows.Forms.Label lblAlarm2;
        private System.Windows.Forms.Button btnAlarm2;
        private System.Windows.Forms.Label lblAlarm1;
        private System.Windows.Forms.Button btnAlarm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUltimo;
        private System.Windows.Forms.Label lblTextoActual;
        private System.Windows.Forms.Label lblTextoUltimo;
        private System.Windows.Forms.Button btnGraficas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVerMini;
        private System.Windows.Forms.Button button3;
    }
}

