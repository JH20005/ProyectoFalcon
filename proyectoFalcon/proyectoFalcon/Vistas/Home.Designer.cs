namespace proyectoFalcon.Vistas
{
    partial class Home
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblqVendedores = new Label();
            lblqCompradores = new Label();
            lblqVehiculosComprados = new Label();
            lblqVehiculosEnviadosPais = new Label();
            lblqVehiculosEnviadosNaviera = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 401);
            label1.Name = "label1";
            label1.Size = new Size(671, 47);
            label1.TabIndex = 0;
            label1.Text = "TRANSPÓRTATE CONMIGO S.A. DE C.V.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FalconIcon;
            pictureBox1.Location = new Point(261, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblqVendedores
            // 
            lblqVendedores.AutoSize = true;
            lblqVendedores.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblqVendedores.ForeColor = Color.White;
            lblqVendedores.Location = new Point(46, 29);
            lblqVendedores.Name = "lblqVendedores";
            lblqVendedores.Size = new Size(56, 45);
            lblqVendedores.TabIndex = 2;
            lblqVendedores.Text = "30";
            // 
            // lblqCompradores
            // 
            lblqCompradores.AutoSize = true;
            lblqCompradores.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblqCompradores.ForeColor = Color.White;
            lblqCompradores.Location = new Point(203, 29);
            lblqCompradores.Name = "lblqCompradores";
            lblqCompradores.Size = new Size(56, 45);
            lblqCompradores.TabIndex = 3;
            lblqCompradores.Text = "30";
            // 
            // lblqVehiculosComprados
            // 
            lblqVehiculosComprados.AutoSize = true;
            lblqVehiculosComprados.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblqVehiculosComprados.ForeColor = Color.White;
            lblqVehiculosComprados.Location = new Point(352, 29);
            lblqVehiculosComprados.Name = "lblqVehiculosComprados";
            lblqVehiculosComprados.Size = new Size(56, 45);
            lblqVehiculosComprados.TabIndex = 4;
            lblqVehiculosComprados.Text = "30";
            // 
            // lblqVehiculosEnviadosPais
            // 
            lblqVehiculosEnviadosPais.AutoSize = true;
            lblqVehiculosEnviadosPais.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblqVehiculosEnviadosPais.ForeColor = Color.White;
            lblqVehiculosEnviadosPais.Location = new Point(494, 29);
            lblqVehiculosEnviadosPais.Name = "lblqVehiculosEnviadosPais";
            lblqVehiculosEnviadosPais.Size = new Size(56, 45);
            lblqVehiculosEnviadosPais.TabIndex = 5;
            lblqVehiculosEnviadosPais.Text = "30";
            // 
            // lblqVehiculosEnviadosNaviera
            // 
            lblqVehiculosEnviadosNaviera.AutoSize = true;
            lblqVehiculosEnviadosNaviera.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblqVehiculosEnviadosNaviera.ForeColor = Color.White;
            lblqVehiculosEnviadosNaviera.Location = new Point(666, 29);
            lblqVehiculosEnviadosNaviera.Name = "lblqVehiculosEnviadosNaviera";
            lblqVehiculosEnviadosNaviera.Size = new Size(56, 45);
            lblqVehiculosEnviadosNaviera.TabIndex = 6;
            lblqVehiculosEnviadosNaviera.Text = "30";
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 74);
            label2.Name = "label2";
            label2.Size = new Size(100, 37);
            label2.TabIndex = 7;
            label2.Text = "Vendedores registrados";
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(203, 74);
            label3.Name = "label3";
            label3.Size = new Size(100, 37);
            label3.TabIndex = 8;
            label3.Text = "Compradores registrados";
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(352, 74);
            label4.Name = "label4";
            label4.Size = new Size(100, 37);
            label4.TabIndex = 9;
            label4.Text = "Vehículos comprados";
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(494, 74);
            label5.Name = "label5";
            label5.Size = new Size(100, 37);
            label5.TabIndex = 10;
            label5.Text = "Vehiculos enviados a país";
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(666, 74);
            label6.Name = "label6";
            label6.Size = new Size(100, 49);
            label6.TabIndex = 11;
            label6.Text = "Vehículos enviados a naviera";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(lblqVendedores);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblqCompradores);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblqVehiculosComprados);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblqVehiculosEnviadosPais);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblqVehiculosEnviadosNaviera);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 463);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 140);
            panel1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(203, 27);
            label7.Name = "label7";
            label7.Size = new Size(384, 47);
            label7.TabIndex = 13;
            label7.Text = "FALCON COMPANY IT";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Home";
            Size = new Size(794, 603);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label lblqVendedores;
        private Label lblqCompradores;
        private Label lblqVehiculosComprados;
        private Label lblqVehiculosEnviadosPais;
        private Label lblqVehiculosEnviadosNaviera;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label7;
    }
}
