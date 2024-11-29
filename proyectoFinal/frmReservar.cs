using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectoFinal
{
    public partial class frmReservar : Form
    {
        public frmReservar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancelar();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Guardar_espacio()
        {
            try
            {
                if (rb_hora.Checked)
                {
                    txtTiempo.Enabled = true; 
                }
                else if (rb_dia.Checked)
                {
                    txtTiempo.Enabled = false; 
                    txtTiempo.Text = "24"; 
                }

                sqlConnection1.Open();
                
                string tiempo = rb_dia.Checked ? "24" : txtTiempo.Text;
                string tipoTiempo = rb_dia.Checked ? "Día completo" : "Por hora"; 
              
                SqlCommand comandoEspacio = new SqlCommand("SP_GUARDAR_ESPACIO_RESERVA", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                comandoEspacio.Parameters.AddWithValue("@placa", string.IsNullOrEmpty(txtPlaca.Text) ? (object)DBNull.Value : txtPlaca.Text);
                comandoEspacio.Parameters.AddWithValue("@tiempo", string.IsNullOrEmpty(tiempo) ? (object)DBNull.Value : tiempo);
                comandoEspacio.Parameters.AddWithValue("@tipo_tiempo", string.IsNullOrEmpty(tipoTiempo) ? (object)DBNull.Value : tipoTiempo);
                comandoEspacio.Parameters.AddWithValue("@espacio", string.IsNullOrEmpty(espacios_seleccionar.Text) ? (object)DBNull.Value : espacios_seleccionar.Text);
             
                string tipoSeleccionado = null;
                if (rbCarro.Checked)
                    tipoSeleccionado = rbCarro.Text;
                else if (rbMoto.Checked)
                    tipoSeleccionado = rbMoto.Text;
                else if (rbCamion.Checked)
                    tipoSeleccionado = rbCamion.Text;
                else if (rbDiscapacitado.Checked)
                    tipoSeleccionado = rbDiscapacitado.Text;

                comandoEspacio.Parameters.AddWithValue("@tipo", tipoSeleccionado ?? (object)DBNull.Value);
               
                string tipoReservaSeleccionado = null;
                if (rb_reservar.Checked)
                    tipoReservaSeleccionado = rb_reservar.Text;
                else if (rb_usar.Checked)
                    tipoReservaSeleccionado = rb_usar.Text;

                comandoEspacio.Parameters.AddWithValue("@tipo_reserva", tipoReservaSeleccionado ?? (object)DBNull.Value);
               
                SqlDataReader espacios = comandoEspacio.ExecuteReader();

                if (espacios.Read())
                {
                    txtPlaca.Text = espacios["placa"].ToString();
                    espacios_seleccionar.Text = espacios["espacio"].ToString();
                }

                espacios.Close();                
                espacios_seleccionar.Enabled = false; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Open)
                    sqlConnection1.Close();
            }
        }

        private void Guardar_reserva()
        {
            try
            {                
                if (rb_hora.Checked)
                {
                    txtTiempo.Enabled = true;
                }
                else if (rb_dia.Checked)
                {
                    txtTiempo.Enabled = false; 
                    txtTiempo.Text = "24"; 
                }

                sqlConnection1.Open();
               
                string tiempo = rb_dia.Checked ? "24" : txtTiempo.Text;
                string tipoTiempo = rb_dia.Checked ? "Día completo" : "Por hora";
                SqlCommand comandoEspacio = new SqlCommand("SP_GUARDAR_ESPACIO", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comandoEspacio.Parameters.AddWithValue("@espacio",
                string.IsNullOrEmpty(espacios_seleccionar.Text) ? (object)DBNull.Value : espacios_seleccionar.Text);
               
                string tipoReservaSeleccionado = null;
             
                byte[] imagenBytes = null;

                if (rb_reservar.Checked)
                {
                    tipoReservaSeleccionado = rb_reservar.Text;
                    imagenBytes = ObtenerBytesImagen(@"C:\Users\crist\Downloads\img\descarga.jpg"); 
                }
                else if (rb_usar.Checked)
                {
                    tipoReservaSeleccionado = rb_usar.Text;
                    imagenBytes = ObtenerBytesImagen(@"C:\Users\crist\Downloads\img\ocupado.png"); 
                }
                comandoEspacio.Parameters.AddWithValue("@placa", string.IsNullOrEmpty(txtPlaca.Text) ? (object)DBNull.Value : txtPlaca.Text);
                comandoEspacio.Parameters.AddWithValue("@tiempo", string.IsNullOrEmpty(tiempo) ? (object)DBNull.Value : tiempo);

                comandoEspacio.Parameters.AddWithValue("@tipo_reserva", tipoReservaSeleccionado ?? (object)DBNull.Value);
                comandoEspacio.Parameters.AddWithValue("@imagen", imagenBytes ?? (object)DBNull.Value);
                string tipoSeleccionado = null;
                if (rbCarro.Checked)
                    tipoSeleccionado = rbCarro.Text;
                else if (rbMoto.Checked)
                    tipoSeleccionado = rbMoto.Text;
                else if (rbCamion.Checked)
                    tipoSeleccionado = rbCamion.Text;
                else if (rbDiscapacitado.Checked)
                    tipoSeleccionado = rbDiscapacitado.Text;

                comandoEspacio.Parameters.AddWithValue("@tipo", tipoSeleccionado ?? (object)DBNull.Value);
               
                comandoEspacio.ExecuteNonQuery();
               
                string espacioSeleccionado = espacios_seleccionar.Text;
                
                if (espacios_seleccionar.Items.Contains(espacioSeleccionado))
                {
                    espacios_seleccionar.Items.Remove(espacioSeleccionado); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Open)
                    sqlConnection1.Close();
            }
        }

        private byte[] ObtenerBytesImagen(string rutaImagen)
        {
            if (System.IO.File.Exists(rutaImagen))
            {
                return System.IO.File.ReadAllBytes(rutaImagen);
            }
            else
            {
                MessageBox.Show("La imagen no existe en la ruta especificada: " + rutaImagen, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void cancelar()
        {

            txtPlaca.Clear();
            espacios_seleccionar.Select();
            //gb_vehiculo.Checked = false;
            //gb_reserva.Enabled = false;
            txtPlaca.Focus();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmReservar_Load(object sender, EventArgs e)
        {

        }

        private void rbCarro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                SqlCommand comandoEspacio = new SqlCommand("SP_CONSULTAR_ESPACIO_CARRO", sqlConnection1);
                comandoEspacio.CommandType = CommandType.StoredProcedure;

                SqlDataReader espacioReader = comandoEspacio.ExecuteReader();

                espacios_seleccionar.Items.Clear();

                while (espacioReader.Read())
                {
                    if (espacioReader["espacio"] != DBNull.Value)
                    {
                        espacios_seleccionar.Items.Add(espacioReader["espacio"].ToString());
                    }
                }

                espacioReader.Close();
             
                if (espacios_seleccionar.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron espacios disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show($"Error al cargar los espacios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {                
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
            ActualizarLimitePlaca();
        }

        private void rbDiscapacitado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                SqlCommand comandoEspacio = new SqlCommand("SP_CONSULTAR_ESPACIO_DISCAPACITADO", sqlConnection1);
                comandoEspacio.CommandType = CommandType.StoredProcedure;

                SqlDataReader espacioReader = comandoEspacio.ExecuteReader();

                espacios_seleccionar.Items.Clear();

                while (espacioReader.Read())
                {
                    if (espacioReader["espacio"] != DBNull.Value)
                    {
                        espacios_seleccionar.Items.Add(espacioReader["espacio"].ToString());
                    }
                }

                espacioReader.Close();

                if (espacios_seleccionar.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron espacios disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los espacios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
            ActualizarLimitePlaca();
        }

        private void rbCamion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                SqlCommand comandoEspacio = new SqlCommand("SP_CONSULTAR_ESPACIO_CAMION", sqlConnection1);
                comandoEspacio.CommandType = CommandType.StoredProcedure;

                SqlDataReader espacioReader = comandoEspacio.ExecuteReader();

                espacios_seleccionar.Items.Clear();

                while (espacioReader.Read())
                {

                    if (espacioReader["espacio"] != DBNull.Value)
                    {
                        espacios_seleccionar.Items.Add(espacioReader["espacio"].ToString());
                    }
                }

                espacioReader.Close();

                if (espacios_seleccionar.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron espacios disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar los espacios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
            ActualizarLimitePlaca();
        }

        private void rbMoto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                SqlCommand comandoEspacio = new SqlCommand("SP_CONSULTAR_ESPACIO_MOTO", sqlConnection1);
                comandoEspacio.CommandType = CommandType.StoredProcedure;

                SqlDataReader espacioReader = comandoEspacio.ExecuteReader();

                espacios_seleccionar.Items.Clear();

                while (espacioReader.Read())
                {
                    if (espacioReader["espacio"] != DBNull.Value)
                    {
                        espacios_seleccionar.Items.Add(espacioReader["espacio"].ToString());
                    }
                }

                espacioReader.Close();

                if (espacios_seleccionar.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron espacios disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los espacios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
            ActualizarLimitePlaca();

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Guardar_espacio();
            Guardar_reserva();
            MessageBox.Show("Datos guardados");
            this.Close();

        }

        private void frmReservar_Load_1(object sender, EventArgs e)
        {

        }
        private void ActualizarLimitePlaca()
        {
            if (rbCarro.Checked)
            {
                txtPlaca.MaxLength = 7; // Limite de 7 caracteres para carros
            }
            else if (rbMoto.Checked)
            {
                txtPlaca.MaxLength = 6; // Limite de 6 caracteres para motos
            }
            else if (rbCamion.Checked)
            {
                txtPlaca.MaxLength = 8; // Limite de 8 caracteres para camiones
            }
            else if (rbDiscapacitado.Checked)
            {
                txtPlaca.MaxLength = 9; // Limite de 9 caracteres para placas de discapacitados
            }
        }


    }
}



