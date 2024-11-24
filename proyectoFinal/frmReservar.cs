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
               
                sqlConnection1.Open();

                SqlCommand comandoEspacio = new SqlCommand("SP_GUARDAR_ESPACIO_PARQUEO", sqlConnection1);
                comandoEspacio.CommandType = CommandType.StoredProcedure;

                comandoEspacio.Parameters.AddWithValue("@placa", string.IsNullOrEmpty(txtPlaca.Text) ? (object)DBNull.Value : txtPlaca.Text);
                comandoEspacio.Parameters.AddWithValue("@tiempo", string.IsNullOrEmpty(txtTiempo.Text) ? (object)DBNull.Value : txtTiempo.Text);
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

                // Cierra el DataReader
                espacioReader.Close();

                // Verifica si no se encontraron espacios
                if (espacios_seleccionar.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron espacios disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de fallo
                MessageBox.Show($"Error al cargar los espacios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegúrate de cerrar la conexión si está abierta
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
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
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Guardar_espacio();
            MessageBox.Show("Datos guardados");
            this.Close();
        }

        private void frmReservar_Load_1(object sender, EventArgs e)
        {

        }
    }
    }
    
    

