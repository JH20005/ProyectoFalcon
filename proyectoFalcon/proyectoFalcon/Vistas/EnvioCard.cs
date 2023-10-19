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

namespace proyectoFalcon.Vistas
{
    public partial class EnvioCard : UserControl
    {
        Envio envio;
        EnvioSeguimiento ev;

        public EnvioCard(Envio envio, EnvioSeguimiento ev)
        {
            InitializeComponent();
            this.envio = envio;
            this.ev = ev;
            initData();
        }

        public void initData()
        {
            lblMarca.Text = envio.vehiculo.marca;
            lblModelo.Text = envio.vehiculo.modelo;
            lblFecha.Text = string.Format("{0:dd/MM/yyyy}", envio.fecha);
            lblEnvio.Text = string.Format("Envío hacia {0}", envio.destino.descripcion);
        }

        private void btnVerEstado_Click(object sender, EventArgs e)
        {
            this.ev.renderStatus(envio);
        }
    }
}
