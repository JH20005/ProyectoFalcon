using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using proyectoFalcon.Vistas;

namespace proyectoFalcon.Utils
{
    internal class Mensaje
    {

        public static void showError(string mensaje)
        {
            //MessageBox.Show(string.Format("Ha ocurrido una excepción: \n{0}", mensaje), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new AppMessage("ERROR", string.Format( "Ha ocurrido una excepción: \n{0}", mensaje), InfoLevel.ERROR).ShowDialog();
        }

        public static void showWarning(string mensaje)
        {
            //MessageBox.Show(string.Format("{0}", mensaje), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            new AppMessage("INFO", string.Format("{0}", mensaje), InfoLevel.WARNING).ShowDialog();
        }
        public static void showInfo(string mensaje)
        {
            //MessageBox.Show(string.Format("{0}", mensaje), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new AppMessage("INFO", string.Format("{0}", mensaje), InfoLevel.INFO).ShowDialog();
        }
    }
}
