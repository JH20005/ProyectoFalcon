namespace proyectoFalcon.Vistas
{
    partial class GuardarVehiculo
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
            btnGuardar = new Button();
            pbFoto = new PictureBox();
            btnAdjuntar = new Button();
            label6 = new Label();
            cmbEstadosVehiculo = new ComboBox();
            txtYear = new MaskedTextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSalir = new Button();
            label7 = new Label();
            cmbVendedor = new ComboBox();
            label8 = new Label();
            txtPrecio = new TextBox();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 128, 128);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.Enabled = false;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(405, 372);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 33);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pbFoto
            // 
            pbFoto.BackColor = Color.White;
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(531, 227);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(190, 78);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 26;
            pbFoto.TabStop = false;
            pbFoto.LoadCompleted += pbFoto_LoadCompleted;
            // 
            // btnAdjuntar
            // 
            btnAdjuntar.BackColor = Color.Maroon;
            btnAdjuntar.Cursor = Cursors.Hand;
            btnAdjuntar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnAdjuntar.FlatAppearance.BorderSize = 0;
            btnAdjuntar.FlatStyle = FlatStyle.Flat;
            btnAdjuntar.ForeColor = Color.White;
            btnAdjuntar.Location = new Point(405, 251);
            btnAdjuntar.Name = "btnAdjuntar";
            btnAdjuntar.Size = new Size(91, 33);
            btnAdjuntar.TabIndex = 25;
            btnAdjuntar.Text = "Adjuntar";
            btnAdjuntar.UseVisualStyleBackColor = false;
            btnAdjuntar.Click += btnDetalles_Click;
            btnAdjuntar.MouseEnter += btnAdjuntar_MouseEnter;
            btnAdjuntar.MouseLeave += btnAdjuntar_MouseLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(405, 227);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 24;
            label6.Text = "Foto";
            // 
            // cmbEstadosVehiculo
            // 
            cmbEstadosVehiculo.FormattingEnabled = true;
            cmbEstadosVehiculo.Location = new Point(531, 83);
            cmbEstadosVehiculo.Name = "cmbEstadosVehiculo";
            cmbEstadosVehiculo.Size = new Size(190, 23);
            cmbEstadosVehiculo.TabIndex = 23;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(149, 206);
            txtYear.Mask = "####";
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(190, 23);
            txtYear.TabIndex = 21;
            txtYear.MaskInputRejected += txtYear_MaskInputRejected;
            txtYear.TextChanged += txtYear_TextChanged;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(149, 145);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(190, 23);
            txtModelo.TabIndex = 20;
            txtModelo.TextChanged += txtModelo_TextChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(149, 82);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(190, 23);
            txtMarca.TabIndex = 19;
            txtMarca.TextChanged += txtMarca_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(405, 81);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 18;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 264);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 17;
            label5.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 204);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 16;
            label3.Text = "Año";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 143);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 15;
            label2.Text = "Modelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 79);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 14;
            label1.Text = "Marca";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkGray;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(248, 372);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 33);
            btnSalir.TabIndex = 28;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(405, 154);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 30;
            label7.Text = "Vendedor";
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(531, 154);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(190, 23);
            cmbVendedor.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(296, 26);
            label8.Name = "label8";
            label8.Size = new Size(193, 21);
            label8.TabIndex = 32;
            label8.Text = "Guardar nuevo vehículo";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(149, 266);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(190, 23);
            txtPrecio.TabIndex = 33;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(23, 326);
            lblError.Name = "lblError";
            lblError.Size = new Size(698, 30);
            lblError.TabIndex = 34;
            // 
            // GuardarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(760, 417);
            Controls.Add(lblError);
            Controls.Add(txtPrecio);
            Controls.Add(label8);
            Controls.Add(cmbVendedor);
            Controls.Add(label7);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(pbFoto);
            Controls.Add(btnAdjuntar);
            Controls.Add(label6);
            Controls.Add(cmbEstadosVehiculo);
            Controls.Add(txtYear);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuardarVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardarVehiculo2";
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private PictureBox pbFoto;
        private Button btnAdjuntar;
        private Label label6;
        private ComboBox cmbEstadosVehiculo;
        private MaskedTextBox txtYear;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSalir;
        private Label label7;
        private ComboBox cmbVendedor;
        private Label label8;
        private TextBox txtPrecio;
        private Label lblError;
    }
}