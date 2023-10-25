using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Modelos
{
    public class Dashboard
    {
        public int qvendedores {  get; set; }
        public int qcompradores { get; set; }
        public int qcompras { get; set; }
        public int qenviospais {  get; set; }
        public int qenviosnaviera { get; set; }


        public static Dashboard getEstadisticas()
        {
            Dashboard dashboard = new Dashboard();
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT ");
                query.Append("(select count(username) from usuarios where idrol = 30) as qvendedores, ");
                query.Append("(select count(username) from usuarios where idrol = 20) as qcompradores, ");
                query.Append("(select count(idcompra) from compra) as qcompras, ");
                query.Append("(select count(idenvio) from envio where tipoenvio = 0) as qenviospais, ");
                query.Append("(select count(idenvio) from envio where tipoenvio = 1) as qenviosnaviera ");
                query.Append("FROM dual");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {                 
                    dashboard.qvendedores = int.Parse(reader["qvendedores"].ToString());
                    dashboard.qcompradores = int.Parse(reader["qcompradores"].ToString());
                    dashboard.qcompras = int.Parse(reader["qcompras"].ToString());
                    dashboard.qenviospais = int.Parse(reader["qenviospais"].ToString());
                    dashboard.qenviosnaviera = int.Parse(reader["qenviosnaviera"].ToString());
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
            return dashboard;
        }



    }
}
