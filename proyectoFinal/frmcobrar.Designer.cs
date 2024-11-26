using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class frmcobrar : Form
    {
      

        private System.ComponentModel.IContainer components = null;

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Label lblEspacioSeleccionado; // Label para el espacio seleccionado
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblDato = new System.Windows.Forms.Label();
            this.lblEspacioSeleccionado = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbEspacio = new System.Windows.Forms.Label();
            this.lbMonto = new System.Windows.Forms.Label();
            this.cbEspacio = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=cristofer\\SQLEXPRESS;Initial Catalog=proyecto_parqueo;Integrated Secu" +
    "rity=True;Encrypt=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblTitulo.Location = new System.Drawing.Point(300, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Proceso de Cobro";
            // 
            // lblMonto
            // 
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblMonto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMonto.Location = new System.Drawing.Point(167, 145);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(197, 30);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto a Cobrar: $";
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDato
            // 
            this.lblDato.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDato.Location = new System.Drawing.Point(199, 91);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(208, 30);
            this.lblDato.TabIndex = 2;
            this.lblDato.Text = "Tiempo";
            this.lblDato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspacioSeleccionado
            // 
            this.lblEspacioSeleccionado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEspacioSeleccionado.Location = new System.Drawing.Point(171, 52);
            this.lblEspacioSeleccionado.Name = "lblEspacioSeleccionado";
            this.lblEspacioSeleccionado.Size = new System.Drawing.Size(224, 30);
            this.lblEspacioSeleccionado.TabIndex = 3;
            this.lblEspacioSeleccionado.Text = "Espacio seleccionado: ";
            this.lblEspacioSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.Teal;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(250, 230);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(120, 40);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(430, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lbEspacio
            // 
            this.lbEspacio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbEspacio.Location = new System.Drawing.Point(371, 52);
            this.lbEspacio.Name = "lbEspacio";
            this.lbEspacio.Size = new System.Drawing.Size(208, 30);
            this.lbEspacio.TabIndex = 7;
            this.lbEspacio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMonto
            // 
            this.lbMonto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbMonto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbMonto.Location = new System.Drawing.Point(382, 145);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(197, 30);
            this.lbMonto.TabIndex = 8;
            this.lbMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMonto.Visible = false;
            // 
            // cbEspacio
            // 
            this.cbEspacio.FormattingEnabled = true;
            this.cbEspacio.Location = new System.Drawing.Point(401, 52);
            this.cbEspacio.Name = "cbEspacio";
            this.cbEspacio.Size = new System.Drawing.Size(121, 21);
            this.cbEspacio.TabIndex = 9;
            this.cbEspacio.SelectedIndexChanged += new System.EventHandler(this.cbEspacio_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(422, 101);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 12;
            // 
            // frmcobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbEspacio);
            this.Controls.Add(this.lbMonto);
            this.Controls.Add(this.lbEspacio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblEspacioSeleccionado);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmcobrar";
            this.Text = "Cobrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            // Aquí realizamos una acción al cobrar, por ejemplo, actualizar el monto
            MessageBox.Show("El cobro ha sido realizado exitosamente.", "Cobrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual
        }

        // Método para actualizar el espacio seleccionado
        public void ActualizarEspacioSeleccionado(string espacio)
        {
            lblEspacioSeleccionado.Text = $"Espacio seleccionado: {espacio}";
        }
        public Label lbMonto;
        public Label lbEspacio;
        private ComboBox cbEspacio;
        private Button button1;
        private Button button2;
        private TextBox txttiempo;
    }
}
