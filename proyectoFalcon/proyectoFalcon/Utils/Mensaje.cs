using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFalcon.Utils
{
    internal class Mensaje
    {

        public static void showError(string mensaje)
        {
            MessageBox.Show(string.Format("Ha ocurrido una excepción: \n{0}", mensaje), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void showWarning(string mensaje)
        {
            MessageBox.Show(string.Format("{0}", mensaje), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void showInfo(string mensaje)
        {
            MessageBox.Show(string.Format("{0}", mensaje), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
