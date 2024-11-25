using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picR1_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "R1"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picR1.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }

        }

        private void picR2_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "R2"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picR2.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picR3_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "R3"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picR3.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picR4_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "R4"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picR4.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picR5_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "R5"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picR5.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picC1_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "c1"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picR1.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picD2_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "D2"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picR1.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picD1_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "D1"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picR1.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picM4_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "M4"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picR1.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picM3_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "M3"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picR1.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picM2_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Definir el espacio que corresponde al PictureBox (en este caso, M2)
                string espacio = "M2"; // Cambia esto si estás usando otro espacio dinámicamente

                // Paso 2: Llamar al procedimiento almacenado para obtener la imagen
                SqlCommand comandoImagenes = new SqlCommand("ObtenerImagenPorEspacio", sqlConnection1);
                comandoImagenes.CommandType = CommandType.StoredProcedure;
                comandoImagenes.Parameters.AddWithValue("@Espacio", espacio);

                // Paso 3: Ejecutar la consulta y leer los resultados
                using (SqlDataReader reader = comandoImagenes.ExecuteReader())
                {
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];

                        // Ahora intenta cargar la imagen desde el stream
                        using (var ms = new MemoryStream(imageData))
                        {
                            picM2.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una imagen asociada con el espacio o tipo de reserva especificado.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones con más detalles
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}\nPila: {ex.StackTrace}",
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;
            string espacio = clickedPic.Name; // Usa el nombre del PictureBox para determinar el espacio

            // Llamar al procedimiento almacenado como en el código anterior
        }




        private void picM6_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "M6"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picM6.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picM5_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "M5"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picM5.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picM7_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "M7"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picM7.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            };
        }

        private void picM1_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "M1"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picM1.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }

        private void picM8_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (sqlConnection1.State != ConnectionState.Open)
                {
                    sqlConnection1.Open();
                }

                // Paso 1: Obtener el tipo_reserva desde la tabla parqueo_control usando el campo 'espacio'
                string queryParqueoControl = "SELECT tipo_reserva FROM parqueo_control WHERE espacio = @espacio"; // Consulta para obtener tipo_reserva basado en espacio
                SqlCommand comandoParqueoControl = new SqlCommand(queryParqueoControl, sqlConnection1);
                comandoParqueoControl.Parameters.AddWithValue("@espacio", "M8"); // Cambia "A1" por el valor de espacio que necesites

                object resultadoTipoReserva = comandoParqueoControl.ExecuteScalar(); // Devuelve el tipo_reserva o null

                // Verificar si se obtiene el valor esperado de tipo_reserva
                if (resultadoTipoReserva != null)
                {
                    string tipoReserva = resultadoTipoReserva.ToString().Trim(); // Usamos Trim() para quitar posibles espacios extra

                    // Depuración: Verificar el valor obtenido
                    MessageBox.Show($"Valor de tipo_reserva obtenido: {tipoReserva}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Paso 2: Buscar la imagen en la tabla imagenes basada en el tipo_reserva obtenido
                    string queryImagenes = "SELECT imagen FROM imagenes WHERE tipo = @tipo"; // Consulta para obtener la imagen basada en tipo
                    SqlCommand comandoImagenes = new SqlCommand(queryImagenes, sqlConnection1);
                    comandoImagenes.Parameters.AddWithValue("@tipo", tipoReserva); // Usamos el tipo_reserva como parámetro

                    // Ejecutamos la consulta
                    SqlDataReader reader = comandoImagenes.ExecuteReader();

                    // Paso 3: Procesar los datos obtenidos y asignarlos al PictureBox
                    if (reader.Read() && reader["imagen"] != DBNull.Value)
                    {
                        // Convertir los datos binarios en una imagen
                        byte[] imageData = (byte[])reader["imagen"];
                        using (var ms = new MemoryStream(imageData))
                        {
                            picM8.Image = Image.FromStream(ms); // Asignar la imagen al PictureBox
                        }
                    }
                    else
                    {
                        // Si no se encuentra la imagen asociada, mostrar un mensaje
                        MessageBox.Show($"No se encontró una imagen asociada con el tipo: {tipoReserva}.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close(); // Cerrar el SqlDataReader después de su uso
                }
                else
                {
                    // Si no se encuentra un valor para tipo_reserva
                    MessageBox.Show("No se encontró ningún valor de tipo_reserva en la tabla parqueo_control para el espacio especificado.",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }
        }
      


        
    }
}
