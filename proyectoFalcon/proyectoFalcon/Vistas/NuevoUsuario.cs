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
using proyectoFalcon.Models;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Vistas
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Persona persona = new Persona();
            Usuario usuario = new Usuario();
            persona.usuario = usuario;
            Rol rol = new Rol();
            usuario.rol = rol;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                Mensaje.showWarning("El nombre no puede estar vacío");
                return;
            }
            else
            {
                persona.nombre = txtNombre.Text;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                Mensaje.showWarning("El apellido no puede estar vacío");
                return;
            }
            else
            {
                persona.apellido = txtApellido.Text;
            }

            persona.telefono = txtTelefono.Text;
            persona.correo = txtCorreo.Text;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                Mensaje.showWarning("El nombre de usuario no puede estar vacío");
                return;
            }
            else
            {
                usuario.username = textBox1.Text;
            }

            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                Mensaje.showWarning("La contraseña no puede estar vacía");
                return;
            }
            else
            {
                usuario.password = maskedTextBox1.Text;
            }
            rol.idrol = 0;
            if (rdbComprador.Checked)
            {
                rol.idrol = 20;
            }
            if (rdbVendedor.Checked)
            {
                rol.idrol = 30;
            }
            if (rol.idrol == 0)
            {
                Mensaje.showWarning("Debe seleccionar un tipo de cuenta");
                return;
            }
            try
            {
                usuario.guardarUsuario();
                persona.guardarPersona();
                Close();
            }
            catch(Exception ex)
            {
                Mensaje.showError(string.Format("Error: {0}", ex.Message));
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
