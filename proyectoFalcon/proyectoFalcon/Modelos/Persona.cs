using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Models;
using proyectoFalcon.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proyectoFalcon.Modelos
{
    public class Persona
    {
        public int idpersona {  get; set; }
        public string nombre { get; set; }
        public string apellido {  get; set; }
        public string correo { get; set; }
        public string telefono {  get; set; }
        public Usuario usuario {  get; set; }

        public static List<Persona> buscarPersonas()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT p.idpersona, p.nombre, p.apellido, p.correo, p.telefono, p.username, r.descripcion ");
                query.Append("FROM persona p ");
                query.Append("INNER JOIN usuarios u ");
                query.Append("ON p.username = u.username ");
                query.Append("INNER JOIN roles r ");
                query.Append("ON u.idrol = r.idrol");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.idpersona = int.Parse(reader["idpersona"].ToString());
                    persona.nombre = reader["nombre"].ToString();
                    persona.apellido = reader["apellido"].ToString();
                    persona.correo = reader["correo"].ToString();
                    persona.telefono = reader["telefono"].ToString();
                    Usuario usuario = new Usuario();
                    usuario.username = reader["username"].ToString();
                    Rol rol = new Rol();
                    rol.descripcion = reader["descripcion"].ToString();
                    usuario.rol = rol;
                    persona.usuario = usuario;
                    personas.Add(persona);
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
            return personas;
        }

        public void guardarPersona()
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("INSERT INTO persona (nombre, apellido, correo, telefono, username) ");
                query.Append("VALUES (@nombre, @apellido, @correo, @telefono, @username)");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@username", usuario.username);
                cmd.ExecuteNonQuery();
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

        public void actualizarPersona()
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("UPDATE persona ");
                query.Append("SET nombre = @nombre, ");
                query.Append("apellido = @apellido, ");
                query.Append("telefono = @telefono, ");
                query.Append("correo = @correo ");
                query.Append("WHERE idpersona = @idpersona");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@idpersona", idpersona);
                cmd.ExecuteNonQuery();
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

        public static void eliminarPersona(int idpersona)
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("DELETE FROM persona ");
                query.Append("WHERE idpersona = @idpersona");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@idpersona", idpersona);
                cmd.ExecuteNonQuery();
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
    }
}
