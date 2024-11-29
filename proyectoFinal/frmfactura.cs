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
    public partial class frmfactura : Form
    {
       /*public frmfactura()
        {
            InitializeComponent();
        }*/

       
        private void lstfactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmfactura_Load(object sender, EventArgs e)
        {
            MostrarDatosFactura();
        }
        private void MostrarDatosFactura()
        {
            try
            {                
                lstfactura.Items.Clear();

                sqlConnection1.Open();

                SqlCommand comando = new SqlCommand("SP_CREAR_FACTURA", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = comando.ExecuteReader();
                
                while (reader.Read())
                {
                   
                    ListViewItem item = new ListViewItem(reader["placa"].ToString());
                   
                    // areeglar esta picha

                    item.SubItems.Add(reader["tipo"].ToString());
                    item.SubItems.Add(reader["espacio"].ToString());
                    item.SubItems.Add(reader["tiempo"].ToString());
                    item.SubItems.Add(reader["monto"].ToString());
                   
                    lstfactura.Items.Add(item);
                }
                               
                reader.Close();
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }


    }
}


