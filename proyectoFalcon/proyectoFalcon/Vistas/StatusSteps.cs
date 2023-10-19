using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFalcon.Properties;

namespace proyectoFalcon.Vistas
{

    public partial class StatusSteps : UserControl
    {
        int? tipoEnvio;
        int? status;
        public StatusSteps(int? tipoEnvio, int? status)
        {
            InitializeComponent();
            this.tipoEnvio = tipoEnvio;
            this.status = status;
            initData();
        }

        public void initData()
        {
            lblStatus10.Text = "En preparación";
            lblStatus20.Text = "En tránsito";
            lblStatus30.Text = "En llegada";
            lblStatus40.Text = tipoEnvio == 0 ? "En país destino" : "En naviera";
            switch (status)
            {
                case 10:
                    {
                        pbIconStatus.Image = Resources.icono_status_10;
                        lblStatus10.ForeColor = Color.Blue;
                        break;
                    }
                case 20:
                    {
                        pbIconStatus.Image = Resources.icono_status_20;
                        lblStatus20.ForeColor = Color.Blue;
                        break;
                    }
                case 30:
                    {
                        pbIconStatus.Image = Resources.icono_status_30;
                        lblStatus30.ForeColor = Color.Blue;
                        break;
                    }
                case 40:
                    {
                        pbIconStatus.Image = Resources.icono_status_40;
                        lblStatus40.ForeColor = Color.Blue;
                        break;
                    }
                case 50:
                    {
                        pbIconStatus.Image = Resources.icono_status_50;
                        lblStatus40.ForeColor = Color.Blue;
                        break;
                    }
            }
        }
    }
}
