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
    public partial class EnvioSeguimiento : UserControl
    {
        public EnvioSeguimiento()
        {
            InitializeComponent();
            initData();
        }

        public void initData()
        {
            Persona c = Persona.buscarPersona(null, Sesion.getUsuarioLogueado().username);
            lstMisEnvios.Controls.Clear();
            Envio.buscarEnvios(c.idpersona, null).ForEach(envio =>
            {
                lstMisEnvios.Controls.Add(new EnvioCard(envio, this, null));
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
            lblVen.Visible = true;
            lblVendedor.Text = string.Format("{0} {1}", envio.vendedor.nombre, envio.vendedor.apellido);
            lblVendedor.Visible = true;
            pnlStatus.Controls.Clear();
            pnlStatus.Controls.Add(new StatusSteps(envio.tipoenvio, envio.estado.idestadoenvio));
            pnlStatus.Visible = true;
        }
    }
}
