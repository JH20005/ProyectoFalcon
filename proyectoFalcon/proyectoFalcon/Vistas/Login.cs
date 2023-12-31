using proyectoFalcon.Models;
using proyectoFalcon.Utils;
using proyectoFalcon.Vistas;
using System.Data.SqlClient;

namespace proyectoFalcon
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection("server=localhost;database=falcon; integrated security = true");

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text))
            {
                Mensaje.showWarning("Debe ingresar un nombre de usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                Mensaje.showWarning("Debe ingresar la contrase�a");
                return;
            }
            existeUsuario();
            if (Sesion.getUsuarioLogueado() != null)
            {
                this.Hide();
                Principal formPrincipal = new Principal();
                formPrincipal.FormClosed += (s, args) => this.Close();
                formPrincipal.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevo = new NuevoUsuario();
            nuevo.ShowDialog();


        }

        private void existeUsuario()
        {
            Usuario.validarUsuario(txtUsername.Text, txtPassword.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (AppDialog cerrarApp = new AppDialog("�Desea salir de la aplicaci�n?"))
            {
                DialogResult result = cerrarApp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}