﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFalcon.Vistas
{
    public partial class AppDialog : Form
    {
        public AppDialog(string message)
        {
            InitializeComponent();
            this.label1.Text = message;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
