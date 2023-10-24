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
            bool ok = true;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string username = textBox1.Text;
            string password = maskedTextBox1.Text;
            int idrol = 0;
            if (rdbComprador.Checked)
            {
                idrol = 20;
            }
            if (rdbVendedor.Checked)
            {
                idrol = 30;
            }
            if (idrol == 0)
            {
                ok = false;
                Mensaje.showWarning("Debe seleccionar un perfil para la cuenta");
            }
            if (ok)
            {
                Persona persona = new Persona();
                persona.nombre = nombre;
                persona.apellido = apellido;
                persona.correo = correo;
                persona.telefono = telefono;
                Usuario usuario = new Usuario();
                usuario.username = username;
                usuario.password = password;
                persona.usuario = usuario;
                Rol rol = new Rol();
                rol.idrol = idrol;
                usuario.rol = rol;
                usuario.guardarUsuario();
                persona.guardarPersona();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
