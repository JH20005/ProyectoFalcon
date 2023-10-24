using System.Runtime.CompilerServices;
using proyectoFalcon.Utils;
using proyectoFalcon.Vistas;

namespace proyectoFalcon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                //initConexion();
                Application.Run(new ConexionParametros());
            }
            catch(Exception ex)
            {
                Mensaje.showError("No se puede iniciar la aplicación - " + ex.Message);               
            }

        }

        static void initConexion()
        {
            try
            {
                ConexionBD.setParams();
                ConexionBD.conectarBD();
                ConexionBD.openConexion();              
            }
            catch(Exception ex)
            {
                ConexionParametros cp = new ConexionParametros();
                cp.ShowDialog();
            }
            finally
            {
                ConexionBD.closeConexion();
            }
        }
    }
}