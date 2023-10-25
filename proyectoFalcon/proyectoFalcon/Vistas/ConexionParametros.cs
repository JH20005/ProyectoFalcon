using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Vistas
{
    public partial class ConexionParametros : Form
    {
        bool conexionExitosa = false;

        public ConexionParametros()
        {
            InitializeComponent();
            txtHost.Text = ConfigurationManager.AppSettings["host"];
            txtbdName.Text = ConfigurationManager.AppSettings["name"];
            txtUser.Text = ConfigurationManager.AppSettings["user"];
            txtPass.Text = ConfigurationManager.AppSettings["pass"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initConexion(true);
        }

        private void initConexion(bool show)
        {
            try
            {
                ConexionBD.setNewParams(txtHost.Text, txtbdName.Text, txtUser.Text, txtPass.Text);
                ConexionBD.conectarBD();
                ConexionBD.openConexion();
                if (show)
                {
                    Mensaje.showInfo("Conexión exitosa");
                    this.Hide();
                    changeConexionParametros();
                    Login login = new Login();
                    login.FormClosed += (s, args) => this.Close();
                    login.Show();
                }
                //button2.Enabled = true;
            }
            catch (Exception ex)
            {
                Mensaje.showError("No se pudo conectar a la BD");
                //button2.Enabled = false;
            }
            finally
            {
                ConexionBD.closeConexion();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            initConexion(false);

        }

        private void changeConexionParametros()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["host"].Value = txtHost.Text;
            configuration.AppSettings.Settings["name"].Value = txtbdName.Text;
            configuration.AppSettings.Settings["user"].Value = txtUser.Text;
            configuration.AppSettings.Settings["pass"].Value = txtPass.Text;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
