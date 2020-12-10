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
            CapaLogica_ClassLibrary_.Contabilidad conta = new CapaLogica_ClassLibrary_.Contabilidad();
            string nombre = this.txtNombre.Text;
            this.txtMensage.Text = conta.Saludos(nombre);

            double x= double.Parse(this.txtSaldoInicial.Text);
            this.txtResultados.Text = conta.getSaldos(x).ToString();

            //calling to utilidades
            int nummes = int.Parse(this.txtMes.Text);
            this.txtNameMes.Text = CapaLogica_ClassLibrary_.Utilidades.getNombreDelMes(nummes);
        }
    }
}
