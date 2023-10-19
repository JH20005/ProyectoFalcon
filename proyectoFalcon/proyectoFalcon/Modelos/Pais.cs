using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Modelos
{
    public class Pais : Destino
    {

        public static List<Pais> getPaises()
        {
            List<Pais> paises = new List<Pais>();
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();

                StringBuilder query = new StringBuilder();
                query.Append("SELECT tipodestino, iddestino, descripcion ");
                query.Append("FROM destino ");
                query.Append("WHERE tipodestino = @tipodestino");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@tipodestino", 0);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pais pais = new Pais();
                    pais.tipodestino = int.Parse(reader["tipodestino"].ToString());
                    pais.iddestino = int.Parse(reader["iddestino"].ToString());
                    pais.descripcion = reader["descripcion"].ToString();
                    paises.Add(pais);
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
            return paises;
        }

    }
}
