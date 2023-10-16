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
            txtPrecio = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
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
            btnGuardar.Location = new Point(209, 479);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 33);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(149, 381);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(190, 78);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 26;
            pbFoto.TabStop = false;
            // 
            // btnAdjuntar
            // 
            btnAdjuntar.BackColor = Color.FromArgb(255, 128, 128);
            btnAdjuntar.Cursor = Cursors.Hand;
            btnAdjuntar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnAdjuntar.FlatAppearance.BorderSize = 0;
            btnAdjuntar.FlatStyle = FlatStyle.Flat;
            btnAdjuntar.ForeColor = Color.White;
            btnAdjuntar.Location = new Point(23, 405);
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
            label6.Location = new Point(23, 381);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 24;
            label6.Text = "Foto";
            // 
            // cmbEstadosVehiculo
            // 
            cmbEstadosVehiculo.FormattingEnabled = true;
            cmbEstadosVehiculo.Location = new Point(149, 327);
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
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(149, 145);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(190, 23);
            txtModelo.TabIndex = 20;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(149, 82);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(190, 23);
            txtMarca.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 325);
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
            btnSalir.BackColor = Color.Silver;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(52, 479);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 33);
            btnSalir.TabIndex = 28;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(149, 266);
            txtPrecio.Mask = "$999,999.00";
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(190, 23);
            txtPrecio.TabIndex = 29;
            // 
            // GuardarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 524);
            Controls.Add(txtPrecio);
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
        private MaskedTextBox txtPrecio;
    }
}