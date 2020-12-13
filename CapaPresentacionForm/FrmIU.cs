using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionForm
{
    public partial class FrmIU : Form
    {
        public FrmIU()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validar ingresos

            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Ingresa tu nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            if (txtSaldoInicial.Text.Length == 0)
            {
                MessageBox.Show("Ingresa tu saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSaldoInicial.Focus();
                return;
            }
            if (txtMes.Text.Length == 0)
            {
                MessageBox.Show("Ingrese el numero de un mes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMes.Focus();
                return;
            }
            if (txtFecha.Text.Length == 0)
            {
                MessageBox.Show("Ingresa una fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFecha.Focus();
                return;
            }

            CapaLogica_ClassLibrary_.Contabilidad conta = new CapaLogica_ClassLibrary_.Contabilidad();
            string nombre = this.txtNombre.Text;
            this.txtMensage.Text = conta.Saludos(nombre);

            double x= double.Parse(this.txtSaldoInicial.Text);
            this.txtResultados.Text = conta.getSaldos(x).ToString();

            //calling to utilidades
            int nummes = int.Parse(this.txtMes.Text);
            this.txtNameMes.Text = CapaLogica_ClassLibrary_.Utilidades.getNombreDelMes(nummes);

            string fecha = this.txtFecha.Text;
            this.txtFechaValida.Text = Convert.ToString(CapaLogica_ClassLibrary_.Utilidades.FECHA(fecha));
        }

        private void txtFechaValida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only letters", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
