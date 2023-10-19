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
            btnComprar = new Button();
            pbFoto = new PictureBox();
            lblPrecio = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            lblVendedor = new Label();
            panel1 = new Panel();
            rdbAduana = new RadioButton();
            rdbPais = new RadioButton();
            rdbComprar = new RadioButton();
            cmbDestino = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            panel1.SuspendLayout();
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
            btnSalir.Location = new Point(373, 242);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 34);
            btnSalir.TabIndex = 47;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(255, 128, 128);
            btnComprar.Cursor = Cursors.Hand;
            btnComprar.DialogResult = DialogResult.OK;
            btnComprar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(571, 242);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(91, 33);
            btnComprar.TabIndex = 46;
            btnComprar.Text = "Continuar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnGuardar_Click;
            // 
            // pbFoto
            // 
            pbFoto.BackColor = Color.Silver;
            pbFoto.Location = new Point(-1, 0);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(355, 289);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
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
            // panel1
            // 
            panel1.Controls.Add(rdbAduana);
            panel1.Controls.Add(rdbPais);
            panel1.Controls.Add(rdbComprar);
            panel1.Location = new Point(373, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 46);
            panel1.TabIndex = 50;
            // 
            // rdbAduana
            // 
            rdbAduana.AutoSize = true;
            rdbAduana.Location = new Point(181, 14);
            rdbAduana.Name = "rdbAduana";
            rdbAduana.Size = new Size(108, 19);
            rdbAduana.TabIndex = 2;
            rdbAduana.TabStop = true;
            rdbAduana.Text = "Enviar a aduana";
            rdbAduana.UseVisualStyleBackColor = true;
            rdbAduana.CheckedChanged += rdbAduana_CheckedChanged;
            // 
            // rdbPais
            // 
            rdbPais.AutoSize = true;
            rdbPais.Location = new Point(85, 14);
            rdbPais.Name = "rdbPais";
            rdbPais.Size = new Size(90, 19);
            rdbPais.TabIndex = 1;
            rdbPais.TabStop = true;
            rdbPais.Text = "Enviar a país";
            rdbPais.UseVisualStyleBackColor = true;
            rdbPais.CheckedChanged += rdbPais_CheckedChanged;
            // 
            // rdbComprar
            // 
            rdbComprar.AutoSize = true;
            rdbComprar.Location = new Point(0, 14);
            rdbComprar.Name = "rdbComprar";
            rdbComprar.Size = new Size(72, 19);
            rdbComprar.TabIndex = 0;
            rdbComprar.TabStop = true;
            rdbComprar.Text = "Comprar";
            rdbComprar.UseVisualStyleBackColor = true;
            rdbComprar.CheckedChanged += rdbComprar_CheckedChanged;
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(373, 155);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(289, 23);
            cmbDestino.TabIndex = 51;
            cmbDestino.Visible = false;
            // 
            // DetalleVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(674, 288);
            Controls.Add(cmbDestino);
            Controls.Add(panel1);
            Controls.Add(lblVendedor);
            Controls.Add(label7);
            Controls.Add(btnSalir);
            Controls.Add(btnComprar);
            Controls.Add(pbFoto);
            Controls.Add(lblPrecio);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleVehiculo";
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Button btnSalir;
        private Button btnComprar;
        private PictureBox pbFoto;
        private Label lblPrecio;
        private Label label3;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblVendedor;
        private Panel panel1;
        private RadioButton rdbAduana;
        private RadioButton rdbPais;
        private RadioButton rdbComprar;
        private ComboBox cmbDestino;
    }
}