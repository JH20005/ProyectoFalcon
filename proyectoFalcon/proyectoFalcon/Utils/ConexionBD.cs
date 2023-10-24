using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace proyectoFalcon.Utils
{
    public class ConexionBD
    {

        public static string server;
        private static string database;
        private static string databaseUser;
        private static string databasePassword;//admin
        private static MySqlConnection conexion = new MySqlConnection();

        public static void conectarBD()
        {
            StringBuilder conexionString = new StringBuilder();
            conexionString.AppendFormat("server = {0};", server);
            conexionString.AppendFormat("database = {0};", database);
            conexionString.AppendFormat("Uid = {0};", databaseUser);
            conexionString.AppendFormat("pwd = {0};", databasePassword);
            Console.WriteLine(conexionString.ToString());
            conexion.ConnectionString = conexionString.ToString();
        }

        public static void setParams()
        {
            server = ConfigurationManager.AppSettings["host"];
            database = ConfigurationManager.AppSettings["name"];
            databaseUser = ConfigurationManager.AppSettings["user"];
            databasePassword = ConfigurationManager.AppSettings["pass"];
        }

        public static void setNewParams(string host, string name, string user, string pass)
        {
            server = host;
            database = name;
            databaseUser = user;
            databasePassword = pass;
        }

        public static MySqlConnection openConexion()
        {
            closeConexion();
            conexion.Open();
            return conexion;
        }

        public static void closeConexion()
        {
            if(conexion.State != 0 )
            {
                conexion.Close();
            }
        }


        public static bool nonNull(MySqlDataReader reader, string columnName)
        {
            int col = reader.GetOrdinal(columnName);
            return !reader.IsDBNull(col);
        }

    }
}
