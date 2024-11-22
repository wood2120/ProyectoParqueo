using System;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class frmReservar : Form
    {
       
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.rb_carro = new System.Windows.Forms.RadioButton();
            this.rb_moto = new System.Windows.Forms.RadioButton();
            this.rb_camion = new System.Windows.Forms.RadioButton();
            this.rb_discapacitado = new System.Windows.Forms.RadioButton();
            this.lblEspacio = new System.Windows.Forms.Label();
            this.espacios_seleccionar = new System.Windows.Forms.ComboBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblTitulo.Location = new System.Drawing.Point(150, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(334, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reserva de Estacionamiento";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPlaca.Location = new System.Drawing.Point(50, 80);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(137, 21);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa del Vehículo:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(180, 80);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(200, 20);
            this.txtPlaca.TabIndex = 2;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTipoVehiculo.Location = new System.Drawing.Point(50, 130);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(127, 21);
            this.lblTipoVehiculo.TabIndex = 3;
            this.lblTipoVehiculo.Text = "Tipo de Vehículo:";
            // 
            // rb_carro
            // 
            this.rb_carro.AutoSize = true;
            this.rb_carro.Location = new System.Drawing.Point(180, 130);
            this.rb_carro.Name = "rb_carro";
            this.rb_carro.Size = new System.Drawing.Size(50, 17);
            this.rb_carro.TabIndex = 4;
            this.rb_carro.TabStop = true;
            this.rb_carro.Text = "Carro";
            this.rb_carro.CheckedChanged += new System.EventHandler(this.rb_carro_CheckedChanged_1);
            // 
            // rb_moto
            // 
            this.rb_moto.AutoSize = true;
            this.rb_moto.Location = new System.Drawing.Point(240, 130);
            this.rb_moto.Name = "rb_moto";
            this.rb_moto.Size = new System.Drawing.Size(49, 17);
            this.rb_moto.TabIndex = 5;
            this.rb_moto.TabStop = true;
            this.rb_moto.Text = "Moto";
            this.rb_moto.CheckedChanged += new System.EventHandler(this.rb_moto_CheckedChanged);
            // 
            // rb_camion
            // 
            this.rb_camion.AutoSize = true;
            this.rb_camion.Location = new System.Drawing.Point(300, 130);
            this.rb_camion.Name = "rb_camion";
            this.rb_camion.Size = new System.Drawing.Size(60, 17);
            this.rb_camion.TabIndex = 6;
            this.rb_camion.TabStop = true;
            this.rb_camion.Text = "Camión";
            this.rb_camion.CheckedChanged += new System.EventHandler(this.rb_camion_CheckedChanged);
            // 
            // rb_discapacitado
            // 
            this.rb_discapacitado.AutoSize = true;
            this.rb_discapacitado.Location = new System.Drawing.Point(370, 130);
            this.rb_discapacitado.Name = "rb_discapacitado";
            this.rb_discapacitado.Size = new System.Drawing.Size(93, 17);
            this.rb_discapacitado.TabIndex = 7;
            this.rb_discapacitado.TabStop = true;
            this.rb_discapacitado.Text = "Discapacitado";
            this.rb_discapacitado.CheckedChanged += new System.EventHandler(this.rb_discapacitado_CheckedChanged);
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEspacio.Location = new System.Drawing.Point(50, 180);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(65, 21);
            this.lblEspacio.TabIndex = 8;
            this.lblEspacio.Text = "Espacio:";
            // 
            // espacios_seleccionar
            // 
            this.espacios_seleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.espacios_seleccionar.FormattingEnabled = true;
            this.espacios_seleccionar.Location = new System.Drawing.Point(180, 180);
            this.espacios_seleccionar.Name = "espacios_seleccionar";
            this.espacios_seleccionar.Size = new System.Drawing.Size(200, 21);
            this.espacios_seleccionar.TabIndex = 9;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.Teal;
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(120, 250);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(120, 40);
            this.btnReservar.TabIndex = 10;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(300, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=cristofer\\SQLEXPRESS;Initial Catalog=proyecto_parqueo;Integrated Secu" +
    "rity=True;Encrypt=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // frmReservar
            // 
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.espacios_seleccionar);
            this.Controls.Add(this.lblEspacio);
            this.Controls.Add(this.rb_discapacitado);
            this.Controls.Add(this.rb_camion);
            this.Controls.Add(this.rb_moto);
            this.Controls.Add(this.rb_carro);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmReservar";
            this.Text = "Reserva de Estacionamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.RadioButton rb_carro;
        private System.Windows.Forms.RadioButton rb_moto;
        private System.Windows.Forms.RadioButton rb_camion;
        private System.Windows.Forms.RadioButton rb_discapacitado;
        private System.Windows.Forms.Label lblEspacio;
        private System.Windows.Forms.ComboBox espacios_seleccionar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}
