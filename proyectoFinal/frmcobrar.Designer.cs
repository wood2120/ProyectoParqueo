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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtEspacio = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
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
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMonto.Location = new System.Drawing.Point(126, 243);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(227, 52);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto a Cobrar: $";
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDato
            // 
            this.lblDato.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato.Location = new System.Drawing.Point(173, 191);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(180, 30);
            this.lblDato.TabIndex = 2;
            this.lblDato.Text = "Tiempo:";
            this.lblDato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDato.Click += new System.EventHandler(this.lblDato_Click_1);
            // 
            // lblEspacioSeleccionado
            // 
            this.lblEspacioSeleccionado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacioSeleccionado.Location = new System.Drawing.Point(153, 150);
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
            this.btnCobrar.Location = new System.Drawing.Point(354, 319);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(141, 55);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "Realizar Cobro";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(703, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Placa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlaca
            // 
            this.txtPlaca.AccessibleDescription = "";
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(395, 79);
            this.txtPlaca.Multiline = true;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(235, 30);
            this.txtPlaca.TabIndex = 11;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(686, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 40);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtEspacio
            // 
            this.txtEspacio.AccessibleDescription = "";
            this.txtEspacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspacio.Location = new System.Drawing.Point(399, 152);
            this.txtEspacio.Multiline = true;
            this.txtEspacio.Name = "txtEspacio";
            this.txtEspacio.Size = new System.Drawing.Size(235, 30);
            this.txtEspacio.TabIndex = 13;
            // 
            // txtTiempo
            // 
            this.txtTiempo.AccessibleDescription = "";
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(399, 210);
            this.txtTiempo.Multiline = true;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(235, 30);
            this.txtTiempo.TabIndex = 14;
            // 
            // txtMonto
            // 
            this.txtMonto.AccessibleDescription = "";
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(399, 265);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(235, 30);
            this.txtMonto.TabIndex = 15;
            // 
            // frmcobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 407);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtEspacio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
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
            GuardarMonto();
            borrar_espacio();
            this.Close();
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
        private Label label1;
        private TextBox txtPlaca;
        private Button btnBuscar;
        private TextBox txtEspacio;
        private TextBox txtTiempo;
        private TextBox txtMonto;
    }
}
