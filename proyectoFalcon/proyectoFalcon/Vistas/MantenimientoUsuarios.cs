using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using proyectoFalcon.Modelos;
using proyectoFalcon.Models;
using proyectoFalcon.Properties;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Vistas
{
    public partial class MantenimientoUsuarios : UserControl
    {
        int? id = null;
        string? username = null;
        List<Rol> roles = new List<Rol>();

        public MantenimientoUsuarios()
        {
            InitializeComponent();
            initPantalla();
        }

        private void initPantalla()
        {
            initLista();
            loadData();
            getRoles();
        }

        private void getRoles()
        {
            roles = Rol.getRoles();
            cmbRol.DataSource = roles;
            cmbRol.DisplayMember = "descripcion";
            cmbRol.ValueMember = "idrol";
        }

        private void loadData()
        {
            lstUsuarios.Rows.Clear();
            Persona.buscarPersonas(null).ForEach(persona =>
            {
                DataGridViewRow row = lstUsuarios.Rows[lstUsuarios.Rows.Add()];
                row.Cells["ID"].Value = persona.idpersona;
                row.Cells["nombre"].Value = persona.nombre;
                row.Cells["apellido"].Value = persona.apellido;
                row.Cells["correo"].Value = persona.correo;
                row.Cells["telefono"].Value = persona.telefono;
                row.Cells["usuario"].Value = persona.usuario.username;
                row.Cells["rol"].Value = persona.usuario.rol.descripcion;
            });
        }

        private void initLista()
        {
            lstUsuarios.Rows.Clear();
            lstUsuarios.Columns.Clear();
            lstUsuarios.Refresh();
            int idIndex = lstUsuarios.Columns.Add("ID", "ID");
            lstUsuarios.Columns[idIndex].Visible = false;
            lstUsuarios.Columns.Add("nombre", "Nombre");
            lstUsuarios.Columns.Add("apellido", "Apellido");
            lstUsuarios.Columns.Add("correo", "Correo");
            lstUsuarios.Columns.Add("telefono", "Teléfono");
            lstUsuarios.Columns.Add("usuario", "Usuario");
            lstUsuarios.Columns.Add("rol", "Rol");

            DataGridViewImageColumn botonVer = new DataGridViewImageColumn();
            lstUsuarios.Columns.AddRange(new DataGridViewColumn[] { botonVer });
            botonVer.Name = string.Empty;
            botonVer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            botonVer.SortMode = DataGridViewColumnSortMode.NotSortable;
            botonVer.Resizable = DataGridViewTriState.False;
            //botonVer.FlatStyle = FlatStyle.Flat;
            //botonVer.UseColumnTextForButtonValue = true;
            botonVer.Image = Resources.ver_24;
        }

        private void lstUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (lstUsuarios.Columns[e.ColumnIndex].Name == string.Empty)
            {
                btnEliminar.Enabled = true;
                pnlUserInfo.Visible = false;
                id = int.Parse(lstUsuarios.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                username = lstUsuarios.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
                lblId.Text = lstUsuarios.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtNombre.Text = lstUsuarios.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtApellido.Text = lstUsuarios.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                txtCorreo.Text = lstUsuarios.Rows[e.RowIndex].Cells["correo"].Value.ToString();
                txtTelefono.Text = lstUsuarios.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }
        private Boolean validar()
        {
            string pattern = @"^\d{10}$";

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                //MessageBox.Show("Debe agregar la Nombre.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Mensaje.showWarning("Debe agregar un nombre");
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                Mensaje.showWarning("Debe agregar un apellido");

                return false;
            }
            if (id == null && string.IsNullOrEmpty(txtUsername.Text))
            {
                Mensaje.showWarning("Debe agregar un nombre de usuario");

                return false;
            }
            if (id == null && string.IsNullOrEmpty(txtPassword.Text))
            {
                Mensaje.showWarning("Debe agregar una contraseña");

                return false;
            }
            return true;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;
            }
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int idrol = int.Parse(cmbRol.SelectedValue.ToString());
            if (id == null)
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
            else
            {
                Persona persona = new Persona();
                persona.nombre = nombre;
                persona.apellido = apellido;
                persona.correo = correo;
                persona.telefono = telefono;
                persona.idpersona = id.Value;
                persona.actualizarPersona();
            }
            reiniciar();
            loadData();
        }

        private void reiniciar()
        {
            pnlUserInfo.Visible = true;
            id = null;
            username = null;
            lblId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cmbRol.SelectedIndex = 0;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona.eliminarPersona(id.Value);
            Usuario.eliminarUsuario(username);
            reiniciar();
            loadData();
        }
    }
}
