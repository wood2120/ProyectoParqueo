using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class frmcobrar : Form
    {
        public frmcobrar()
        {
            InitializeComponent();
        }

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
            this.lblMonto.Location = new System.Drawing.Point(250, 80);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(300, 30);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto a Cobrar: $0.00";
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDato
            // 
            this.lblDato.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDato.Location = new System.Drawing.Point(250, 130);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(300, 30);
            this.lblDato.TabIndex = 2;
            this.lblDato.Text = "Dato adicional: Sin datos";
            this.lblDato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDato.Click += new System.EventHandler(this.lblDato_Click);
            // 
            // lblEspacioSeleccionado
            // 
            this.lblEspacioSeleccionado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEspacioSeleccionado.Location = new System.Drawing.Point(250, 170);
            this.lblEspacioSeleccionado.Name = "lblEspacioSeleccionado";
            this.lblEspacioSeleccionado.Size = new System.Drawing.Size(300, 30);
            this.lblEspacioSeleccionado.TabIndex = 3;
            this.lblEspacioSeleccionado.Text = "Espacio seleccionado: Ninguno";
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // frmcobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
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
    }
}
