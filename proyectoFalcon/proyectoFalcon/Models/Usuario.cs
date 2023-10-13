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

        private string usuario {  get; set; }
        private string contrasenia {  get; set; }

        public static bool validarUsuario(string usuario, string contrasenia)
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();

                string sql = "SELECT usuario, contrasenia FROM usuarios WHERE usuario = @usuario AND contrasenia = @contrasenia";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasenia", contrasenia);

                bool existeUsuario = cmd.ExecuteReader().HasRows;
                ConexionBD.closeConexion();
                return existeUsuario;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

    }
}
