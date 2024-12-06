using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
            txtAcceso.Focus();
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            Acceso();
        }
        private void Acceso()
        {
            string Clave = "123456";

            if (Clave == txtAcceso.Text.Trim())
            {
                frmfactura frmfactura = new frmfactura();
                this.Hide();
                frmfactura.ShowDialog();
            }
            else
            {
                MessageBox.Show("contraseña incorrecta", "Mensaje de Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);        
            }
        }

        private void txtAcceso_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }
    }
}
