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
            this.lblAccion = new System.Windows.Forms.Label();
            this.rb_reservar = new System.Windows.Forms.RadioButton();
            this.rb_usar = new System.Windows.Forms.RadioButton();
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
            this.lblTitulo.Location = new System.Drawing.Point(120, 20);
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
            this.txtPlaca.Location = new System.Drawing.Point(200, 80);
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
            this.rb_carro.Location = new System.Drawing.Point(200, 130);
            this.rb_carro.Name = "rb_carro";
            this.rb_carro.Size = new System.Drawing.Size(50, 17);
            this.rb_carro.TabIndex = 4;
            this.rb_carro.TabStop = true;
            this.rb_carro.Text = "Carro";
            // 
            // rb_moto
            // 
            this.rb_moto.AutoSize = true;
            this.rb_moto.Location = new System.Drawing.Point(270, 130);
            this.rb_moto.Name = "rb_moto";
            this.rb_moto.Size = new System.Drawing.Size(49, 17);
            this.rb_moto.TabIndex = 5;
            this.rb_moto.TabStop = true;
            this.rb_moto.Text = "Moto";
            // 
            // rb_camion
            // 
            this.rb_camion.AutoSize = true;
            this.rb_camion.Location = new System.Drawing.Point(340, 130);
            this.rb_camion.Name = "rb_camion";
            this.rb_camion.Size = new System.Drawing.Size(60, 17);
            this.rb_camion.TabIndex = 6;
            this.rb_camion.TabStop = true;
            this.rb_camion.Text = "Camión";
            // 
            // rb_discapacitado
            // 
            this.rb_discapacitado.AutoSize = true;
            this.rb_discapacitado.Location = new System.Drawing.Point(420, 130);
            this.rb_discapacitado.Name = "rb_discapacitado";
            this.rb_discapacitado.Size = new System.Drawing.Size(93, 17);
            this.rb_discapacitado.TabIndex = 7;
            this.rb_discapacitado.TabStop = true;
            this.rb_discapacitado.Text = "Discapacitado";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAccion.Location = new System.Drawing.Point(50, 180);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(58, 21);
            this.lblAccion.TabIndex = 8;
            this.lblAccion.Text = "Acción:";
            // 
            // rb_reservar
            // 
            this.rb_reservar.AutoSize = true;
            this.rb_reservar.Location = new System.Drawing.Point(200, 180);
            this.rb_reservar.Name = "rb_reservar";
            this.rb_reservar.Size = new System.Drawing.Size(68, 17);
            this.rb_reservar.TabIndex = 9;
            this.rb_reservar.TabStop = true;
            this.rb_reservar.Text = "Reservar";
            // 
            // rb_usar
            // 
            this.rb_usar.AutoSize = true;
            this.rb_usar.Location = new System.Drawing.Point(290, 180);
            this.rb_usar.Name = "rb_usar";
            this.rb_usar.Size = new System.Drawing.Size(47, 17);
            this.rb_usar.TabIndex = 10;
            this.rb_usar.TabStop = true;
            this.rb_usar.Text = "Usar";
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEspacio.Location = new System.Drawing.Point(50, 230);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(65, 21);
            this.lblEspacio.TabIndex = 11;
            this.lblEspacio.Text = "Espacio:";
            // 
            // espacios_seleccionar
            // 
            this.espacios_seleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.espacios_seleccionar.FormattingEnabled = true;
            this.espacios_seleccionar.Location = new System.Drawing.Point(200, 230);
            this.espacios_seleccionar.Name = "espacios_seleccionar";
            this.espacios_seleccionar.Size = new System.Drawing.Size(200, 21);
            this.espacios_seleccionar.TabIndex = 12;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.Teal;
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(120, 300);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(120, 40);
            this.btnReservar.TabIndex = 13;
            this.btnReservar.Text = "Confirmar";
            this.btnReservar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(300, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=cristofer\\SQLEXPRESS;Initial Catalog=Estacionamiento;Integrated Secur" +
    "ity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // frmReservar
            // 
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.espacios_seleccionar);
            this.Controls.Add(this.lblEspacio);
            this.Controls.Add(this.rb_usar);
            this.Controls.Add(this.rb_reservar);
            this.Controls.Add(this.lblAccion);
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

        private Label lblTitulo;
        private Label lblPlaca;
        private TextBox txtPlaca;
        private Label lblTipoVehiculo;
        private RadioButton rb_carro;
        private RadioButton rb_moto;
        private RadioButton rb_camion;
        private RadioButton rb_discapacitado;
        private Label lblAccion;
        private RadioButton rb_reservar;
        private RadioButton rb_usar;
        private Label lblEspacio;
        private ComboBox espacios_seleccionar;
        private Button btnReservar;
        private Button btnCancelar;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}
