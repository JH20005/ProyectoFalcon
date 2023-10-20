﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFalcon.Modelos;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Vistas
{
    public partial class GuardarVehiculo : Form
    {
        List<EstadosVehiculo> estados = new List<EstadosVehiculo>();
        List<Persona> vendedores = new List<Persona>();
        Vehiculo? vehiculo = null;

        public GuardarVehiculo(Vehiculo? vehiculo)
        {
            InitializeComponent();
            this.vehiculo = vehiculo;
            initPantalla();
        }

        private void initPantalla()
        {

            estados = EstadosVehiculo.getEstadosVehiculo();
            if (Sesion.getUsuarioLogueado().rol.idrol == 10)
            {
                vendedores = Persona.buscarPersonas(30);             
            }
            else
            {
                vendedores.Clear();
                vendedores.Add(Persona.buscarPersona(null, Sesion.getUsuarioLogueado().username));
                EstadosVehiculo ev = new EstadosVehiculo();
                cmbEstadosVehiculo.Enabled = false;
                cmbVendedor.Enabled = false;
            }
            cmbEstadosVehiculo.DataSource = estados;
            cmbEstadosVehiculo.ValueMember = "idestadovehiculo";
            cmbEstadosVehiculo.DisplayMember = "descripcion";
            vendedores.ForEach(v => v.nombre += " " + v.apellido);
            cmbVendedor.DataSource = vendedores;
            cmbVendedor.ValueMember = "idpersona";
            cmbVendedor.DisplayMember = "nombre";
            if (vehiculo != null)
            {
                cmbEstadosVehiculo.SelectedValue = vehiculo.idestado.idestadovehiculo;
                cmbVendedor.SelectedValue = vehiculo.idvendedor.idpersona;
                txtMarca.Text = vehiculo.marca;
                txtModelo.Text = vehiculo.modelo;
                txtPrecio.Text = string.Format("{0:c}", vehiculo.precio.ToString());
                txtYear.Text = vehiculo.year.ToString();
                if (this.vehiculo.foto != null)
                {
                    pbFoto.Image = Imagen.bytesToImage(this.vehiculo.foto);
                }
                btnAdjuntar.Visible = false;
            }
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

        private Boolean validar()
        {
            string pattern = @"^\d+(\.\d+)?$";

            if (txtMarca.Text.Equals(""))
            {
                //MessageBox.Show("Debe agregar la marca.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Mensaje.showWarning("Debe agregar la marca.");

                return false;
            }
            if (txtModelo.Text.Equals(""))
            {
                MessageBox.Show("Debe agregar la Modelo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (txtYear.Text.Equals(""))
            {
                MessageBox.Show("Debe agregar el año.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Debe agregar el Precio.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (!Regex.IsMatch(txtPrecio.Text, pattern))
            {
                MessageBox.Show("El precio debe ser numerico.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;
            }
            else
            {

            }
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string year = txtYear.Text;
            decimal precio = Decimal.Parse(txtPrecio.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, new CultureInfo("en-US"));
            int idestado = int.Parse(cmbEstadosVehiculo.SelectedValue.ToString());
            int idvendedor = int.Parse(cmbVendedor.SelectedValue.ToString());
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.marca = marca;
            vehiculo.modelo = modelo;
            vehiculo.year = year;
            vehiculo.precio = precio;
            vehiculo.fechapublicacion = DateTime.Today;
            vehiculo.idestado.idestadovehiculo = idestado;
            vehiculo.idvendedor.idpersona = idvendedor;
            if (this.vehiculo == null)
            {
                if (pbFoto.Image != null)
                {
                    byte[] foto = Imagen.imageToByte(pbFoto.Image);
                    vehiculo.foto = foto;
                }
                vehiculo.guardarVehiculo();
            }
            else
            {
                vehiculo.idVehiculo = this.vehiculo.idVehiculo;
                vehiculo.actualizarVehiculo();
            }
        }
    }
}
