using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Modelos
{
    public class Envio
    {
        public int idenvio {  get; set; }
        public Vehiculo vehiculo { get; set; }
        public int tipoenvio {  get; set; }
        public Persona vendedor { get; set; }
        public Persona comprador {  get; set; }
        public DateTime fecha { get; set; }
        public EstadosEnvio estado {  get; set; }
        public Destino destino { get; set; }

        public void guardarEnvio()
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("INSERT INTO envio (idvehiculo, tipoenvio, estado, idvendedor, idcomprador, fecha, iddestino) ");
                query.Append("VALUES (@idvehiculo, @tipoenvio, @estado, @idvendedor, @idcomprador, @fecha, @iddestino)");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@idvehiculo", vehiculo.idVehiculo);
                cmd.Parameters.AddWithValue("@tipoenvio", tipoenvio);
                cmd.Parameters.AddWithValue("@estado", estado.idestadoenvio);
                cmd.Parameters.AddWithValue("@idcomprador", comprador.idpersona);
                cmd.Parameters.AddWithValue("@idvendedor", vendedor.idpersona);
                cmd.Parameters.AddWithValue("@iddestino", destino.iddestino);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
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
