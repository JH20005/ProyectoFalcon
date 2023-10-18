﻿using System;
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
        ACCION? accion;

        public DetalleVehiculo(Vehiculo vehiculo)
        {
            InitializeComponent();
            this.vehiculo = vehiculo;
            initPantalla();
        }

        public void initPantalla()
        {
            vehiculo.idvendedor = getVendedor();
            lblMarca.Text = vehiculo.marca;
            lblModelo.Text = vehiculo.modelo;
            lblPrecio.Text = string.Format("{0:c}", vehiculo.precio);
            lblVendedor.Text = string.Format("{0} {1}", vehiculo.idvendedor.nombre, vehiculo.idvendedor.apellido);
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
            Persona persona = Persona.buscarPersona(vehiculo.idvendedor.idpersona, null);
            return persona;
        }

        private Compra getCompra()
        {
            Compra compra = new Compra();
            compra.monto = vehiculo.precio;
            compra.vehiculo = vehiculo;
            EstadosCompra estado = new EstadosCompra();
            estado.idestadocompra = 10;
            compra.estado = estado;
            Persona comprador = Persona.buscarPersona(null, Sesion.getUsuarioLogueado().username);
            compra.comprador = comprador;
            compra.vendedor = vehiculo.idvendedor;
            return compra;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accion != null)
            {
                switch (accion)
                {
                    case ACCION.COMPRAR:
                        {
                            getCompra().guardarCompra();
                            vehiculo.idestado.idestadovehiculo = 30;
                            vehiculo.actualizarVehiculo();
                            Mensaje.showInfo("Comprado con éxito, revisar lista de compras para proceder al pago.");
                            break;
                        }
                    case ACCION.ENVIAR_PAIS:
                        {
                            break;
                        }
                    case ACCION.ENVIAR_ADUANA:
                        {
                            break;
                        }
                }
            }
        }

        private void rdbComprar_CheckedChanged(object sender, EventArgs e)
        {
            cmdPais.Visible = false;
            accion = ACCION.COMPRAR;
        }

        private void rdbPais_CheckedChanged(object sender, EventArgs e)
        {
            cmdPais.Visible = true;
            accion = ACCION.ENVIAR_PAIS;
        }

        private void rdbAduana_CheckedChanged(object sender, EventArgs e)
        {
            cmdPais.Visible = true;
            accion = ACCION.ENVIAR_ADUANA;
        }
    }

    public enum ACCION
    {
        COMPRAR = 0,
        ENVIAR_PAIS = 1,
        ENVIAR_ADUANA = 2,
    }
}