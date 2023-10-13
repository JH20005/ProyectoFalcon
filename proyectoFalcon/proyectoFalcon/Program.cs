using System.Runtime.CompilerServices;
using proyectoFalcon.Utils;

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
                initConexion();
                Application.Run(new Login());
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
                ConexionBD.conectarBD();
                ConexionBD.openConexion();
                
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                ConexionBD.closeConexion();
            }
        }
    }
}