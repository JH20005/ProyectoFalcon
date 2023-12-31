﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyectoFalcon.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proyectoFalcon.Modelos
{
    public class Rol
    {

        public int idrol {  get; set; }
        public string descripcion { get; set; }

        public static List<Rol> getRoles()
        {
            List<Rol> roles = new List<Rol>();
            try
            {
                MySqlConnection conexion = ConexionBD.openConexion();

                StringBuilder query = new StringBuilder();
                query.Append("SELECT idrol, descripcion ");
                query.Append("FROM roles ");
                MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Rol rol = new Rol();
                    rol.idrol = int.Parse(reader["idrol"].ToString());
                    rol.descripcion = reader["descripcion"].ToString();
                    roles.Add(rol);
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
            return roles;
        }
    }
}
