namespace proyectoFinal
{
    partial class frmReservar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservar));
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPago = new System.Windows.Forms.Button();
            this.cancelar_espacio = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.label2 = new System.Windows.Forms.Label();
            this.espacios_seleccionar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(112, 59);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(145, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placa vehiculo";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(609, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Hora";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(681, 80);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(42, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Dia";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de tarifa";
            // 
            // btnPago
            // 
            this.btnPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPago.BackgroundImage")));
            this.btnPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Location = new System.Drawing.Point(269, 379);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(91, 82);
            this.btnPago.TabIndex = 18;
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // cancelar_espacio
            // 
            this.cancelar_espacio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelar_espacio.BackgroundImage")));
            this.cancelar_espacio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelar_espacio.FlatAppearance.BorderSize = 0;
            this.cancelar_espacio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar_espacio.Location = new System.Drawing.Point(567, 393);
            this.cancelar_espacio.Name = "cancelar_espacio";
            this.cancelar_espacio.Size = new System.Drawing.Size(77, 68);
            this.cancelar_espacio.TabIndex = 19;
            this.cancelar_espacio.UseVisualStyleBackColor = true;
            this.cancelar_espacio.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=cristofer\\SQLEXPRESS;Initial Catalog=proyecto_parqueo;Integrated Secu" +
    "rity=True;Encrypt=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "espacio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // espacios_seleccionar
            // 
            this.espacios_seleccionar.FormattingEnabled = true;
            this.espacios_seleccionar.Location = new System.Drawing.Point(125, 150);
            this.espacios_seleccionar.Name = "espacios_seleccionar";
            this.espacios_seleccionar.Size = new System.Drawing.Size(121, 21);
            this.espacios_seleccionar.TabIndex = 21;
            this.espacios_seleccionar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmReservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.espacios_seleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelar_espacio);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaca);
            this.Name = "frmReservar";
            this.Text = "Reservar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button cancelar_espacio;
        public System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox espacios_seleccionar;
        private System.Windows.Forms.Button button1;
    }
}