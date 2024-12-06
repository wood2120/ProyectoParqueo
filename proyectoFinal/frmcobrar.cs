using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            txtPlaca.Focus();
        }

        private void frmcobrar_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
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
        private void borrar_espacio()
        {

            sqlConnection1.Open();

            SqlCommand ComandoElemento = new SqlCommand("SP_BORRAR_ESPACIO", sqlConnection1);
            ComandoElemento.CommandType = CommandType.StoredProcedure;
            ComandoElemento.Parameters.AddWithValue("@placa", txtPlaca.Text);

            SqlDataReader Elemento = ComandoElemento.ExecuteReader();


            sqlConnection1.Close();
        }


        private void traer_datos_monto()
        {
            string pago;
            string vuelto;
            sqlConnection1.Open();

            SqlCommand ComandoElemento = new SqlCommand("calcular_pago", sqlConnection1);
            ComandoElemento.CommandType = CommandType.StoredProcedure;
            ComandoElemento.Parameters.AddWithValue("@placa", txtPlaca.Text);

            SqlDataReader Elemento = ComandoElemento.ExecuteReader();

            if (Elemento.Read())
            {
                txtMonto.Text = Elemento["monto_a_pagar"].ToString();
            
            }
       

            sqlConnection1.Close();
        }


        private void GuardarMonto()
        {
            decimal monto;
            decimal pago;

            // Intentar convertir los textos a valores decimales
            if (!decimal.TryParse(txtMonto.Text, out monto) || !decimal.TryParse(txtpago.Text, out pago))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos de monto y pago.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que el pago sea suficiente
            if (pago < monto)
            {
                decimal falta = monto - pago;
                MessageBox.Show("Te falta " + falta.ToString("F2") + " para completar el pago.", "Pago Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir de la función si el pago no es suficiente
            }

            // Proceder al guardado si el pago es suficiente
            try
            {
                // Abrir la conexión
                sqlConnection1.Open();

                // Crear el comando para el procedimiento almacenado
                SqlCommand comando = new SqlCommand("SP_GUARDAR_MONTO", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };

                // Agregar parámetros
                comando.Parameters.AddWithValue("@placa", txtPlaca.Text);
                comando.Parameters.AddWithValue("@monto", monto);

                // Ejecutar el comando
                comando.ExecuteNonQuery();

                // Confirmar éxito al usuario
                MessageBox.Show("El monto ha sido guardado exitosamente.", "Guardar Monto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al guardar el monto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (sqlConnection1.State == ConnectionState.Open)
                    sqlConnection1.Close();
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
            txtPlaca.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            traer_datos_cobro();
            traer_datos_monto();         
         }

        private void frmcobrar_Load_3(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            txtPlaca.Focus();
            txtPlaca.Clear();
            txtEspacio.Clear();
            txtTiempo.Clear();
            txtMonto.Clear();
            txtpago.Clear();

        }
    }
}
;