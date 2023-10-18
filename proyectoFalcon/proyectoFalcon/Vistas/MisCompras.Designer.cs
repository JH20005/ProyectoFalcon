namespace proyectoFalcon.Vistas
{
    partial class MisCompras
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
            lstMisCompras = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lstMisCompras
            // 
            lstMisCompras.Location = new Point(13, 11);
            lstMisCompras.Name = "lstMisCompras";
            lstMisCompras.Size = new Size(766, 576);
            lstMisCompras.TabIndex = 0;
            // 
            // MisCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lstMisCompras);
            Name = "MisCompras";
            Size = new Size(794, 603);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel lstMisCompras;
    }
}
