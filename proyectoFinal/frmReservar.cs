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
            MostrarEspacios();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            Guardar_espacio();
            

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
            sqlConnection1.Open();

            SqlCommand comandoEspacio = new SqlCommand("SP_GUARDAR_ESPACIO", sqlConnection1);
            comandoEspacio.CommandType = CommandType.StoredProcedure;
            comandoEspacio.Parameters.AddWithValue("@placa", txtPlaca.Text);
           comandoEspacio.Parameters.AddWithValue("@tiempo", txtPlaca.Text);
            comandoEspacio.Parameters.AddWithValue("@espacio", espacios_seleccionar.Text);

            SqlDataReader espacios = comandoEspacio.ExecuteReader();

            if (espacios.Read())
            {
               txtPlaca.Text = espacios["placa"].ToString();
                espacios_seleccionar.Text = espacios["espacio"].ToString();
            }

            sqlConnection1.Close();
            
        }
        private void cancelar()
        {
            
                txtPlaca.Clear();
              
                txtPlaca.Focus();
            
        }
        private void MostrarEspacios()
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Configura el comando para ejecutar el procedimiento almacenado
                SqlCommand comandoEspacio = new SqlCommand("SP_CONSULTAR_ESPACIOS", sqlConnection1);
                comandoEspacio.CommandType = CommandType.StoredProcedure;

                // Si el procedimiento necesita parámetros, descomenta y ajusta esta línea
                // comandoEspacio.Parameters.AddWithValue("@espacio", algunValor);

                // Ejecuta el procedimiento y obtiene un SqlDataReader
                SqlDataReader espacioReader = comandoEspacio.ExecuteReader();

                // Limpia el ComboBox antes de agregar nuevos elementos
                espacios_seleccionar.Items.Clear();

                // Verifica si hay datos y agrega los elementos al ComboBox
                while (espacioReader.Read())
                {
                    // Verifica si la columna "espacio" existe en el resultado
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
