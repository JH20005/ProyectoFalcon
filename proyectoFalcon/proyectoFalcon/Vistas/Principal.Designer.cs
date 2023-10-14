namespace proyectoFalcon.Vistas
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            lblRol = new Label();
            lblNombres = new Label();
            label1 = new Label();
            pnlMenu = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            btnVehiculos = new Button();
            panel3 = new Panel();
            btnUsuarios = new Button();
            panel2 = new Panel();
            btnInicio = new Button();
            pnlCerrar = new Panel();
            btnCerrarSesion = new Button();
            button1 = new Button();
            btnCompras = new Button();
            btnEnvios = new Button();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            pnlMenu.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pnlCerrar.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(255, 128, 128);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(pnlMenu);
            sidebar.Controls.Add(pnlCerrar);
            sidebar.Location = new Point(-2, -2);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(248, 603);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(lblNombres);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 108);
            panel1.TabIndex = 0;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(84, 82);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol";
            // 
            // lblNombres
            // 
            lblNombres.FlatStyle = FlatStyle.Flat;
            lblNombres.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombres.ForeColor = Color.White;
            lblNombres.Location = new Point(11, 32);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(218, 34);
            lblNombres.TabIndex = 1;
            lblNombres.Text = "Nombre, Apellido";
            lblNombres.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 8);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido/a";
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(panel9);
            pnlMenu.Controls.Add(panel8);
            pnlMenu.Controls.Add(panel7);
            pnlMenu.Controls.Add(panel6);
            pnlMenu.Controls.Add(panel5);
            pnlMenu.Controls.Add(panel4);
            pnlMenu.Controls.Add(panel3);
            pnlMenu.Controls.Add(panel2);
            pnlMenu.Location = new Point(3, 117);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(245, 440);
            pnlMenu.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Location = new Point(0, 360);
            panel9.Name = "panel9";
            panel9.Size = new Size(245, 48);
            panel9.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Location = new Point(0, 312);
            panel8.Name = "panel8";
            panel8.Size = new Size(245, 48);
            panel8.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, 264);
            panel7.Name = "panel7";
            panel7.Size = new Size(245, 48);
            panel7.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnEnvios);
            panel6.Location = new Point(0, 216);
            panel6.Name = "panel6";
            panel6.Size = new Size(245, 48);
            panel6.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnCompras);
            panel5.Location = new Point(0, 162);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 48);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnVehiculos);
            panel4.Location = new Point(0, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 48);
            panel4.TabIndex = 1;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Cursor = Cursors.Hand;
            btnVehiculos.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnVehiculos.FlatStyle = FlatStyle.Flat;
            btnVehiculos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVehiculos.ForeColor = Color.White;
            btnVehiculos.Image = Properties.Resources.menu_vehiculos;
            btnVehiculos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehiculos.Location = new Point(-3, 0);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(261, 48);
            btnVehiculos.TabIndex = 2;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.TextAlign = ContentAlignment.MiddleLeft;
            btnVehiculos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehiculos.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnUsuarios);
            panel3.Location = new Point(0, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 48);
            panel3.TabIndex = 1;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = Properties.Resources.menu_usuarios;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(-3, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(261, 48);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnInicio);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 48);
            panel2.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = Properties.Resources.menu_inicio;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(-3, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(261, 48);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // pnlCerrar
            // 
            pnlCerrar.Controls.Add(btnCerrarSesion);
            pnlCerrar.Controls.Add(button1);
            pnlCerrar.Location = new Point(3, 563);
            pnlCerrar.Name = "pnlCerrar";
            pnlCerrar.Size = new Size(245, 339);
            pnlCerrar.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(255, 128, 128);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = SystemColors.Control;
            btnCerrarSesion.Location = new Point(93, 3);
            btnCerrarSesion.Margin = new Padding(4, 5, 4, 5);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(145, 32);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            btnCerrarSesion.MouseEnter += btnCerrarSesion_MouseEnter;
            btnCerrarSesion.MouseLeave += btnCerrarSesion_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(4, 3);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(62, 32);
            button1.TabIndex = 1;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseMove += button1_MouseMove;
            // 
            // btnCompras
            // 
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompras.ForeColor = Color.White;
            btnCompras.Image = Properties.Resources.menu_compras;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(-3, 0);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(261, 48);
            btnCompras.TabIndex = 3;
            btnCompras.Text = "Compras y cotizaciones";
            btnCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnEnvios
            // 
            btnEnvios.Cursor = Cursors.Hand;
            btnEnvios.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnEnvios.FlatStyle = FlatStyle.Flat;
            btnEnvios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnvios.ForeColor = Color.White;
            btnEnvios.Image = Properties.Resources.menu_envios;
            btnEnvios.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnvios.Location = new Point(-3, -3);
            btnEnvios.Name = "btnEnvios";
            btnEnvios.Size = new Size(261, 48);
            btnEnvios.TabIndex = 4;
            btnEnvios.Text = "Envíos y seguimiento";
            btnEnvios.TextAlign = ContentAlignment.MiddleLeft;
            btnEnvios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEnvios.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 599);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlMenu.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlCerrar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label lblNombres;
        private Label label1;
        private Label lblRol;
        private Panel pnlMenu;
        private Panel pnlCerrar;
        private Button button1;
        private Button btnCerrarSesion;
        private Button btnInicio;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button btnUsuarios;
        private Panel panel2;
        private Button btnVehiculos;
        private Button button4;
        private Button btnEnvios;
        private Button btnCompras;
    }
}