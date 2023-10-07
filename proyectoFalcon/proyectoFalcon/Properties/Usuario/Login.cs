using proyectoFalcon.Properties.Usuario;
using System.Data.SqlClient;

namespace proyectoFalcon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=localhost;database=falcon; integrated security = true");

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
            bool usuarioExiste = false;

            {
                conn.Open();

                string sql = "SELECT usuario, contrasenia FROM usuarios WHERE usuario = @usuario AND contrasenia = @contrasenia";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@usuario", textBox1.Text);
                cmd.Parameters.AddWithValue("@contrasenia", txtPassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    usuarioExiste = true;
                }
         
                conn.Close();
            }

            return usuarioExiste;
        }

    }
}