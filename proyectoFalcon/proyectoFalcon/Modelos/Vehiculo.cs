using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public byte[] foto { get; set; }
        public int idestado { get; set; }
        public DateTime fechapublicacion { get; set; }
        public decimal precio {  get; set; }

        public static List<Vehiculo> buscarVehiculos(int? idestado)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT v.idvehiculo, v.marca, v.modelo, v.year, v.fechapublicacion, v.precio, v.foto, v.idestado ");
                query.Append("FROM vehiculo v ");
                if (idestado.HasValue)
                {
                    query.Append("WHERE idestado = @idestado");
                }
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                if (idestado.HasValue)
                {
                    cmd.Parameters.AddWithValue("@idestado", idestado.Value);
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
                    vehiculo.foto = (byte[])reader["foto"];
                    vehiculo.idestado = int.Parse(reader["idestado"].ToString());
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
                query.Append("INSERT INTO vehiculo (marca, modelo, year, fechapublicacion, precio, foto, idestado) ");
                query.Append("VALUES (@marca, @modelo, @year, @fechapublicacion, @precio, @foto, @idestado)");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@fechapublicacion", fechapublicacion);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@idestado", idestado);
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
