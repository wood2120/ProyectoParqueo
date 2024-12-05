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
        
        private Timer timer;

        private void Form1_Load(object sender, EventArgs e)
        {
         
            timer = new Timer();
            timer.Interval = 5; 
            timer.Tick += Timer_Tick; 
            timer.Start();
          
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
            timer.Stop(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {          
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
                sqlConnection1.Open();
               
                SqlCommand comandoEspacio = new SqlCommand("SP_OBTENER_IMAGEN_ESPACIO", sqlConnection1)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comandoEspacio.Parameters.AddWithValue("@espacio", espacio);                
                SqlDataReader reader = comandoEspacio.ExecuteReader();

                if (reader.Read())
                {                    
                    byte[] imagenBytes = reader["imagen"] as byte[];

                    if (imagenBytes != null)
                    {                     
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            picBox.Image = Image.FromStream(ms);                            
                            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {                       
                        string rutaImagen = @"C:\Users\crist\Downloads\img\libre.png";
                        picBox.Image = Image.FromFile(rutaImagen);
                        picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {                    
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

        /*private void btnReservar_Click(object sender, EventArgs e)
        {
            frmReservar frmReservar = new frmReservar();
            frmReservar.ShowDialog();
        }*/

        private void btnPago_Click(object sender, EventArgs e)
        {
            frmcobrar frmcobrar = new frmcobrar();
            frmcobrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
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

      

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmReservar frmReservar = new frmReservar();
            frmReservar.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmAcceso frmAcceso = new frmAcceso();
            frmAcceso.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmcobrar frmcobrar = new frmcobrar();
            frmcobrar.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmTarifas frmTarifas = new frmTarifas();
            frmTarifas.ShowDialog();
        }
    }
}
