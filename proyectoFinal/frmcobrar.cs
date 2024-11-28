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
            frmrealizar_cobro frmrealizar_cobro = new frmrealizar_cobro();
            frmrealizar_cobro.ShowDialog();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual
        }

        private void traer_datos_cobro() {

            sqlConnection1.Open();

            SqlCommand ComandoElemento = new SqlCommand("SP_CONSULTAR_ESPACIOS_MONTO", sqlConnection1);
            ComandoElemento.CommandType = CommandType.StoredProcedure;
            ComandoElemento.Parameters.AddWithValue("@consulta", txtPlaca.Text);

            SqlDataReader Elemento = ComandoElemento.ExecuteReader();

            if (Elemento.Read())
            {
                txtEspacio.Text = Elemento["espacio"].ToString();
                txtTiempo.Text = Elemento["tiempo"].ToString();
            }

            sqlConnection1.Close();
        }


        private void traer_datos_monto()
        {
            sqlConnection1.Open();

            SqlCommand ComandoElemento = new SqlCommand("SP_CONSULTAR_MONTO_COBRO", sqlConnection1);
            ComandoElemento.CommandType = CommandType.StoredProcedure;
            ComandoElemento.Parameters.AddWithValue("@consulta", txtTiempo.Text);

            SqlDataReader Elemento = ComandoElemento.ExecuteReader();

            if (Elemento.Read())
            {
                txtEspacio.Text = Elemento["espacio"].ToString();
                txtTiempo.Text = Elemento["tiempo"].ToString();
            }

            sqlConnection1.Close();
        }
        private void Guardar_monto()
        {
            try
            {
                // Verificar que el campo de texto no esté vacío
                string monto = txtMonto.Text.Trim();
               

                // Abrir la conexión si no está abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Crear y configurar el comando para el procedimiento almacenado
                using (SqlCommand comandoEspacio = new SqlCommand("SP_GUARDAR_MONTO", sqlConnection1))
                {
                    comandoEspacio.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro con el valor de txtMonto
                    comandoEspacio.Parameters.AddWithValue("@monto", monto);

                    // Ejecutar el procedimiento almacenado
                    comandoEspacio.ExecuteNonQuery();

                   
                }
            }
            catch (Exception ex)
            {
                // Manejar errores durante la ejecución
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
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

        private void cbEspacio_SelectedIndexChanged(object sender, EventArgs e) { }
        private void frmcobrar_Load_2(object sender, EventArgs e)
        {

        }

        private void lblDato_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            traer_datos_cobro();
            traer_datos_monto();
            
        }
    }
}
;