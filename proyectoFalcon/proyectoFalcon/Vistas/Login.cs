using proyectoFalcon.Models;
using proyectoFalcon.Properties.Usuario;
using proyectoFalcon.Utils;
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
            existeUsuario();
            if (Sesion.getUsuarioLogueado() != null)
            {
                //TODO: Ir a pantalla principal
                Mensaje.showInfo("Bienvenido: " + Sesion.getUsuarioLogueado().username);
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
            nuevo.Show();


        }

        private void existeUsuario()
        {
           Usuario.validarUsuario(txtUsername.Text, txtPassword.Text);
        }

    }
}