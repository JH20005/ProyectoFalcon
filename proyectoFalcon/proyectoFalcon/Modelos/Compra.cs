using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Modelos
{
    public class Compra
    {
        public int idcompra {  get; set; }
        public Vehiculo vehiculo { get; set; }
        public EstadosCompra estado {  get; set; }
        public Persona comprador {  get; set; }
        public Persona vendedor { get; set; }
        public decimal monto {  get; set; }
        public Pago? pago { get; set; }

        public Compra()
        {
            vehiculo = new Vehiculo();
            estado = new EstadosCompra();
            comprador = new Persona();
            vendedor = new Persona();
        }

        public static List<Compra> buscarCompras(int? idcomprador)
        {
            List<Compra> compras = new List<Compra>();
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT c.idcompra, c.idestado, c.idcomprador, c.monto, v.marca, v.modelo, v.foto, p.nombre, p.apellido, pg.fecha ");
                query.Append("FROM compra c ");
                query.Append("INNER JOIN vehiculo v ");
                query.Append("ON v.idvehiculo = c.idvehiculo ");
                query.Append("INNER JOIN persona p ");
                query.Append("ON p.idpersona = c.idvendedor ");
                query.Append("LEFT JOIN pago pg ");
                query.Append("ON pg.idcompra = c.idcompra ");
                query.Append("WHERE 1=1 ");
                if (idcomprador.HasValue)
                {
                    query.Append("AND c.idcomprador = @idcomprador");
                }
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                if (idcomprador.HasValue)
                {
                    cmd.Parameters.AddWithValue("@idcomprador", idcomprador.Value);
                }
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Compra compra = new Compra();
                    compra.idcompra = int.Parse(reader["idcompra"].ToString());
                    compra.estado.idestadocompra = int.Parse(reader["idestado"].ToString());
                    compra.comprador.idpersona = int.Parse(reader["idcomprador"].ToString());
                    compra.monto = Decimal.Parse(reader["monto"].ToString());
                    compra.vehiculo.marca = reader["marca"].ToString();
                    compra.vehiculo.modelo = reader["modelo"].ToString();
                    if (ConexionBD.nonNull(reader, "foto"))
                    {
                        compra.vehiculo.foto = (byte[])reader["foto"];
                    }
                    compra.vendedor.nombre = reader["nombre"].ToString();
                    compra.vendedor.apellido = reader["apellido"].ToString();
                    if(compra.estado.idestadocompra == 20)
                    {
                        compra.pago = new Pago();
                        compra.pago.fecha = DateTime.Parse(reader["fecha"].ToString());
                    }
                    compras.Add(compra);
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
            return compras;
        }

        public void guardarCompra()
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("INSERT INTO compra (idvehiculo, idestado, idvendedor, idcomprador, monto) ");
                query.Append("VALUES (@idvehiculo, @idestado, @idvendedor, @idcomprador, @monto)");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@idestado", estado.idestadocompra);
                cmd.Parameters.AddWithValue("@idvendedor", vendedor.idpersona);
                cmd.Parameters.AddWithValue("@idvehiculo", vehiculo.idVehiculo);
                cmd.Parameters.AddWithValue("@idcomprador", comprador.idpersona);
                cmd.Parameters.AddWithValue("@monto", monto);
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

        public void actualizarCompra()
        {
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("UPDATE compra ");
                query.Append("SET idestado = @idestado ");
                query.Append("WHERE idcompra = @idcompra");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@idestado", estado.idestadocompra);
                cmd.Parameters.AddWithValue("@idcompra", idcompra);
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
