using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoFalcon.Models;

namespace proyectoFalcon.Utils
{
    public class Sesion
    {

        private static Usuario? usuarioLogueado;

        public static void setUsuarioLogueado(Usuario usuario)
        {
            usuarioLogueado = usuario;
        }

        public static Usuario getUsuarioLogueado()
        {
            return usuarioLogueado;
        }
    }
}
