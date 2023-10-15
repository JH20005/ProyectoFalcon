using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFalcon.Modelos
{
    public class Menu
    {
        static Dictionary<int, Panel> menus = new Dictionary<int, Panel>();
        public int idmenu {  get; set; }
        public string descripcion { get; set; }

        public static void addMenu(int key, Panel value)
        {
            menus.Add(key, value);
        }

        public static Panel getPanel(int key)
        {
            return menus[key];
        }

        public static void clearMenus()
        {
            menus.Clear();
        }
    }
}
