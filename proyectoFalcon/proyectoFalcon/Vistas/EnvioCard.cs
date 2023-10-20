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
        EnvioSeguimiento? ev;
        MisEnvios? me;

        public EnvioCard(Envio envio, EnvioSeguimiento? ev, MisEnvios? me)
        {
            InitializeComponent();
            this.envio = envio;
            this.ev = ev;
            initData();
            this.me = me;
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
            if(this.ev != null)
            {
                this.ev.renderStatus(envio);
            }
            if(this.me != null)
            {
                this.me.renderStatus(envio);
                this.me.selectEnvio(envio);
                this.me.habilitarEnvio();
            }
        }
    }
}
