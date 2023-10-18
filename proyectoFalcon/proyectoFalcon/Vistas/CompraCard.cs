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
using proyectoFalcon.Properties;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Vistas
{
    public partial class CompraCard : UserControl
    {
        Compra compra;
        MisCompras mc;
        public CompraCard(Compra compra, MisCompras mc)
        {
            InitializeComponent();
            lblMarca.Text = compra.vehiculo.marca;
            lblModelo.Text = compra.vehiculo.modelo;
            lblPrecio.Text = string.Format("{0:c}", compra.monto);
            lblVendedor.Text = string.Format("{0} {1}", compra.vendedor.nombre, compra.vendedor.apellido);
            if (compra.estado.idestadocompra == 20)
            {
                lblFecha.Text = string.Format("{0:dd/MM/yyyy}", compra.pago.fecha);
                pnlFechaPagado.Visible = true;
                btnPagar.Cursor = Cursors.Default;
                btnPagar.Image = Resources.icono_comprado;
                btnPagar.ForeColor = Color.White;
                btnPagar.BackColor = Color.Green;
                btnPagar.FlatAppearance.MouseDownBackColor = Color.Green;
                btnPagar.FlatAppearance.MouseOverBackColor = Color.Green;
                btnPagar.Text = "    Pagado";
            }
            else
            {
                lblFechaPago.Visible = false;
                lblFecha.Visible = false;
                btnPagar.Image = Resources.icono_comprar;
                btnPagar.ForeColor = Color.White;
                btnPagar.BackColor = Color.Blue;
            }


            if (compra.vehiculo.foto != null)
            {
                pbFoto.Image = Imagen.bytesToImage(compra.vehiculo.foto);
            }
            else
            {
                pbFoto.Image = Resources.no_image;
            }
            this.compra = compra;
            this.mc = mc;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (compra.estado.idestadocompra == 10)
            {
                using (ConfirmarPago confirmarPago = new ConfirmarPago(compra))
                {
                    DialogResult result = confirmarPago.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.mc.initData();
                    }
                }
            }
        }
    }
}
