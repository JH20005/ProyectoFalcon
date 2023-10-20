using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Modelos;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Models
{
    public class Usuario
    {

        public string username {  get; set; }
        public string password {  get; set; }
        public int tipo { get; set; }

        public Rol rol { get; set; }

        public static void validarUsuario(string username, string password)
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();

                StringBuilder query = new StringBuilder();
                query.Append("SELECT u.username, u.password, u.idrol, r.descripcion ");
                query.Append("FROM usuarios u ");
                query.Append("INNER JOIN roles r ");
                query.Append("ON u.idrol = r.idrol ");
                query.Append("WHERE username = @usuario");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@usuario", username);

                MySqlDataReader reader = cmd.ExecuteReader();           
                bool existeUsuario = reader.HasRows;
                bool passwordCorrecto = true;
                if(!existeUsuario)
                {
                    Mensaje.showWarning(String.Format("El usuario {0} no existe", username));
                    ConexionBD.closeConexion();
                    return;
                }
                while (reader.Read()) 
                {
                    if (!reader["password"].ToString().ToUpper().Equals(password.ToUpper()))
                    {
                        Mensaje.showWarning(String.Format("La contraseña no es correcta para el usuario {0}", username));                     
                        passwordCorrecto = false;
                    }
                    if (passwordCorrecto)
                    {
                        Usuario usuario = new Usuario();
                        usuario.rol = new Rol();
                        usuario.username = reader["username"].ToString();
                        usuario.tipo = int.Parse(reader["idrol"].ToString());
                        usuario.rol.idrol = usuario.tipo;
                        usuario.rol.descripcion = reader["descripcion"].ToString();
                        Sesion.setUsuarioLogueado(usuario);
                    }
                }
            }
            catch (Exception e)
            {
                Mensaje.showError(e.Message);
            }
            finally
            {
                ConexionBD.closeConexion();
            }

        }

        public void guardarUsuario()
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("INSERT INTO usuarios (username, password, idrol)");
                query.Append("VALUES (@username, @password, @idrol)");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@idrol", rol.idrol);
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
