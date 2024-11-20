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
            pagar_espacio();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generar_Factura();
        }
        private void pagar_espacio()
        {

        }
        private void Generar_Factura()
        {

        }
    }
}
