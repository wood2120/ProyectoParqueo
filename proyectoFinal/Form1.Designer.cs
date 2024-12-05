namespace proyectoFinal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Reservar = new System.Windows.Forms.ToolStripButton();
            this.Facturas = new System.Windows.Forms.ToolStripButton();
            this.Pagar = new System.Windows.Forms.ToolStripButton();
            this.Tarifas = new System.Windows.Forms.ToolStripButton();
            this.picR1 = new System.Windows.Forms.PictureBox();
            this.picM8 = new System.Windows.Forms.PictureBox();
            this.picM1 = new System.Windows.Forms.PictureBox();
            this.picM2 = new System.Windows.Forms.PictureBox();
            this.picM7 = new System.Windows.Forms.PictureBox();
            this.picM5 = new System.Windows.Forms.PictureBox();
            this.picM6 = new System.Windows.Forms.PictureBox();
            this.picM3 = new System.Windows.Forms.PictureBox();
            this.picM4 = new System.Windows.Forms.PictureBox();
            this.picD1 = new System.Windows.Forms.PictureBox();
            this.picD2 = new System.Windows.Forms.PictureBox();
            this.picC1 = new System.Windows.Forms.PictureBox();
            this.picR4 = new System.Windows.Forms.PictureBox();
            this.picR5 = new System.Windows.Forms.PictureBox();
            this.picR2 = new System.Windows.Forms.PictureBox();
            this.picR3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=cristofer\\SQLEXPRESS;Initial Catalog=proyecto_parqueo;Integrated Secu" +
    "rity=True;Encrypt=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reservar,
            this.Facturas,
            this.Pagar,
            this.Tarifas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1239, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Reservar
            // 
            this.Reservar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Reservar.Image = global::proyectoFinal.Properties.Resources.Imagen_de_WhatsApp_2024_12_05_a_las_12_38_54_c899b77d;
            this.Reservar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reservar.Name = "Reservar";
            this.Reservar.Size = new System.Drawing.Size(23, 22);
            this.Reservar.Text = "Reservar";
            this.Reservar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Facturas
            // 
            this.Facturas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Facturas.Image = global::proyectoFinal.Properties.Resources.Imagen_de_WhatsApp_2024_12_05_a_las_12_38_54_a6e34ead;
            this.Facturas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Facturas.Name = "Facturas";
            this.Facturas.Size = new System.Drawing.Size(23, 22);
            this.Facturas.Text = "Facturas";
            this.Facturas.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Pagar
            // 
            this.Pagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pagar.Image = global::proyectoFinal.Properties.Resources.Imagen_de_WhatsApp_2024_12_05_a_las_12_38_53_2cd5df9f;
            this.Pagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pagar.Name = "Pagar";
            this.Pagar.Size = new System.Drawing.Size(23, 22);
            this.Pagar.Text = "Pagar";
            this.Pagar.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Tarifas
            // 
            this.Tarifas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tarifas.Image = global::proyectoFinal.Properties.Resources.descarga;
            this.Tarifas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tarifas.Name = "Tarifas";
            this.Tarifas.Size = new System.Drawing.Size(23, 22);
            this.Tarifas.Text = "Tarifas";
            this.Tarifas.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // picR1
            // 
            this.picR1.Location = new System.Drawing.Point(360, 555);
            this.picR1.Name = "picR1";
            this.picR1.Size = new System.Drawing.Size(57, 52);
            this.picR1.TabIndex = 23;
            this.picR1.TabStop = false;
            this.picR1.Click += new System.EventHandler(this.picR1_Click_1);
            // 
            // picM8
            // 
            this.picM8.Location = new System.Drawing.Point(924, 87);
            this.picM8.Name = "picM8";
            this.picM8.Size = new System.Drawing.Size(28, 27);
            this.picM8.TabIndex = 16;
            this.picM8.TabStop = false;
            this.picM8.Click += new System.EventHandler(this.picM8_Click);
            // 
            // picM1
            // 
            this.picM1.Location = new System.Drawing.Point(924, 273);
            this.picM1.Name = "picM1";
            this.picM1.Size = new System.Drawing.Size(28, 27);
            this.picM1.TabIndex = 15;
            this.picM1.TabStop = false;
            this.picM1.Click += new System.EventHandler(this.picM1_Click);
            // 
            // picM2
            // 
            this.picM2.Location = new System.Drawing.Point(864, 273);
            this.picM2.Name = "picM2";
            this.picM2.Size = new System.Drawing.Size(28, 27);
            this.picM2.TabIndex = 14;
            this.picM2.TabStop = false;
            this.picM2.Click += new System.EventHandler(this.picM2_Click);
            // 
            // picM7
            // 
            this.picM7.Location = new System.Drawing.Point(864, 87);
            this.picM7.Name = "picM7";
            this.picM7.Size = new System.Drawing.Size(28, 27);
            this.picM7.TabIndex = 13;
            this.picM7.TabStop = false;
            this.picM7.Click += new System.EventHandler(this.picM7_Click);
            // 
            // picM5
            // 
            this.picM5.Location = new System.Drawing.Point(748, 87);
            this.picM5.Name = "picM5";
            this.picM5.Size = new System.Drawing.Size(28, 27);
            this.picM5.TabIndex = 12;
            this.picM5.TabStop = false;
            this.picM5.Click += new System.EventHandler(this.picM5_Click);
            // 
            // picM6
            // 
            this.picM6.Location = new System.Drawing.Point(809, 87);
            this.picM6.Name = "picM6";
            this.picM6.Size = new System.Drawing.Size(28, 27);
            this.picM6.TabIndex = 11;
            this.picM6.TabStop = false;
            this.picM6.Click += new System.EventHandler(this.picM6_Click);
            // 
            // picM3
            // 
            this.picM3.Location = new System.Drawing.Point(809, 273);
            this.picM3.Name = "picM3";
            this.picM3.Size = new System.Drawing.Size(28, 27);
            this.picM3.TabIndex = 10;
            this.picM3.TabStop = false;
            this.picM3.Click += new System.EventHandler(this.picM3_Click);
            // 
            // picM4
            // 
            this.picM4.Location = new System.Drawing.Point(748, 273);
            this.picM4.Name = "picM4";
            this.picM4.Size = new System.Drawing.Size(28, 27);
            this.picM4.TabIndex = 9;
            this.picM4.TabStop = false;
            this.picM4.Click += new System.EventHandler(this.picM4_Click);
            // 
            // picD1
            // 
            this.picD1.ErrorImage = global::proyectoFinal.Properties.Resources.libre;
            this.picD1.Image = ((System.Drawing.Image)(resources.GetObject("picD1.Image")));
            this.picD1.Location = new System.Drawing.Point(1042, 546);
            this.picD1.Name = "picD1";
            this.picD1.Size = new System.Drawing.Size(57, 52);
            this.picD1.TabIndex = 8;
            this.picD1.TabStop = false;
            this.picD1.Click += new System.EventHandler(this.picD1_Click);
            // 
            // picD2
            // 
            this.picD2.Location = new System.Drawing.Point(822, 546);
            this.picD2.Name = "picD2";
            this.picD2.Size = new System.Drawing.Size(57, 52);
            this.picD2.TabIndex = 7;
            this.picD2.TabStop = false;
            this.picD2.Click += new System.EventHandler(this.picD2_Click);
            // 
            // picC1
            // 
            this.picC1.Location = new System.Drawing.Point(588, 555);
            this.picC1.Name = "picC1";
            this.picC1.Size = new System.Drawing.Size(57, 52);
            this.picC1.TabIndex = 6;
            this.picC1.TabStop = false;
            this.picC1.Click += new System.EventHandler(this.picC1_Click);
            // 
            // picR4
            // 
            this.picR4.Location = new System.Drawing.Point(360, 99);
            this.picR4.Name = "picR4";
            this.picR4.Size = new System.Drawing.Size(57, 52);
            this.picR4.TabIndex = 4;
            this.picR4.TabStop = false;
            this.picR4.Click += new System.EventHandler(this.picR4_Click);
            // 
            // picR5
            // 
            this.picR5.Location = new System.Drawing.Point(588, 99);
            this.picR5.Name = "picR5";
            this.picR5.Size = new System.Drawing.Size(57, 52);
            this.picR5.TabIndex = 3;
            this.picR5.TabStop = false;
            this.picR5.Click += new System.EventHandler(this.picR5_Click);
            // 
            // picR2
            // 
            this.picR2.Location = new System.Drawing.Point(145, 555);
            this.picR2.Name = "picR2";
            this.picR2.Size = new System.Drawing.Size(57, 52);
            this.picR2.TabIndex = 2;
            this.picR2.TabStop = false;
            this.picR2.Click += new System.EventHandler(this.picR2_Click);
            // 
            // picR3
            // 
            this.picR3.Location = new System.Drawing.Point(145, 99);
            this.picR3.Name = "picR3";
            this.picR3.Size = new System.Drawing.Size(57, 52);
            this.picR3.TabIndex = 1;
            this.picR3.TabStop = false;
            this.picR3.Click += new System.EventHandler(this.picR3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1239, 793);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1239, 794);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.picR1);
            this.Controls.Add(this.picM8);
            this.Controls.Add(this.picM1);
            this.Controls.Add(this.picM2);
            this.Controls.Add(this.picM7);
            this.Controls.Add(this.picM5);
            this.Controls.Add(this.picM6);
            this.Controls.Add(this.picM3);
            this.Controls.Add(this.picM4);
            this.Controls.Add(this.picD1);
            this.Controls.Add(this.picD2);
            this.Controls.Add(this.picC1);
            this.Controls.Add(this.picR4);
            this.Controls.Add(this.picR5);
            this.Controls.Add(this.picR2);
            this.Controls.Add(this.picR3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Parqueo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picR3;
        private System.Windows.Forms.PictureBox picR2;
        private System.Windows.Forms.PictureBox picR5;
        private System.Windows.Forms.PictureBox picR4;
        private System.Windows.Forms.PictureBox picC1;
        private System.Windows.Forms.PictureBox picD2;
        private System.Windows.Forms.PictureBox picD1;
        private System.Windows.Forms.PictureBox picM4;
        private System.Windows.Forms.PictureBox picM3;
        private System.Windows.Forms.PictureBox picM6;
        private System.Windows.Forms.PictureBox picM5;
        private System.Windows.Forms.PictureBox picM7;
        private System.Windows.Forms.PictureBox picM2;
        private System.Windows.Forms.PictureBox picM1;
        private System.Windows.Forms.PictureBox picM8;
        public System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.PictureBox picR1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Reservar;
        private System.Windows.Forms.ToolStripButton Facturas;
        private System.Windows.Forms.ToolStripButton Pagar;
        private System.Windows.Forms.ToolStripButton Tarifas;
    }
}

