using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Models;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Modelos
{
    public class Vehiculo
    {
        public int idVehiculo {  get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string year { get; set; }
        public byte[]? foto { get; set; }
        public EstadosVehiculo idestado { get; set; }
        public DateTime fechapublicacion { get; set; }
        public decimal precio {  get; set; }
        public Persona idvendedor { get; set; }

        public Vehiculo()
        {
            idestado = new EstadosVehiculo();
            idvendedor = new Persona();
        }

        public static List<Vehiculo> buscarVehiculos(int? idestado, int? idvendedor)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT v.idvehiculo, v.marca, v.modelo, v.year, v.fechapublicacion, v.precio, v.foto, v.idestado, v.idvendedor ");
                query.Append("FROM vehiculo v ");
                query.Append("WHERE 1=1 ");
                if (idestado.HasValue)
                {
                    query.Append("AND idestado = @idestado");
                }
                if (idvendedor.HasValue)
                {
                    query.Append("AND idvendedor = @idvendedor");
                }
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                if (idestado.HasValue)
                {
                    cmd.Parameters.AddWithValue("@idestado", idestado.Value);
                }
                if (idvendedor.HasValue)
                {
                    cmd.Parameters.AddWithValue("@idvendedor", idvendedor.Value);
                }
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.idVehiculo = int.Parse(reader["idvehiculo"].ToString());
                    vehiculo.marca = reader["marca"].ToString();
                    vehiculo.modelo = reader["modelo"].ToString();
                    vehiculo.year = reader["year"].ToString();
                    vehiculo.fechapublicacion = DateTime.Parse(reader["fechapublicacion"].ToString());
                    vehiculo.precio = Decimal.Parse(reader["precio"].ToString());
                    if (ConexionBD.nonNull(reader, "foto"))
                    {
                        vehiculo.foto = (byte[])reader["foto"];
                    }                   
                    vehiculo.idestado.idestadovehiculo = int.Parse(reader["idestado"].ToString());
                    vehiculo.idvendedor.idpersona = int.Parse(reader["idvendedor"].ToString());
                    vehiculos.Add(vehiculo);
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
            return vehiculos;
        }

        public void guardarVehiculo()
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("INSERT INTO vehiculo (marca, modelo, year, fechapublicacion, precio, foto, idestado, idvendedor) ");
                query.Append("VALUES (@marca, @modelo, @year, @fechapublicacion, @precio, @foto, @idestado, @idvendedor)");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@fechapublicacion", fechapublicacion);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@idestado", idestado.idestadovehiculo);
                cmd.Parameters.AddWithValue("@idvendedor", idvendedor.idpersona);
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


        public void actualizarVehiculo()
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("UPDATE vehiculo ");
                query.Append("SET marca = @marca, ");
                query.Append("modelo = @modelo, ");
                query.Append("year = @year, ");
                query.Append("precio = @precio, ");
                query.Append("idestado = @idestado, ");
                query.Append("idvendedor = @idvendedor ");
                query.Append("WHERE idvehiculo = @idvehiculo");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@fechapublicacion", fechapublicacion);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@idestado", idestado.idestadovehiculo);
                cmd.Parameters.AddWithValue("@idvendedor", idvendedor.idpersona);
                cmd.Parameters.AddWithValue("@idvehiculo", idVehiculo);
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
