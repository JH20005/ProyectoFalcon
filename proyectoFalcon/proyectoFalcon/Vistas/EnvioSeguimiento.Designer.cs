namespace proyectoFalcon.Vistas
{
    partial class EnvioSeguimiento
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
            lstMisEnvios = new FlowLayoutPanel();
            pbFoto = new PictureBox();
            panel1 = new Panel();
            lblVendedor = new Label();
            lblVen = new Label();
            pnlStatus = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // lstMisEnvios
            // 
            lstMisEnvios.Location = new Point(14, 13);
            lstMisEnvios.Name = "lstMisEnvios";
            lstMisEnvios.Size = new Size(766, 438);
            lstMisEnvios.TabIndex = 1;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(14, 470);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(220, 119);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 2;
            pbFoto.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Location = new Point(0, 456);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 5);
            panel1.TabIndex = 3;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVendedor.Location = new Point(240, 504);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(81, 25);
            lblVendedor.TabIndex = 9;
            lblVendedor.Text = "Modelo";
            lblVendedor.Visible = false;
            // 
            // lblVen
            // 
            lblVen.AutoSize = true;
            lblVen.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVen.Location = new Point(267, 470);
            lblVen.Name = "lblVen";
            lblVen.RightToLeft = RightToLeft.No;
            lblVen.Size = new Size(94, 25);
            lblVen.TabIndex = 8;
            lblVen.Text = "Vendedor";
            lblVen.Visible = false;
            // 
            // pnlStatus
            // 
            pnlStatus.Location = new Point(438, 474);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(342, 115);
            pnlStatus.TabIndex = 10;
            // 
            // EnvioSeguimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlStatus);
            Controls.Add(lblVendedor);
            Controls.Add(lblVen);
            Controls.Add(panel1);
            Controls.Add(pbFoto);
            Controls.Add(lstMisEnvios);
            Name = "EnvioSeguimiento";
            Size = new Size(794, 603);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel lstMisEnvios;
        private PictureBox pbFoto;
        private Panel panel1;
        private Label lblVendedor;
        private Label lblVen;
        private Panel pnlStatus;
    }
}
