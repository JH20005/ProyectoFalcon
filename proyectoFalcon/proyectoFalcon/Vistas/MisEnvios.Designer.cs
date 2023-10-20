namespace proyectoFalcon.Vistas
{
    partial class MisEnvios
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
            pnlStatus = new Panel();
            panel1 = new Panel();
            pbFoto = new PictureBox();
            lstMisEnvios = new FlowLayoutPanel();
            btnActualizarEstado = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // pnlStatus
            // 
            pnlStatus.Location = new Point(256, 474);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(342, 115);
            pnlStatus.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Location = new Point(-2, 456);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 5);
            panel1.TabIndex = 13;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(12, 470);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(220, 119);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 12;
            pbFoto.TabStop = false;
            // 
            // lstMisEnvios
            // 
            lstMisEnvios.Location = new Point(12, 13);
            lstMisEnvios.Name = "lstMisEnvios";
            lstMisEnvios.Size = new Size(766, 438);
            lstMisEnvios.TabIndex = 11;
            // 
            // btnActualizarEstado
            // 
            btnActualizarEstado.BackColor = Color.Blue;
            btnActualizarEstado.Cursor = Cursors.Hand;
            btnActualizarEstado.FlatAppearance.BorderSize = 0;
            btnActualizarEstado.FlatStyle = FlatStyle.Flat;
            btnActualizarEstado.ForeColor = Color.White;
            btnActualizarEstado.Image = Properties.Resources.actualizar_estado;
            btnActualizarEstado.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizarEstado.Location = new Point(628, 514);
            btnActualizarEstado.Name = "btnActualizarEstado";
            btnActualizarEstado.Size = new Size(140, 39);
            btnActualizarEstado.TabIndex = 15;
            btnActualizarEstado.Text = "Actualizar estado";
            btnActualizarEstado.TextAlign = ContentAlignment.MiddleRight;
            btnActualizarEstado.UseVisualStyleBackColor = false;
            btnActualizarEstado.Click += btnActualizarEstado_Click;
            // 
            // MisEnvios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnActualizarEstado);
            Controls.Add(pnlStatus);
            Controls.Add(panel1);
            Controls.Add(pbFoto);
            Controls.Add(lstMisEnvios);
            Name = "MisEnvios";
            Size = new Size(794, 603);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlStatus;
        private Panel panel1;
        private PictureBox pbFoto;
        private FlowLayoutPanel lstMisEnvios;
        private Button btnActualizarEstado;
    }
}
