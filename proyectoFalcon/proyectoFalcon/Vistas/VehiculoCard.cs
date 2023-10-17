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
    public partial class VehiculoCard : UserControl
    {
        Vehiculo vehiculo;
        MantenimientoVehiculos? mv;
        public VehiculoCard(Vehiculo vehiculo, MantenimientoVehiculos? mv)
        {
            InitializeComponent();
            if(mv != null )
            {
                this.mv = mv;
            }         
            this.vehiculo = vehiculo;
            lblMarca.Text = vehiculo.marca;
            lblModelo.Text = vehiculo.modelo;
            lblPrecio.Text = string.Format("{0:c}", vehiculo.precio);
            if(vehiculo.foto != null)
            {
                fotoVehiculo.Image = Imagen.bytesToImage(vehiculo.foto);
            }
            else
            {
                fotoVehiculo.Image = Resources.no_image;
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if(this.mv != null)
            {
                using (GuardarVehiculo guardarVehiculo = new GuardarVehiculo(this.vehiculo))
                {
                    DialogResult result = guardarVehiculo.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.mv.loadData();
                    }
                }
            }

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
