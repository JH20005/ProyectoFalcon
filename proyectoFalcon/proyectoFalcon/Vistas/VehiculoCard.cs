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
    public partial class VehiculoCard : UserControl
    {
        public VehiculoCard(Vehiculo vehiculo)
        {
            InitializeComponent();
            lblMarca.Text = vehiculo.marca;
            lblModelo.Text = vehiculo.modelo;
            fotoVehiculo.Image = Imagen.bytesToImage(vehiculo.foto);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalles_MouseEnter(object sender, EventArgs e)
        {
            btnDetalles.ForeColor = Estilos.getSecundario();
            btnDetalles.BackColor = Estilos.getPrimario();
            btnDetalles.FlatAppearance.BorderColor = Estilos.getSecundario();
        }

        private void btnDetalles_MouseLeave(object sender, EventArgs e)
        {
            btnDetalles.ForeColor = Estilos.getPrimario();
            btnDetalles.BackColor = Estilos.getSecundario();
            btnDetalles.FlatAppearance.BorderColor = Estilos.getPrimario();
        }
    }
}
