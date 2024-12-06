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
            this.rbCarro = new System.Windows.Forms.RadioButton();
            this.rbMoto = new System.Windows.Forms.RadioButton();
            this.rbCamion = new System.Windows.Forms.RadioButton();
            this.rbDiscapacitado = new System.Windows.Forms.RadioButton();
            this.lblEspacio = new System.Windows.Forms.Label();
            this.espacios_seleccionar = new System.Windows.Forms.ComboBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_reserva = new System.Windows.Forms.GroupBox();
            this.rb_usar = new System.Windows.Forms.RadioButton();
            this.rb_reservar = new System.Windows.Forms.RadioButton();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.gb_vehiculo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_horario = new System.Windows.Forms.GroupBox();
            this.rb_hora = new System.Windows.Forms.RadioButton();
            this.rb_dia = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_reserva.SuspendLayout();
            this.gb_vehiculo.SuspendLayout();
            this.gb_horario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitulo.Location = new System.Drawing.Point(228, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(334, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reserva de Estacionamiento";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(50, 80);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(176, 25);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa del Vehículo:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(297, 80);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(226, 29);
            this.txtPlaca.TabIndex = 2;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(50, 136);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(165, 25);
            this.lblTipoVehiculo.TabIndex = 3;
            this.lblTipoVehiculo.Text = "Tipo de Vehículo:";
            // 
            // rbCarro
            // 
            this.rbCarro.AutoSize = true;
            this.rbCarro.Location = new System.Drawing.Point(0, 25);
            this.rbCarro.Name = "rbCarro";
            this.rbCarro.Size = new System.Drawing.Size(66, 24);
            this.rbCarro.TabIndex = 4;
            this.rbCarro.TabStop = true;
            this.rbCarro.Text = "Carro";
            this.rbCarro.CheckedChanged += new System.EventHandler(this.rbCarro_CheckedChanged);
            // 
            // rbMoto
            // 
            this.rbMoto.AutoSize = true;
            this.rbMoto.Location = new System.Drawing.Point(69, 26);
            this.rbMoto.Name = "rbMoto";
            this.rbMoto.Size = new System.Drawing.Size(63, 24);
            this.rbMoto.TabIndex = 5;
            this.rbMoto.TabStop = true;
            this.rbMoto.Text = "Moto";
            this.rbMoto.CheckedChanged += new System.EventHandler(this.rbMoto_CheckedChanged);
            // 
            // rbCamion
            // 
            this.rbCamion.AutoSize = true;
            this.rbCamion.Location = new System.Drawing.Point(148, 26);
            this.rbCamion.Name = "rbCamion";
            this.rbCamion.Size = new System.Drawing.Size(81, 24);
            this.rbCamion.TabIndex = 6;
            this.rbCamion.TabStop = true;
            this.rbCamion.Text = "Camion";
            this.rbCamion.CheckedChanged += new System.EventHandler(this.rbCamion_CheckedChanged);
            // 
            // rbDiscapacitado
            // 
            this.rbDiscapacitado.AutoSize = true;
            this.rbDiscapacitado.Location = new System.Drawing.Point(243, 26);
            this.rbDiscapacitado.Name = "rbDiscapacitado";
            this.rbDiscapacitado.Size = new System.Drawing.Size(128, 24);
            this.rbDiscapacitado.TabIndex = 7;
            this.rbDiscapacitado.TabStop = true;
            this.rbDiscapacitado.Text = "Discapacitado";
            this.rbDiscapacitado.CheckedChanged += new System.EventHandler(this.rbDiscapacitado_CheckedChanged);
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacio.Location = new System.Drawing.Point(50, 369);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(83, 25);
            this.lblEspacio.TabIndex = 8;
            this.lblEspacio.Text = "Espacio:";
            // 
            // espacios_seleccionar
            // 
            this.espacios_seleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.espacios_seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espacios_seleccionar.FormattingEnabled = true;
            this.espacios_seleccionar.Location = new System.Drawing.Point(297, 369);
            this.espacios_seleccionar.Name = "espacios_seleccionar";
            this.espacios_seleccionar.Size = new System.Drawing.Size(200, 28);
            this.espacios_seleccionar.TabIndex = 9;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(215, 449);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(120, 40);
            this.btnReservar.TabIndex = 10;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(414, 449);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=cristofer\\SQLEXPRESS;Initial Catalog=proyecto_parqueo;Integrated Secu" +
    "rity=True;Encrypt=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo de Reserva :";
            // 
            // gb_reserva
            // 
            this.gb_reserva.Controls.Add(this.rb_usar);
            this.gb_reserva.Controls.Add(this.rb_reservar);
            this.gb_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_reserva.Location = new System.Drawing.Point(297, 297);
            this.gb_reserva.Name = "gb_reserva";
            this.gb_reserva.Size = new System.Drawing.Size(228, 39);
            this.gb_reserva.TabIndex = 13;
            this.gb_reserva.TabStop = false;
            // 
            // rb_usar
            // 
            this.rb_usar.AutoSize = true;
            this.rb_usar.Location = new System.Drawing.Point(117, 16);
            this.rb_usar.Name = "rb_usar";
            this.rb_usar.Size = new System.Drawing.Size(77, 24);
            this.rb_usar.TabIndex = 1;
            this.rb_usar.TabStop = true;
            this.rb_usar.Text = "Normal";
            this.rb_usar.UseVisualStyleBackColor = true;
            // 
            // rb_reservar
            // 
            this.rb_reservar.AutoSize = true;
            this.rb_reservar.Location = new System.Drawing.Point(7, 16);
            this.rb_reservar.Name = "rb_reservar";
            this.rb_reservar.Size = new System.Drawing.Size(104, 24);
            this.rb_reservar.TabIndex = 0;
            this.rb_reservar.TabStop = true;
            this.rb_reservar.Text = "Reservado";
            this.rb_reservar.UseVisualStyleBackColor = true;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(297, 255);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(153, 29);
            this.txtTiempo.TabIndex = 14;
            // 
            // gb_vehiculo
            // 
            this.gb_vehiculo.Controls.Add(this.rbCarro);
            this.gb_vehiculo.Controls.Add(this.rbMoto);
            this.gb_vehiculo.Controls.Add(this.rbCamion);
            this.gb_vehiculo.Controls.Add(this.rbDiscapacitado);
            this.gb_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_vehiculo.Location = new System.Drawing.Point(297, 115);
            this.gb_vehiculo.Name = "gb_vehiculo";
            this.gb_vehiculo.Size = new System.Drawing.Size(391, 56);
            this.gb_vehiculo.TabIndex = 15;
            this.gb_vehiculo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Horario";
            // 
            // gb_horario
            // 
            this.gb_horario.Controls.Add(this.rb_hora);
            this.gb_horario.Controls.Add(this.rb_dia);
            this.gb_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_horario.Location = new System.Drawing.Point(297, 177);
            this.gb_horario.Name = "gb_horario";
            this.gb_horario.Size = new System.Drawing.Size(226, 56);
            this.gb_horario.TabIndex = 17;
            this.gb_horario.TabStop = false;
            // 
            // rb_hora
            // 
            this.rb_hora.AutoSize = true;
            this.rb_hora.Location = new System.Drawing.Point(19, 25);
            this.rb_hora.Name = "rb_hora";
            this.rb_hora.Size = new System.Drawing.Size(62, 24);
            this.rb_hora.TabIndex = 6;
            this.rb_hora.TabStop = true;
            this.rb_hora.Text = "Hora";
            // 
            // rb_dia
            // 
            this.rb_dia.AutoSize = true;
            this.rb_dia.Location = new System.Drawing.Point(94, 25);
            this.rb_dia.Name = "rb_dia";
            this.rb_dia.Size = new System.Drawing.Size(104, 24);
            this.rb_dia.TabIndex = 7;
            this.rb_dia.TabStop = true;
            this.rb_dia.Text = "Todo el día";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tiempo:";
            // 
            // frmReservar
            // 
            this.ClientSize = new System.Drawing.Size(755, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_horario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_vehiculo);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.gb_reserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.espacios_seleccionar);
            this.Controls.Add(this.lblEspacio);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmReservar";
            this.Text = "Reserva de Estacionamiento";
            this.Load += new System.EventHandler(this.frmReservar_Load_1);
            this.gb_reserva.ResumeLayout(false);
            this.gb_reserva.PerformLayout();
            this.gb_vehiculo.ResumeLayout(false);
            this.gb_vehiculo.PerformLayout();
            this.gb_horario.ResumeLayout(false);
            this.gb_horario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.RadioButton rbCarro;
        private System.Windows.Forms.RadioButton rbMoto;
        private System.Windows.Forms.RadioButton rbCamion;
        private System.Windows.Forms.RadioButton rbDiscapacitado;
        private System.Windows.Forms.Label lblEspacio;
        private System.Windows.Forms.ComboBox espacios_seleccionar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private Label label1;
        private GroupBox gb_reserva;
        private RadioButton rb_usar;
        private RadioButton rb_reservar;
        private TextBox txtTiempo;
        private GroupBox gb_vehiculo;
        private Label label2;
        private GroupBox gb_horario;
        private RadioButton rb_hora;
        private RadioButton rb_dia;
        private ColorDialog colorDialog1;
        private Label label3;
    }
}
