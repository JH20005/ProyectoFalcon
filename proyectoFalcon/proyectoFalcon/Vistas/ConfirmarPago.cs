using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFalcon.Modelos;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Vistas
{
    public partial class ConfirmarPago : Form
    {
        Compra compra;
        public ConfirmarPago(Compra compra)
        {
            InitializeComponent();
            lblMonto.Text = string.Format("{0:c}", compra.monto);
            this.compra = compra;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            compra.estado.idestadocompra = 20;
            compra.actualizarCompra();
            new Pago().guardarPago(compra.idcompra);
            Mensaje.showInfo("Pago realizado exitosamente");
        }
    }
}
