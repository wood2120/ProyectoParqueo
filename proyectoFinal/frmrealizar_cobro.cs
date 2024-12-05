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
    public partial class frmrealizar_cobro : Form
    {
        public frmrealizar_cobro()
        {
            InitializeComponent();
        }

        private void frmrealizar_cobro_Load(object sender, EventArgs e)
        {

        }
        private void calcular_vuelto()
        {
            try
            {
                // Verificar que el monto a pagar y el monto ingresado no estén vacíos.
                if (string.IsNullOrEmpty(txtMonto.Text) || string.IsNullOrEmpty(txtMontoUsuario.Text))
                {
                    MessageBox.Show("Por favor, asegúrese de que ambos campos estén llenos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir los valores a números.
                decimal monto_a_pagar = Convert.ToDecimal(txtMonto.Text);
                decimal monto_usuario = Convert.ToDecimal(txtMontoUsuario.Text);

                if (monto_usuario < monto_a_pagar)
                {
                    // Calcular y mostrar la diferencia que falta.
                    decimal diferencia = monto_a_pagar - monto_usuario;
                    MessageBox.Show($"El monto ingresado es insuficiente. Faltan {diferencia:C2}.", "Monto Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Calcular y mostrar el vuelto.
                    decimal vuelto = monto_usuario - monto_a_pagar;
                    txtVuelto.Text = vuelto.ToString("C2");
                    MessageBox.Show("El pago se realizó con éxito.", "Pago Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
