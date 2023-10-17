namespace proyectoFalcon.Vistas
{
    partial class VehiculoCard
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
            fotoVehiculo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            btnDetalles = new Button();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)fotoVehiculo).BeginInit();
            SuspendLayout();
            // 
            // fotoVehiculo
            // 
            fotoVehiculo.Location = new Point(16, 14);
            fotoVehiculo.Name = "fotoVehiculo";
            fotoVehiculo.Size = new Size(163, 87);
            fotoVehiculo.SizeMode = PictureBoxSizeMode.Zoom;
            fotoVehiculo.TabIndex = 0;
            fotoVehiculo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 116);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 148);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(21, 131);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(158, 18);
            lblMarca.TabIndex = 3;
            // 
            // lblModelo
            // 
            lblModelo.Location = new Point(21, 165);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(158, 18);
            lblModelo.TabIndex = 4;
            lblModelo.Click += label4_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.White;
            btnDetalles.Cursor = Cursors.Hand;
            btnDetalles.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.ForeColor = Color.FromArgb(255, 128, 128);
            btnDetalles.Location = new Point(21, 207);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(158, 33);
            btnDetalles.TabIndex = 5;
            btnDetalles.Text = "Ver detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            btnDetalles.MouseEnter += btnDetalles_MouseEnter;
            btnDetalles.MouseLeave += btnDetalles_MouseLeave;
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(20, 186);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(158, 18);
            lblPrecio.TabIndex = 6;
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VehiculoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrecio);
            Controls.Add(btnDetalles);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fotoVehiculo);
            Name = "VehiculoCard";
            Size = new Size(192, 260);
            ((System.ComponentModel.ISupportInitialize)fotoVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fotoVehiculo;
        private Label label1;
        private Label label2;
        private Label lblMarca;
        private Label lblModelo;
        private Button btnDetalles;
        private Label lblPrecio;
    }
}
