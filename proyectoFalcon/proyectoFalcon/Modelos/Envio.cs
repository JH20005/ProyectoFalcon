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

        public Envio()
        {
            vehiculo = new Vehiculo();
            vendedor = new Persona();
            comprador = new Persona();
            estado = new EstadosEnvio();
            destino = new Destino();
        }

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

        public static List<Envio> buscarEnvios(int? idcomprador)
        {
            List<Envio> envios = new List<Envio>();
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT e.idenvio, e.tipoenvio, e.fecha, e.idcomprador, v.marca, v.modelo, v.foto, ev.idestadoenvio, ev.descripcion as status, p.nombre, p.apellido, d.descripcion as destino ");
                query.Append("FROM envio e ");
                query.Append("INNER JOIN vehiculo v ");
                query.Append("ON v.idvehiculo = e.idvehiculo ");
                query.Append("INNER JOIN persona p ");
                query.Append("ON p.idpersona = e.idvendedor ");
                query.Append("INNER JOIN estadoenvio ev ");
                query.Append("ON ev.idestadoenvio = e.estado ");
                query.Append("INNER JOIN destino d ");
                query.Append("ON e.iddestino = d.iddestino ");
                query.Append("WHERE 1=1 ");
                if (idcomprador.HasValue)
                {
                    query.Append("AND e.idcomprador = @idcomprador");
                }
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                if (idcomprador.HasValue)
                {
                    cmd.Parameters.AddWithValue("@idcomprador", idcomprador.Value);
                }
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Envio envio = new Envio();
                    envio.idenvio = int.Parse(reader["idenvio"].ToString());
                    envio.tipoenvio = int.Parse(reader["tipoenvio"].ToString());
                    envio.fecha = DateTime.Parse(reader["fecha"].ToString());
                    envio.comprador.idpersona = int.Parse(reader["idcomprador"].ToString());
                    envio.vehiculo.marca = reader["marca"].ToString();
                    envio.vehiculo.modelo = reader["modelo"].ToString();
                    if (ConexionBD.nonNull(reader, "foto"))
                    {
                        envio.vehiculo.foto = (byte[])reader["foto"];
                    }
                    envio.estado.idestadoenvio = int.Parse(reader["idestadoenvio"].ToString());
                    envio.estado.descripcion = reader["status"].ToString();
                    envio.vendedor.nombre = reader["nombre"].ToString();
                    envio.vendedor.apellido = reader["apellido"].ToString();
                    envio.destino.descripcion = reader["destino"].ToString();
                    envios.Add(envio);
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
            return envios;
        }
    }
}
