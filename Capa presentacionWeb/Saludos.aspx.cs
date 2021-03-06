﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa_presentacionWeb
{
    public partial class Saludos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            CapaLogica_ClassLibrary_.Contabilidad conta = new CapaLogica_ClassLibrary_.Contabilidad();
            this.lblMensaje.Text = conta.Saludos(nombre);

            double sueldo = double.Parse(this.txtSueldo.Text);
            this.lblSueldo.Text = conta.getSaldos(sueldo).ToString();

            int mes = Convert.ToInt32(this.txtNumMes.Text);
            this.lblMes.Text = CapaLogica_ClassLibrary_.Utilidades.getNombreDelMes(mes);

            string fecha = this.txtFecha.Text;
            lblFecha.Text = Convert.ToString(CapaLogica_ClassLibrary_.Utilidades.FECHA(fecha));
        }
    }
}