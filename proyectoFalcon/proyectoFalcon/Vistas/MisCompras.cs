using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFalcon.Modelos;
using proyectoFalcon.Utils;

namespace proyectoFalcon.Vistas
{
    public partial class MisCompras : UserControl
    {
        public MisCompras()
        {
            InitializeComponent();
            initData();
        }

        public void initData()
        {
            Persona c = Persona.buscarPersona(null, Sesion.getUsuarioLogueado().username);
            lstMisCompras.Controls.Clear();
            Compra.buscarCompras(c.idpersona).ForEach(compra =>
            {
                lstMisCompras.Controls.Add(new CompraCard(compra, this));
            });
        }

    }
}
