using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Models
{
    public class Usuario
    {

        public string username {  get; set; }
        public string password {  get; set; }
        public int tipo { get; set; }

        public static void validarUsuario(string username, string password)
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();

                string sql = "SELECT username, password, tipo FROM usuarios WHERE username = @usuario";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@usuario", username);
                cmd.Parameters.AddWithValue("@contrasenia", password);
                MySqlDataReader reader = cmd.ExecuteReader();           
                bool existeUsuario = reader.HasRows;
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
                        ConexionBD.closeConexion();
                        return;
                    }
                    Usuario usuario = new Usuario();
                    usuario.username = reader["username"].ToString();
                    usuario.tipo = int.Parse(reader["tipo"].ToString());
                    Sesion.setUsuarioLogueado(usuario);
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
    }
}
