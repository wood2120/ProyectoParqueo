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
    public partial class frmcobrar : Form
    {
        /*public frmcobrar()
        {
            InitializeComponent();
        }*/

        private void frmcobrar_Load(object sender, EventArgs e)
        {

        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago confirmado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void lblDato_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
this.Close(); // Cierra la ventana actual
        }
    }
}
