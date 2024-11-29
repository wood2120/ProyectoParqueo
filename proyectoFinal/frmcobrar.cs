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
            try
            {
                
                sqlConnection1.Open();

               
                SqlCommand comando = new SqlCommand("SP_GUARDAR_MONTO", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };

              
                comando.Parameters.AddWithValue("@placa", txtPlaca.Text); 
                comando.Parameters.AddWithValue("@monto", string.IsNullOrEmpty(txtMonto.Text) ? (object)DBNull.Value : decimal.Parse(txtMonto.Text));

             
                comando.ExecuteNonQuery();

                
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
               
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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            traer_datos_cobro();
            traer_datos_monto();
            
        }
    }
}
;