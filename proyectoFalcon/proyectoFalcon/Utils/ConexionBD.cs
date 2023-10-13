﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoFalcon.Utils
{
    public class ConexionBD
    {

        private static string server = "127.0.0.1";
        private static string database = "falcon";
        private static string databaseUser = "root";
        private static string databasePassword = "admin";
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

        public static MySqlConnection openConexion()
        {
            conexion.Open();
            return conexion;
        }

        public static void closeConexion()
        {
            conexion.Close();
        }
    }
}
