using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCantidadConversores_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;

            de = cboAconversores.SelectedIndex;
            a = cboAconversores.SelectedIndex;

            cantidad = double.Parse(txtCantidadConversores.Text);

            double[] monedas = { 1, 0.92, 24.66, 8.75, 36.58, 535.14, 145.47, 0.79, 83.29 };
            respuesta = monedas[a] / monedas[de] * cantidad;

            lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta, 3);
        }

        private void cmbCantidad1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
