using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFalcon.Properties;

namespace proyectoFalcon.Vistas
{
    public partial class AppMessage : Form
    {

        public AppMessage(string title, string message, InfoLevel level)
        {
            InitializeComponent();
            initValues(title, message, level);
        }

        private void initValues(string title, string message, InfoLevel level)
        {
            this.lblTitle.Text = title;
            this.lblMessage.Text = message;
            switch (level)
            {
                case InfoLevel.INFO:
                    {
                        pbIcon.Image = Resources.infolevel_info;
                        break;
                    }
                case InfoLevel.WARNING:
                    {
                        pbIcon.Image = Resources.infolevel_warning;
                        break;
                    }
                case InfoLevel.ERROR:
                    {
                        pbIcon.Image = Resources.infolevel_error;
                        break;
                    }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public enum InfoLevel
    {
        INFO,
        WARNING,
        ERROR
    }

}
