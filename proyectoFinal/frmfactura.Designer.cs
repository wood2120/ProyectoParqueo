using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class frmfactura : Form
    {
        public frmfactura()
        {
            InitializeComponent();
            //CargarFacturas(); // Llama al método que carga las facturas desde la base de datos
        }

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lstfactura;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ColumnHeader colIDtipo;
        private System.Windows.Forms.ColumnHeader colespacio;
        private System.Windows.Forms.ColumnHeader colTiempo;
        private System.Windows.Forms.ColumnHeader colMonto;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstfactura = new System.Windows.Forms.ListView();
            this.clPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDtipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colespacio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTiempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstfactura
            // 
            this.lstfactura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clPlaca,
            this.colIDtipo,
            this.colespacio,
            this.colTiempo,
            this.colMonto});
            this.lstfactura.HideSelection = false;
            this.lstfactura.Location = new System.Drawing.Point(46, 70);
            this.lstfactura.Name = "lstfactura";
            this.lstfactura.Size = new System.Drawing.Size(692, 360);
            this.lstfactura.TabIndex = 0;
            this.lstfactura.UseCompatibleStateImageBehavior = false;
            this.lstfactura.View = System.Windows.Forms.View.Details;
            this.lstfactura.SelectedIndexChanged += new System.EventHandler(this.lstfactura_SelectedIndexChanged);
            // 
            // clPlaca
            // 
            this.clPlaca.DisplayIndex = 4;
            this.clPlaca.Text = "Placa";
            // 
            // colIDtipo
            // 
            this.colIDtipo.DisplayIndex = 0;
            this.colIDtipo.Text = "TIpo";
            this.colIDtipo.Width = 100;
            // 
            // colespacio
            // 
            this.colespacio.DisplayIndex = 1;
            this.colespacio.Text = "Espacio";
            this.colespacio.Width = 150;
            // 
            // colTiempo
            // 
            this.colTiempo.DisplayIndex = 2;
            this.colTiempo.Text = "Tiempo";
            this.colTiempo.Width = 100;
            // 
            // colMonto
            // 
            this.colMonto.DisplayIndex = 3;
            this.colMonto.Text = "Monto";
            this.colMonto.Width = 150;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=cristofer\\SQLEXPRESS;Initial Catalog=proyecto_parqueo;Integrated Secu" +
    "rity=True;Encrypt=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblTitulo.Location = new System.Drawing.Point(254, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Facturas Pendientes";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(430, 440);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Teal;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(250, 440);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 40);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmfactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstfactura);
            this.Name = "frmfactura";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmfactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //CargarFacturas(); // Vuelve a cargar las facturas
            MostrarDatosFactura();
        }

       /* private void CargarFacturas()
        {
            try
            {
                // Establecemos la conexión a la base de datos
                sqlConnection1.Open();
                string query = "SELECT FacturaID, Fecha, Monto, Estado FROM Facturas WHERE Estado = 'Pendiente'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection1);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                sqlConnection1.Close();

                // Limpiamos cualquier elemento previamente cargado
                lstfactura.Items.Clear();

                // Cargamos las facturas en el ListView
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["FacturaID"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(row["Fecha"]).ToString("dd/MM/yyyy"));
                    item.SubItems.Add("$" + row["Monto"].ToString());
                    item.SubItems.Add(row["Estado"].ToString());
                    lstfactura.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message);
            }
        }*/

        /*private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstfactura.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstfactura.SelectedItems[0];
                MessageBox.Show("Factura seleccionada: " + selectedItem.Text);
            }
        }*/

        private ColumnHeader clPlaca;
    }
}
