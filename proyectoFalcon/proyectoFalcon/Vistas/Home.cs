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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            initData();
        }

        public void initData()
        {
            Dashboard dashboard = Dashboard.getEstadisticas();
            lblqVendedores.Text = dashboard.qvendedores.ToString();
            lblqCompradores.Text = dashboard.qcompradores.ToString();
            lblqVehiculosComprados.Text = dashboard.qcompras.ToString();
            lblqVehiculosEnviadosPais.Text = dashboard.qenviospais.ToString();
            lblqVehiculosEnviadosNaviera.Text = dashboard.qenviosnaviera.ToString();
        }
    }
}
