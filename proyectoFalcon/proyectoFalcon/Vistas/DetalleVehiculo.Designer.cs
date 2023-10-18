namespace proyectoFalcon.Vistas
{
    partial class DetalleVehiculo
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
            label7 = new Label();
            btnSalir = new Button();
            btnGuardar = new Button();
            pbFoto = new PictureBox();
            lblPrecio = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            lblVendedor = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(375, 108);
            label7.Name = "label7";
            label7.Size = new Size(115, 30);
            label7.TabIndex = 48;
            label7.Text = "Vendedor:";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkGray;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(399, 162);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 34);
            btnSalir.TabIndex = 47;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 128, 128);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(561, 163);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 33);
            btnGuardar.TabIndex = 46;
            btnGuardar.Text = "Comprar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pbFoto
            // 
            pbFoto.BackColor = Color.Silver;
            pbFoto.Location = new Point(-1, 0);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(355, 214);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 45;
            pbFoto.TabStop = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(375, 78);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(74, 30);
            lblPrecio.TabIndex = 37;
            lblPrecio.Text = "Precio";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblModelo.Location = new Point(375, 48);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(89, 30);
            lblModelo.TabIndex = 35;
            lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarca.Location = new Point(375, 18);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(73, 30);
            lblMarca.TabIndex = 34;
            lblMarca.Text = "Marca";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendedor.ForeColor = Color.White;
            lblVendedor.Location = new Point(507, 108);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(68, 30);
            lblVendedor.TabIndex = 49;
            lblVendedor.Text = "label1";
            // 
            // DetalleVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(677, 214);
            Controls.Add(lblVendedor);
            Controls.Add(label7);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(pbFoto);
            Controls.Add(lblPrecio);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleVehiculo";
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Button btnSalir;
        private Button btnGuardar;
        private PictureBox pbFoto;
        private Label lblPrecio;
        private Label label3;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblVendedor;
    }
}