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

namespace proyectoFalcon.Vistas
{
    public partial class MantenimientoVehiculos : UserControl
    {
        int actualPage;
        const int size = 8;
        public MantenimientoVehiculos()
        {
            actualPage = 0;
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            gridVehiculos.Controls.Clear();
            Vehiculo.buscarVehiculos(null).ForEach(v =>
            {
                gridVehiculos.Controls.Add(new VehiculoCard(v, this));
            });
        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            btnGuardar.Image = Resources.icono_agregar_filled;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.Image = Resources.icono_agregar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using(GuardarVehiculo guardarVehiculo = new GuardarVehiculo(null))
            {
                DialogResult result = guardarVehiculo.ShowDialog();
                if(result == DialogResult.OK)
                {
                    loadData();
                }
            }
        }
    }
}
