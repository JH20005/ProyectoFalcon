using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Modelos
{
    public class EstadosVehiculo
    {
        public int idestadovehiculo {  get; set; }
        public string descripcion { get; set; }

        public static List<EstadosVehiculo> getEstadosVehiculo()
        {
            List<EstadosVehiculo> estados = new List<EstadosVehiculo>();
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();

                StringBuilder query = new StringBuilder();
                query.Append("SELECT idestadovehiculo, descripcion ");
                query.Append("FROM estadovehiculo ");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EstadosVehiculo estado = new EstadosVehiculo();
                    estado.idestadovehiculo = int.Parse(reader["idestadovehiculo"].ToString());
                    estado.descripcion = reader["descripcion"].ToString();
                    estados.Add(estado);
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
            return estados;
        }
    }
}
