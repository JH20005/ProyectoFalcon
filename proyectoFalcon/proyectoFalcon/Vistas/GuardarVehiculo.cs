using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFalcon.Modelos;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Vistas
{
    public partial class GuardarVehiculo : Form
    {
        List<EstadosVehiculo> estados = new List<EstadosVehiculo>();
        public GuardarVehiculo()
        {
            InitializeComponent();
            initPantalla();
        }

        private void initPantalla()
        {
            estados = EstadosVehiculo.getEstadosVehiculo();
            cmbEstadosVehiculo.DataSource = estados;
            cmbEstadosVehiculo.ValueMember = "idestadovehiculo";
            cmbEstadosVehiculo.DisplayMember = "descripcion";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.png|*.jpg;*.jpeg;.*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void btnAdjuntar_MouseEnter(object sender, EventArgs e)
        {
            btnAdjuntar.ForeColor = Estilos.getPrimario();
            btnAdjuntar.BackColor = Estilos.getSecundario();
            btnAdjuntar.FlatAppearance.BorderColor = Estilos.getPrimario();
        }

        private void btnAdjuntar_MouseLeave(object sender, EventArgs e)
        {
            btnAdjuntar.ForeColor = Estilos.getSecundario();
            btnAdjuntar.BackColor = Estilos.getPrimario();
            btnAdjuntar.FlatAppearance.BorderColor = Estilos.getSecundario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string year = txtYear.Text;
            decimal precio = Decimal.Parse(txtPrecio.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, new CultureInfo("en-US"));
            int idestado = int.Parse(cmbEstadosVehiculo.SelectedValue.ToString());
            byte[] foto = Imagen.imageToByte(pbFoto.Image);
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.marca = marca;
            vehiculo.modelo = modelo;
            vehiculo.year = year;
            vehiculo.precio = precio;
            vehiculo.idestado = idestado;
            vehiculo.fechapublicacion = DateTime.Today;
            vehiculo.foto = foto;
            vehiculo.guardarVehiculo();
        }
    }
}
