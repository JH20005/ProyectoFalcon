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
using proyectoFalcon.Modelos;
using proyectoFalcon.Properties;
using proyectoFalcon.Utils;

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
                initMenu();
                pnlMenu.Controls.Clear();
                MySqlConnection conexion = ConexionBD.openConexion();
                List<int> permisos = new List<int>();

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
                    permisos.Add(int.Parse(reader["idmenu"].ToString()));
                }
                foreach (var permiso in permisos)
                {
                    pnlMenu.Controls.Add(Menu.getPanel(permiso));
                }
                switch (Sesion.getUsuarioLogueado().tipo)
                {
                    case 10:
                        {
                            appPanel.Controls.Clear();
                            reiniciarSidebar();
                            btnInicio.Image = Resources.menu_inicio_selected;
                            btnInicio.BackColor = Estilos.getSecundario();
                            btnInicio.ForeColor = Estilos.getPrimario();
                            showPantalla(new Home());
                            break;
                        }
                    case 20:
                        {
                            appPanel.Controls.Clear();
                            reiniciarSidebar();
                            btnCotizar.Image = Resources.menu_compras_selected;
                            btnCotizar.BackColor = Estilos.getSecundario();
                            btnCotizar.ForeColor = Estilos.getPrimario();
                            showPantalla(new ComprarCotizar());
                            break;
                        }
                    case 30:
                        {
                            appPanel.Controls.Clear();
                            reiniciarSidebar();
                            btnMisVehiculos.Image = Resources.menu_vehiculos_selected;
                            btnMisVehiculos.BackColor = Estilos.getSecundario();
                            btnMisVehiculos.ForeColor = Estilos.getPrimario();
                            showPantalla(new MantenimientoVehiculos(false));
                            break;
                        }
                }
                reader.Close();
                if (Sesion.getUsuarioLogueado().tipo != 10)
                {
                    conexion = ConexionBD.openConexion();
                    query = new StringBuilder();
                    query.Append("SELECT p.nombre, p.apellido, p.username ");
                    query.Append("FROM persona p ");
                    query.Append("WHERE p.username = @username");
                    cmd = new MySqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@username", Sesion.getUsuarioLogueado().username);

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lblNombres.Text = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
                    }
                }
                else
                {
                    lblNombres.Text = "Admin";
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

        public void initMenu()
        {
            Menu.clearMenus();
            Menu.addMenu(10, this.pnlInicio);
            Menu.addMenu(20, this.pnlUsuarios);
            Menu.addMenu(30, this.pnlVehiculos);
            Menu.addMenu(40, this.pnlCompras);
            Menu.addMenu(50, this.pnlEnvios);
            Menu.addMenu(60, this.pnlEnvio);
            Menu.addMenu(70, this.pnlMisVehiculos);
            Menu.addMenu(80, this.pnlMisEnvios);
        }

        private void showPantalla(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            appPanel.Controls.Add(userControl);
            userControl.Show();
        }

        private void reiniciarSidebar()
        {
            btnInicio.Image = Resources.menu_inicio;
            btnInicio.BackColor = Estilos.getPrimario();
            btnInicio.ForeColor = Estilos.getSecundario();

            btnUsuarios.Image = Resources.menu_usuarios;
            btnUsuarios.BackColor = Estilos.getPrimario();
            btnUsuarios.ForeColor = Estilos.getSecundario();

            btnVehiculos.Image = Resources.menu_vehiculos;
            btnVehiculos.BackColor = Estilos.getPrimario();
            btnVehiculos.ForeColor = Estilos.getSecundario();

            btnEnvios.Image = Resources.menu_envios;
            btnEnvios.BackColor = Estilos.getPrimario();
            btnEnvios.ForeColor = Estilos.getSecundario();

            btnCotizar.Image = Resources.menu_compras;
            btnCotizar.BackColor = Estilos.getPrimario();
            btnCotizar.ForeColor = Estilos.getSecundario();

            btnCompras.Image = Resources.menu_mis_compras;
            btnCompras.BackColor = Estilos.getPrimario();
            btnCompras.ForeColor = Estilos.getSecundario();

            btnMisVehiculos.Image = Resources.menu_vehiculos;
            btnMisVehiculos.BackColor = Estilos.getPrimario();
            btnMisVehiculos.ForeColor = Estilos.getSecundario();

            btnMisEnvios.Image = Resources.menu_envios;
            btnMisEnvios.BackColor = Estilos.getPrimario();
            btnMisEnvios.ForeColor = Estilos.getSecundario();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Estilos.getSecundario();
            button1.ForeColor = Estilos.getPrimario();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Estilos.getSecundario();
            button1.BackColor = Estilos.getPrimario();
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            appPanel.Controls.Clear();
            reiniciarSidebar();
            btnInicio.Image = Resources.menu_inicio_selected;
            btnInicio.BackColor = Estilos.getSecundario();
            btnInicio.ForeColor = Estilos.getPrimario();
            showPantalla(new Home());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            appPanel.Controls.Clear();
            reiniciarSidebar();
            btnUsuarios.Image = Resources.menu_usuarios_selected;
            btnUsuarios.BackColor = Estilos.getSecundario();
            btnUsuarios.ForeColor = Estilos.getPrimario();
            showPantalla(new MantenimientoUsuarios());
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            appPanel.Controls.Clear();
            reiniciarSidebar();
            btnVehiculos.Image = Resources.menu_vehiculos_selected;
            btnVehiculos.BackColor = Estilos.getSecundario();
            btnVehiculos.ForeColor = Estilos.getPrimario();
            showPantalla(new MantenimientoVehiculos(true));
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            appPanel.Controls.Clear();
            reiniciarSidebar();
            btnCotizar.Image = Resources.menu_compras_selected;
            btnCotizar.BackColor = Estilos.getSecundario();
            btnCotizar.ForeColor = Estilos.getPrimario();
            showPantalla(new ComprarCotizar());
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            appPanel.Controls.Clear();
            reiniciarSidebar();
            btnEnvios.Image = Resources.menu_envios_selected;
            btnEnvios.BackColor = Estilos.getSecundario();
            btnEnvios.ForeColor = Estilos.getPrimario();
            showPantalla(new EnvioSeguimiento());
        }

        private void btnCompras_Click_1(object sender, EventArgs e)
        {
            appPanel.Controls.Clear();
            reiniciarSidebar();
            btnCompras.Image = Resources.menu_mis_compras_selected;
            btnCompras.BackColor = Estilos.getSecundario();
            btnCompras.ForeColor = Estilos.getPrimario();
            showPantalla(new MisCompras());
        }

        private void btnMisVehiculos_Click(object sender, EventArgs e)
        {
            appPanel.Controls.Clear();
            reiniciarSidebar();
            btnMisVehiculos.Image = Resources.menu_vehiculos_selected;
            btnMisVehiculos.BackColor = Estilos.getSecundario();
            btnMisVehiculos.ForeColor = Estilos.getPrimario();
            showPantalla(new MantenimientoVehiculos(false));
        }

        private void btnMisEnvios_Click(object sender, EventArgs e)
        {
            appPanel.Controls.Clear();
            reiniciarSidebar();
            btnMisEnvios.Image = Resources.menu_envios_selected;
            btnMisEnvios.BackColor = Estilos.getSecundario();
            btnMisEnvios.ForeColor = Estilos.getPrimario();
            showPantalla(new MisEnvios());
        }
    }
}
