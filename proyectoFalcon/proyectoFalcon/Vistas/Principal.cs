using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using proyectoFalcon.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proyectoFalcon.Vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            lblRol.Text = Sesion.getUsuarioLogueado().rol.descripcion;
            initPantalla();
        }

        private void initPantalla()
        {
            try
            {
                sidebar.Controls.Add(new Button());
                MySqlConnection conexion = ConexionBD.openConexion();

                //string sql = "SELECT username, password, tipo FROM usuarios WHERE username = @usuario";
                StringBuilder query = new StringBuilder();
                query.Append("SELECT mp.idmenu, m.descripcion, mp.idperfil ");
                query.Append("FROM menu m ");
                query.Append("INNER JOIN menuxperfil mp ");
                query.Append("ON mp.idmenu = m.idmenu ");
                query.Append("WHERE mp.idperfil = @idperfil");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@idperfil", Sesion.getUsuarioLogueado().tipo);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                Mensaje.showError(ex.Message);
            }
            finally
            {
                ConexionBD.closeConexion();
            }

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

        private void pnlCerrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
