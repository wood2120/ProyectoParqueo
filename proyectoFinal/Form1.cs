using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        // Declarar el Timer
        private Timer timer;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar el Timer para que actualice las imágenes cada 5 segundos (5000 ms)
            timer = new Timer();
            timer.Interval = 5000; // 5000 ms = 5 segundos
            timer.Tick += Timer_Tick; // Evento que se ejecuta cada vez que el Timer "tiquea"
            timer.Start(); // Iniciar el Timer

            // Llamar a MostrarImagenParaEspacio para cargar las imágenes al cargar el formulario
            MostrarImagenParaEspacio("r1", picR1);
            MostrarImagenParaEspacio("r2", picR2);
            MostrarImagenParaEspacio("r3", picR3);
            MostrarImagenParaEspacio("r4", picR4);
            MostrarImagenParaEspacio("r5", picR5);
            MostrarImagenParaEspacio("c1", picC1);
            MostrarImagenParaEspacio("d1", picD1);
            MostrarImagenParaEspacio("d2", picD2);
            MostrarImagenParaEspacio("m1", picM1);
            MostrarImagenParaEspacio("m2", picM2);
            MostrarImagenParaEspacio("m3", picM3);
            MostrarImagenParaEspacio("m4", picM4);
            MostrarImagenParaEspacio("m5", picM5);
            MostrarImagenParaEspacio("m6", picM6);
            MostrarImagenParaEspacio("m7", picM7);
            MostrarImagenParaEspacio("m8", picM8);
        }

        private void DetenerActualizacion()
        {
            timer.Stop(); // Detener el Timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar las imágenes de los espacios cada vez que el Timer "tiquea"
            MostrarImagenParaEspacio("r1", picR1);
            MostrarImagenParaEspacio("r2", picR2);
            MostrarImagenParaEspacio("r3", picR3);
            MostrarImagenParaEspacio("r4", picR4);
            MostrarImagenParaEspacio("r5", picR5);
            MostrarImagenParaEspacio("c1", picC1);
            MostrarImagenParaEspacio("d1", picD1);
            MostrarImagenParaEspacio("d2", picD2);
            MostrarImagenParaEspacio("m1", picM1);
            MostrarImagenParaEspacio("m2", picM2);
            MostrarImagenParaEspacio("m3", picM3);
            MostrarImagenParaEspacio("m4", picM4);
            MostrarImagenParaEspacio("m5", picM5);
            MostrarImagenParaEspacio("m6", picM6);
            MostrarImagenParaEspacio("m7", picM7);
            MostrarImagenParaEspacio("m8", picM8);
        }

        private void MostrarImagenParaEspacio(string espacio, PictureBox picBox)
        {
            try
            {
                // Asegúrate de que la conexión a la base de datos esté abierta
                sqlConnection1.Open();

                // Crear y configurar el comando para obtener la imagen del espacio
                SqlCommand comandoEspacio = new SqlCommand("SP_OBTENER_IMAGEN_ESPACIO", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comandoEspacio.Parameters.AddWithValue("@espacio", espacio); // Pasar el nombre del espacio como parámetro

                // Ejecutar el comando y obtener la imagen
                SqlDataReader reader = comandoEspacio.ExecuteReader();

                if (reader.Read())
                {
                    // Obtener los bytes de la imagen desde la base de datos
                    byte[] imagenBytes = reader["imagen"] as byte[];

                    if (imagenBytes != null)
                    {
                        // Convertir los bytes de la imagen a una imagen y mostrarla en el PictureBox
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            picBox.Image = Image.FromStream(ms);

                            // Ajustar la imagen al tamaño del PictureBox
                            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        // Si no hay imagen, asignar la imagen "libre.png" predeterminada
                        string rutaImagen = @"C:\Users\crist\Downloads\img\libre.png";
                        picBox.Image = Image.FromFile(rutaImagen);
                        picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    // Si no se encuentra el espacio, asignar la imagen "libre.png"
                    string rutaImagen = @"C:\Users\crist\Downloads\img\libre.png";
                    picBox.Image = Image.FromFile(rutaImagen);
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                reader.Close();
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


        /*private void MostrarImagenParac1()
        {
            try
            {
                // Asegúrate de que la conexión a la base de datos esté abierta
                sqlConnection1.Open();

                // Crear y configurar el comando para obtener la imagen del espacio "r1"
                SqlCommand comandoEspacio = new SqlCommand("SP_OBTENER_IMAGEN_ESPACIO", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comandoEspacio.Parameters.AddWithValue("@espacio", "c1"); // Buscar el espacio "r1"

                // Ejecutar el comando y obtener la imagen
                SqlDataReader reader = comandoEspacio.ExecuteReader();

                if (reader.Read())
                {
                    // Obtener los bytes de la imagen desde la base de datos
                    byte[] imagenBytes = reader["imagen"] as byte[];

                    if (imagenBytes != null)
                    {
                        // Convertir los bytes de la imagen a una imagen y mostrarla en el PictureBox
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            picC1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una imagen para el espacio 'c1'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el espacio 'c1'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
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
        private void MostrarImagenParar1()
        {
            try
            {
                // Asegúrate de que la conexión a la base de datos esté abierta
                sqlConnection1.Open();

                // Crear y configurar el comando para obtener la imagen del espacio "r1"
                SqlCommand comandoEspacio = new SqlCommand("SP_OBTENER_IMAGEN_ESPACIO", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comandoEspacio.Parameters.AddWithValue("@espacio", "r1"); // Buscar el espacio "r1"

                // Ejecutar el comando y obtener la imagen
                SqlDataReader reader = comandoEspacio.ExecuteReader();

                if (reader.Read())
                {
                    // Obtener los bytes de la imagen desde la base de datos
                    byte[] imagenBytes = reader["imagen"] as byte[];

                    if (imagenBytes != null)
                    {
                        // Convertir los bytes de la imagen a una imagen y mostrarla en el PictureBox
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            picR1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una imagen para el espacio 'r1'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el espacio 'r1'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
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
        private void MostrarImagenParar2()
        {
            try
            {
                // Asegúrate de que la conexión a la base de datos esté abierta
                sqlConnection1.Open();

                // Crear y configurar el comando para obtener la imagen del espacio "r1"
                SqlCommand comandoEspacio = new SqlCommand("SP_OBTENER_IMAGEN_ESPACIO", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comandoEspacio.Parameters.AddWithValue("@espacio", "r2"); // Buscar el espacio "r1"

                // Ejecutar el comando y obtener la imagen
                SqlDataReader reader = comandoEspacio.ExecuteReader();

                if (reader.Read())
                {
                    // Obtener los bytes de la imagen desde la base de datos
                    byte[] imagenBytes = reader["imagen"] as byte[];

                    if (imagenBytes != null)
                    {
                        // Convertir los bytes de la imagen a una imagen y mostrarla en el PictureBox
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            picR2.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una imagen para el espacio 'r2'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el espacio 'r2'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
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
        }*/




        private void btnReservar_Click(object sender, EventArgs e)
        {
            frmReservar frmReservar = new frmReservar();
            frmReservar.ShowDialog();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            frmcobrar frmcobrar = new frmcobrar();
            frmcobrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmfactura frmfactura = new frmfactura();
            frmfactura.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void picR2_Click(object sender, EventArgs e)
        {

        }
        private void picR3_Click(object sender, EventArgs e) { }
        private void picR4_Click(object sender, EventArgs e) { }
        private void picR5_Click(object sender, EventArgs e) { }
        private void picC1_Click(object sender, EventArgs e) { }
        private void picD2_Click(object sender, EventArgs e) { }
        private void picD1_Click(object sender, EventArgs e) { }
        private void picM4_Click(object sender, EventArgs e) { }
        private void picM3_Click(object sender, EventArgs e) { }
        private void picM2_Click(object sender, EventArgs e) { }
        private void picM1_Click(object sender, EventArgs e) { }
        private void picM5_Click(object sender, EventArgs e) { }
        private void picM6_Click(object sender, EventArgs e) { }
        private void picM7_Click(object sender, EventArgs e) { }
        private void picM8_Click(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void picR1_Click_1(object sender, EventArgs e) { }
        private void txtIndice_TextChanged(object sender, EventArgs e) { }
    }
}
