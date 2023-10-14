using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            lblRol.Text = Sesion.getUsuarioLogueado().rol.descripcion;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(255, 128, 128);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AppDialog dialog = new AppDialog("¿Desea salir de la aplicación?"))
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            using (AppDialog dialog = new AppDialog("¿Desea cerrar sesión?"))
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Login login = new Login();
                    login.FormClosed += (s, args) => this.Close();
                    Sesion.setUsuarioLogueado(null);
                    login.Show();
                }
            }
        }

        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarSesion.BackColor = Color.White;
            btnCerrarSesion.ForeColor = Color.FromArgb(255, 128, 128);
        }

        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.BackColor = Color.FromArgb(255, 128, 128);
        }
    }
}
