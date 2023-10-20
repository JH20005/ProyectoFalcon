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
    public partial class ComprarCotizar : UserControl
    {
        public ComprarCotizar()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            gridVehiculos.Controls.Clear();
            Vehiculo.buscarVehiculos(10, null).ForEach(v =>
            {
                gridVehiculos.Controls.Add(new VehiculoCard(v, null));
            });
        }
    }
}
