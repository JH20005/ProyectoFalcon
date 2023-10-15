using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFalcon.Utils
{
    public class Estilos
    {
        static Color primario = Color.FromArgb(255, 128, 128);
        static Color secundario = Color.FromArgb(255, 255, 255);

        public static Color getPrimario()
        {
            return primario;
        }

        public static Color getSecundario()
        {
            return secundario;
        }
    }
}
