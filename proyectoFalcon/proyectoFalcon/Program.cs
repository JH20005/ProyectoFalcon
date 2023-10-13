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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ConexionBD.conectarBD();
            Application.Run(new Login());
        }
    }
}