namespace proyectoFalcon.Vistas
{
    partial class EnvioCard
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
            lblModelo = new Label();
            lblMarca = new Label();
            lblFecha = new Label();
            lblFechaPago = new Label();
            lblEnvio = new Label();
            btnVerEstado = new Button();
            SuspendLayout();
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblModelo.Location = new Point(27, 62);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(81, 25);
            lblModelo.TabIndex = 9;
            lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarca.Location = new Point(27, 22);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(67, 25);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.Location = new Point(378, 22);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 25);
            lblFecha.TabIndex = 12;
            lblFecha.Text = "Fecha";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaPago.Location = new Point(290, 22);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(61, 25);
            lblFechaPago.TabIndex = 11;
            lblFechaPago.Text = "Fecha";
            // 
            // lblEnvio
            // 
            lblEnvio.AutoSize = true;
            lblEnvio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnvio.Location = new Point(290, 62);
            lblEnvio.Name = "lblEnvio";
            lblEnvio.Size = new Size(81, 25);
            lblEnvio.TabIndex = 13;
            lblEnvio.Text = "Modelo";
            // 
            // btnVerEstado
            // 
            btnVerEstado.BackColor = Color.DodgerBlue;
            btnVerEstado.Cursor = Cursors.Hand;
            btnVerEstado.FlatStyle = FlatStyle.Flat;
            btnVerEstado.ForeColor = Color.White;
            btnVerEstado.Image = Properties.Resources.ver_24;
            btnVerEstado.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerEstado.Location = new Point(622, 28);
            btnVerEstado.Name = "btnVerEstado";
            btnVerEstado.Size = new Size(132, 47);
            btnVerEstado.TabIndex = 14;
            btnVerEstado.Text = "Ver status";
            btnVerEstado.UseVisualStyleBackColor = false;
            btnVerEstado.Click += btnVerEstado_Click;
            // 
            // EnvioCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnVerEstado);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaPago);
            Controls.Add(lblEnvio);
            Name = "EnvioCard";
            Size = new Size(766, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModelo;
        private Label lblMarca;
        private Label lblFecha;
        private Label lblFechaPago;
        private Label lblEnvio;
        private Button btnVerEstado;
    }
}
