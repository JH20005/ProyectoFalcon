namespace proyectoFalcon.Vistas
{
    partial class StatusSteps
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
            lblStatus10 = new Label();
            lblStatus20 = new Label();
            lblStatus30 = new Label();
            lblStatus40 = new Label();
            pbIconStatus = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbIconStatus).BeginInit();
            SuspendLayout();
            // 
            // lblStatus10
            // 
            lblStatus10.AutoSize = true;
            lblStatus10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus10.Location = new Point(165, 5);
            lblStatus10.Name = "lblStatus10";
            lblStatus10.Size = new Size(0, 25);
            lblStatus10.TabIndex = 0;
            // 
            // lblStatus20
            // 
            lblStatus20.AutoSize = true;
            lblStatus20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus20.Location = new Point(165, 30);
            lblStatus20.Name = "lblStatus20";
            lblStatus20.Size = new Size(0, 25);
            lblStatus20.TabIndex = 1;
            // 
            // lblStatus30
            // 
            lblStatus30.AutoSize = true;
            lblStatus30.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus30.Location = new Point(165, 56);
            lblStatus30.Name = "lblStatus30";
            lblStatus30.Size = new Size(0, 25);
            lblStatus30.TabIndex = 2;
            // 
            // lblStatus40
            // 
            lblStatus40.AutoSize = true;
            lblStatus40.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus40.Location = new Point(165, 83);
            lblStatus40.Name = "lblStatus40";
            lblStatus40.Size = new Size(0, 25);
            lblStatus40.TabIndex = 3;
            // 
            // pbIconStatus
            // 
            pbIconStatus.Location = new Point(8, 5);
            pbIconStatus.Name = "pbIconStatus";
            pbIconStatus.Size = new Size(138, 107);
            pbIconStatus.SizeMode = PictureBoxSizeMode.Zoom;
            pbIconStatus.TabIndex = 4;
            pbIconStatus.TabStop = false;
            // 
            // StatusSteps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pbIconStatus);
            Controls.Add(lblStatus40);
            Controls.Add(lblStatus30);
            Controls.Add(lblStatus20);
            Controls.Add(lblStatus10);
            Name = "StatusSteps";
            Size = new Size(386, 115);
            ((System.ComponentModel.ISupportInitialize)pbIconStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus10;
        private Label lblStatus20;
        private Label lblStatus30;
        private Label lblStatus40;
        private PictureBox pbIconStatus;
    }
}
