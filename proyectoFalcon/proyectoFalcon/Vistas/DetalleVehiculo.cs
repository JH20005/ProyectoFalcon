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
    public partial class DetalleVehiculo : Form
    {
        Vehiculo vehiculo;
        public DetalleVehiculo(Vehiculo vehiculo)
        {
            InitializeComponent();
            this.vehiculo = vehiculo;
            initPantalla();
        }

        public void initPantalla()
        {
            Persona persona = getVendedor();
            lblMarca.Text = vehiculo.marca;
            lblModelo.Text = vehiculo.modelo;
            lblPrecio.Text = string.Format("{0:c}", vehiculo.precio);
            lblVendedor.Text = string.Format("{0} {1}", persona.nombre, persona.apellido);
            if (vehiculo.foto != null)
            {
                pbFoto.Image = Imagen.bytesToImage(vehiculo.foto);
            }
            else
            {
                pbFoto.Image = Resources.no_image;
            }
        }

        private Persona getVendedor()
        {
            Persona persona = Persona.buscarPersona(vehiculo.idvendedor.idpersona);
            return persona;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
