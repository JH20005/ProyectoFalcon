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
            pnlMenu = new FlowLayoutPanel();
            pnlInicio = new Panel();
            btnInicio = new Button();
            pnlUsuarios = new Panel();
            btnUsuarios = new Button();
            pnlVehiculos = new Panel();
            btnVehiculos = new Button();
            pnlCompras = new Panel();
            btnCotizar = new Button();
            pnlEnvios = new Panel();
            btnCompras = new Button();
            pnlEnvio = new Panel();
            btnEnvios = new Button();
            pnlMisVehiculos = new Panel();
            pnlCerrar = new Panel();
            btnCerrarSesion = new Button();
            button1 = new Button();
            appPanel = new Panel();
            panel2 = new Panel();
            pnlMisEnvios = new Panel();
            btnMisEnvios = new Button();
            btnMisVehiculos = new Button();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlInicio.SuspendLayout();
            pnlUsuarios.SuspendLayout();
            pnlVehiculos.SuspendLayout();
            pnlCompras.SuspendLayout();
            pnlEnvios.SuspendLayout();
            pnlEnvio.SuspendLayout();
            pnlMisVehiculos.SuspendLayout();
            pnlCerrar.SuspendLayout();
            pnlMisEnvios.SuspendLayout();
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
            pnlMenu.Controls.Add(pnlInicio);
            pnlMenu.Controls.Add(pnlUsuarios);
            pnlMenu.Controls.Add(pnlVehiculos);
            pnlMenu.Controls.Add(pnlCompras);
            pnlMenu.Controls.Add(pnlEnvios);
            pnlMenu.Controls.Add(pnlEnvio);
            pnlMenu.Controls.Add(pnlMisVehiculos);
            pnlMenu.Controls.Add(pnlMisEnvios);
            pnlMenu.Location = new Point(3, 117);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(245, 429);
            pnlMenu.TabIndex = 1;
            // 
            // pnlInicio
            // 
            pnlInicio.Controls.Add(btnInicio);
            pnlInicio.Location = new Point(3, 3);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(245, 48);
            pnlInicio.TabIndex = 0;
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
            btnInicio.Size = new Size(267, 48);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.Controls.Add(btnUsuarios);
            pnlUsuarios.Location = new Point(3, 57);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(245, 48);
            pnlUsuarios.TabIndex = 1;
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
            btnUsuarios.Location = new Point(-6, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(261, 48);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // pnlVehiculos
            // 
            pnlVehiculos.Controls.Add(btnVehiculos);
            pnlVehiculos.Location = new Point(3, 111);
            pnlVehiculos.Name = "pnlVehiculos";
            pnlVehiculos.Size = new Size(245, 48);
            pnlVehiculos.TabIndex = 1;
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
            btnVehiculos.Location = new Point(-6, 0);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(261, 48);
            btnVehiculos.TabIndex = 2;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.TextAlign = ContentAlignment.MiddleLeft;
            btnVehiculos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // pnlCompras
            // 
            pnlCompras.Controls.Add(btnCotizar);
            pnlCompras.Location = new Point(3, 165);
            pnlCompras.Name = "pnlCompras";
            pnlCompras.Size = new Size(245, 48);
            pnlCompras.TabIndex = 1;
            // 
            // btnCotizar
            // 
            btnCotizar.Cursor = Cursors.Hand;
            btnCotizar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnCotizar.FlatStyle = FlatStyle.Flat;
            btnCotizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCotizar.ForeColor = Color.White;
            btnCotizar.Image = Properties.Resources.menu_compras;
            btnCotizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCotizar.Location = new Point(-6, -3);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(267, 48);
            btnCotizar.TabIndex = 3;
            btnCotizar.Text = "Cotizar";
            btnCotizar.TextAlign = ContentAlignment.MiddleLeft;
            btnCotizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCompras_Click;
            // 
            // pnlEnvios
            // 
            pnlEnvios.Controls.Add(btnCompras);
            pnlEnvios.Location = new Point(3, 219);
            pnlEnvios.Name = "pnlEnvios";
            pnlEnvios.Size = new Size(245, 48);
            pnlEnvios.TabIndex = 1;
            // 
            // btnCompras
            // 
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompras.ForeColor = Color.White;
            btnCompras.Image = Properties.Resources.menu_mis_compras;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(-6, -3);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(267, 48);
            btnCompras.TabIndex = 5;
            btnCompras.Text = "Mis compras";
            btnCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click_1;
            // 
            // pnlEnvio
            // 
            pnlEnvio.Controls.Add(btnEnvios);
            pnlEnvio.Location = new Point(3, 273);
            pnlEnvio.Name = "pnlEnvio";
            pnlEnvio.Size = new Size(248, 48);
            pnlEnvio.TabIndex = 1;
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
            btnEnvios.Location = new Point(-6, 3);
            btnEnvios.Name = "btnEnvios";
            btnEnvios.Size = new Size(267, 48);
            btnEnvios.TabIndex = 4;
            btnEnvios.Text = "Mis envios";
            btnEnvios.TextAlign = ContentAlignment.MiddleLeft;
            btnEnvios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEnvios.UseVisualStyleBackColor = true;
            btnEnvios.Click += btnEnvios_Click;
            // 
            // pnlMisVehiculos
            // 
            pnlMisVehiculos.Controls.Add(btnMisVehiculos);
            pnlMisVehiculos.Controls.Add(panel2);
            pnlMisVehiculos.Location = new Point(3, 327);
            pnlMisVehiculos.Name = "pnlMisVehiculos";
            pnlMisVehiculos.Size = new Size(251, 48);
            pnlMisVehiculos.TabIndex = 1;
            // 
            // pnlCerrar
            // 
            pnlCerrar.Controls.Add(btnCerrarSesion);
            pnlCerrar.Controls.Add(button1);
            pnlCerrar.Location = new Point(3, 552);
            pnlCerrar.Name = "pnlCerrar";
            pnlCerrar.Size = new Size(245, 42);
            pnlCerrar.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(255, 128, 128);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = SystemColors.Control;
            btnCerrarSesion.Location = new Point(85, 5);
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
            button1.Location = new Point(12, 5);
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
            // appPanel
            // 
            appPanel.Location = new Point(247, -2);
            appPanel.Name = "appPanel";
            appPanel.Size = new Size(794, 603);
            appPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 48);
            panel2.TabIndex = 2;
            // 
            // pnlMisEnvios
            // 
            pnlMisEnvios.Controls.Add(btnMisEnvios);
            pnlMisEnvios.Location = new Point(3, 381);
            pnlMisEnvios.Name = "pnlMisEnvios";
            pnlMisEnvios.Size = new Size(251, 48);
            pnlMisEnvios.TabIndex = 2;
            // 
            // btnMisEnvios
            // 
            btnMisEnvios.Cursor = Cursors.Hand;
            btnMisEnvios.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnMisEnvios.FlatStyle = FlatStyle.Flat;
            btnMisEnvios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMisEnvios.ForeColor = Color.White;
            btnMisEnvios.Image = Properties.Resources.menu_envios;
            btnMisEnvios.ImageAlign = ContentAlignment.MiddleLeft;
            btnMisEnvios.Location = new Point(-2, 0);
            btnMisEnvios.Name = "btnMisEnvios";
            btnMisEnvios.Size = new Size(267, 48);
            btnMisEnvios.TabIndex = 5;
            btnMisEnvios.Text = "Mis envios";
            btnMisEnvios.TextAlign = ContentAlignment.MiddleLeft;
            btnMisEnvios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMisEnvios.UseVisualStyleBackColor = true;
            // 
            // btnMisVehiculos
            // 
            btnMisVehiculos.Cursor = Cursors.Hand;
            btnMisVehiculos.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnMisVehiculos.FlatStyle = FlatStyle.Flat;
            btnMisVehiculos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMisVehiculos.ForeColor = Color.White;
            btnMisVehiculos.Image = Properties.Resources.menu_vehiculos;
            btnMisVehiculos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMisVehiculos.Location = new Point(-4, 0);
            btnMisVehiculos.Name = "btnMisVehiculos";
            btnMisVehiculos.Size = new Size(261, 48);
            btnMisVehiculos.TabIndex = 3;
            btnMisVehiculos.Text = "Mis vehiculos";
            btnMisVehiculos.TextAlign = ContentAlignment.MiddleLeft;
            btnMisVehiculos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMisVehiculos.UseVisualStyleBackColor = true;
            btnMisVehiculos.Click += btnMisVehiculos_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1041, 599);
            Controls.Add(appPanel);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlInicio.ResumeLayout(false);
            pnlUsuarios.ResumeLayout(false);
            pnlVehiculos.ResumeLayout(false);
            pnlCompras.ResumeLayout(false);
            pnlEnvios.ResumeLayout(false);
            pnlEnvio.ResumeLayout(false);
            pnlMisVehiculos.ResumeLayout(false);
            pnlCerrar.ResumeLayout(false);
            pnlMisEnvios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label lblNombres;
        private Label label1;
        private Label lblRol;
        private Panel pnlCerrar;
        private Button button1;
        private Button btnCerrarSesion;
        private Button btnInicio;
        private Panel pnlMisVehiculos;
        private Panel pnlEnvio;
        private Panel pnlEnvios;
        private Panel pnlCompras;
        private Panel pnlVehiculos;
        private Panel pnlUsuarios;
        private Button btnUsuarios;
        private Panel pnlInicio;
        private Button btnVehiculos;
        private Button button4;
        private Button btnEnvios;
        private Button btnCotizar;
        private FlowLayoutPanel pnlMenu;
        private Panel appPanel;
        private Button btnCompras;
        private Panel panel2;
        private Panel pnlMisEnvios;
        private Button btnMisVehiculos;
        private Button btnMisEnvios;
    }
}