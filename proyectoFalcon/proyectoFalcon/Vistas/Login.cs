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
            if (existeUsuario())
            {
                MessageBox.Show("Usuario Existe");
            }
            else
            {
                MessageBox.Show("Usuario No existe");
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

        private bool existeUsuario()
        {
            return Usuario.validarUsuario(txtUsername.Text, txtPassword.Text);
        }

    }
}