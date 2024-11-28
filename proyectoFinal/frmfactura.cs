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
            
        }
        private void MostrarDatosFactura()
        {
            try
            {
                // Limpiar el ListView antes de agregar nuevos datos
                lstfactura.Items.Clear();

                // Crear y abrir la conexión a la base de datos
                sqlConnection1.Open();

                // Crear el comando para ejecutar el procedimiento almacenado
                SqlCommand comando = new SqlCommand("SP_CREAR_FACTURA", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };

                // Ejecutar el comando y obtener los datos con un SqlDataReader
                SqlDataReader reader = comando.ExecuteReader();

                // Iterar a través de los resultados y agregar los datos al ListView
                while (reader.Read())
                {
                    // Crear un nuevo item para cada fila de resultados
                    ListViewItem item = new ListViewItem(reader["placa"].ToString());

                    // Agregar los subítems (columnas adicionales) al item
                    item.SubItems.Add(reader["tipo"].ToString());
                    item.SubItems.Add(reader["espacio"].ToString());
                    item.SubItems.Add(reader["tiempo"].ToString());
                    item.SubItems.Add(reader["monto"].ToString());

                    // Agregar el item al ListView
                    lstfactura.Items.Add(item);
                }

                // Cerrar el reader y la conexión
                reader.Close();
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }


    }
}


