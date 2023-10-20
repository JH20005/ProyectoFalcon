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
    public partial class MisEnvios : UserControl
    {
        Envio envio;
        public MisEnvios()
        {
            InitializeComponent();
            initData();
        }

        public void initData()
        {
            if(Sesion.getUsuarioLogueado().rol.idrol != 30)
            {
                btnActualizarEstado.Visible = false;
            }
            if(this.envio == null)
            {
                btnActualizarEstado.Visible = false;
            }
            Persona c = Persona.buscarPersona(null, Sesion.getUsuarioLogueado().username);
            lstMisEnvios.Controls.Clear();
            Envio.buscarEnvios(null, c.idpersona).ForEach(envio =>
            {
                lstMisEnvios.Controls.Add(new EnvioCard(envio, null, this));
            });
        }

        public void renderStatus(Envio envio)
        {
            if (envio.vehiculo.foto != null)
            {
                pbFoto.Image = Imagen.bytesToImage(envio.vehiculo.foto);
            }
            else
            {
                pbFoto.Image = Resources.no_image;
            }
            pnlStatus.Controls.Clear();
            pnlStatus.Controls.Add(new StatusSteps(envio.tipoenvio, envio.estado.idestadoenvio));
            pnlStatus.Visible = true;
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            if(this.envio != null)
            {
                if (!(new List<int> { 40, 50 }.Contains(this.envio.estado.idestadoenvio)))
                {
                    int adder = 10;
                    if (this.envio.tipoenvio == 1 && this.envio.estado.idestadoenvio == 30)
                    {
                        adder = 20;
                    }                   
                    envio.estado.idestadoenvio += adder;
                    envio.actualizarEstadoEnvio();
                    initData();
                    renderStatus(envio);
                }
            }
        }

        public void selectEnvio(Envio envio)
        {
            this.envio = envio;
        }

        public void habilitarEnvio()
        {
            btnActualizarEstado.Visible = true;
        }
    }
}
