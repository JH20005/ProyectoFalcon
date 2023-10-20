namespace proyectoFalcon.Vistas
{
    partial class MisVehiculos
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
            gridVehiculos = new TableLayoutPanel();
            SuspendLayout();
            // 
            // gridVehiculos
            // 
            gridVehiculos.AutoScroll = true;
            gridVehiculos.AutoSize = true;
            gridVehiculos.ColumnCount = 4;
            gridVehiculos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridVehiculos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridVehiculos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridVehiculos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridVehiculos.Location = new Point(3, 3);
            gridVehiculos.Name = "gridVehiculos";
            gridVehiculos.RowCount = 2;
            gridVehiculos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gridVehiculos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gridVehiculos.Size = new Size(788, 540);
            gridVehiculos.TabIndex = 1;
            // 
            // MisVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gridVehiculos);
            Name = "MisVehiculos";
            Size = new Size(794, 603);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel gridVehiculos;
    }
}
