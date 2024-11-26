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
    public partial class frmcobrar : Form
    {
        public frmcobrar()
        {
            InitializeComponent();
        }

        private void frmcobrar_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago confirmado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void lblDato_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual
        }

        private void frmcobrar_Load_1(object sender, EventArgs e)
        {

        }

        private void lblEspacioSeleccionado_Click(object sender, EventArgs e)
        {

        }

        private void lblMonto_Click(object sender, EventArgs e)
        {



        }

        private void lbMonto_Click(object sender, EventArgs e)
        {

        }

        private void cbEspacio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Consultar_Elemento()
        {
            try
            {
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                SqlCommand ComandoElemento = new SqlCommand("SP_CONSULTAR_ESPACIO_MONTO", sqlConnection1);
                ComandoElemento.CommandType = CommandType.StoredProcedure;

                // Eliminar la línea que añade el parámetro si no lo necesitas.
                //ComandoElemento.Parameters.AddWithValue("@espacio", cbEspacio.items);

                SqlDataReader Elemento = ComandoElemento.ExecuteReader();

                cbEspacio.Items.Clear();

                while (Elemento.Read())
                {
                    if (Elemento["espacio"] != DBNull.Value)
                    {
                        cbEspacio.Items.Add(Elemento["espacio"].ToString());
                    }
                }

                Elemento.Close();
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
        private void Consultar_Tiempo()
        {
            try
            {
                // Abrir la conexión si no está abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Crear el comando para llamar al procedimiento almacenado
                SqlCommand ComandoElemento = new SqlCommand("SP_CONSULTAR_MONTO_ESPACIO3", sqlConnection1);
                ComandoElemento.CommandType = CommandType.StoredProcedure;

                // Usar el valor seleccionado en cbEspacio
                ComandoElemento.Parameters.AddWithValue("@espacio", cbEspacio.Text);

                // Ejecutar la consulta
                SqlDataReader espacio = ComandoElemento.ExecuteReader();

                // Limpiar el campo txttiempo antes de mostrar un nuevo valor
                txttiempo.Text = string.Empty;

                // Verificar si hay datos en el DataReader
                if (espacio.Read())
                {
                    // Asignar el valor del campo 'tiempo' a txttiempo
                    if (espacio["tiempo"] != DBNull.Value)
                    {
                        txttiempo.Text = espacio["tiempo"].ToString();
                    }
                }
                else
                {
                    // Si no se encuentra un resultado, mostrar un mensaje
                    txttiempo.Text = "No se encontró información.";
                }

                // Cerrar el SqlDataReader
                espacio.Close();
            }
            catch (Exception ex)
            {
                // Capturar cualquier error y mostrar un mensaje
                MessageBox.Show($"Error al consultar el tiempo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurar que la conexión se cierre
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Consultar_Elemento();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Consultar_Tiempo();
        }

        private void frmcobrar_Load_2(object sender, EventArgs e)
        {

        }
    }
}
