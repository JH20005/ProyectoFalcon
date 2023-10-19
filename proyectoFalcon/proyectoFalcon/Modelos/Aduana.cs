using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Modelos
{
    public class Aduana : Destino
    {
        public static List<Aduana> getAduanas()
        {
            List<Aduana> aduanas = new List<Aduana>();
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();

                StringBuilder query = new StringBuilder();
                query.Append("SELECT tipodestino, iddestino, descripcion ");
                query.Append("FROM destino ");
                query.Append("WHERE tipodestino = @tipodestino");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("tipodestino", 1);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Aduana aduana = new Aduana();
                    aduana.tipodestino = int.Parse(reader["tipodestino"].ToString());
                    aduana.iddestino = int.Parse(reader["iddestino"].ToString());
                    aduana.descripcion = reader["descripcion"].ToString();
                    aduanas.Add(aduana);
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
            return aduanas;
        }
    }
}
