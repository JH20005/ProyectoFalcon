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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            pnlCerrar = new Panel();
            btnCerrarSesion = new Button();
            button1 = new Button();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            pnlCerrar.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(255, 128, 128);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
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
            // panel2
            // 
            panel2.Location = new Point(3, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 38);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 38);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 205);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 38);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 249);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 38);
            panel5.TabIndex = 2;
            // 
            // pnlCerrar
            // 
            pnlCerrar.Controls.Add(btnCerrarSesion);
            pnlCerrar.Controls.Add(button1);
            pnlCerrar.Location = new Point(3, 293);
            pnlCerrar.Name = "pnlCerrar";
            pnlCerrar.Size = new Size(245, 311);
            pnlCerrar.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(255, 128, 128);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = SystemColors.Control;
            btnCerrarSesion.Location = new Point(84, 262);
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
            button1.Location = new Point(11, 262);
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
            pnlCerrar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label lblNombres;
        private Label label1;
        private Label lblRol;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel pnlCerrar;
        private Button button1;
        private Button btnCerrarSesion;
    }
}