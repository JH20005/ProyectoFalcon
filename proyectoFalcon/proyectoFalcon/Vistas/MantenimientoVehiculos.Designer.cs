namespace proyectoFalcon.Vistas
{
    partial class MantenimientoVehiculos
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
            btnBack = new Button();
            btnForward = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // gridVehiculos
            // 
            gridVehiculos.ColumnCount = 4;
            gridVehiculos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridVehiculos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridVehiculos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridVehiculos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gridVehiculos.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            gridVehiculos.Location = new Point(19, 12);
            gridVehiculos.Name = "gridVehiculos";
            gridVehiculos.RowCount = 2;
            gridVehiculos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gridVehiculos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gridVehiculos.Size = new Size(758, 540);
            gridVehiculos.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Enabled = false;
            btnBack.FlatAppearance.BorderColor = Color.Green;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.icono_atras;
            btnBack.Location = new Point(350, 558);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(43, 41);
            btnBack.TabIndex = 9;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Visible = false;
            // 
            // btnForward
            // 
            btnForward.BackColor = Color.White;
            btnForward.Cursor = Cursors.Hand;
            btnForward.FlatAppearance.BorderColor = Color.Green;
            btnForward.FlatAppearance.BorderSize = 0;
            btnForward.FlatStyle = FlatStyle.Flat;
            btnForward.Image = Properties.Resources.icono_adelante;
            btnForward.Location = new Point(406, 558);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(43, 41);
            btnForward.TabIndex = 8;
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = Properties.Resources.icono_agregar;
            btnGuardar.Location = new Point(734, 557);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(43, 41);
            btnGuardar.TabIndex = 10;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.MouseEnter += btnGuardar_MouseEnter;
            btnGuardar.MouseLeave += btnGuardar_MouseLeave;
            // 
            // MantenimientoVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnGuardar);
            Controls.Add(btnBack);
            Controls.Add(btnForward);
            Controls.Add(gridVehiculos);
            Name = "MantenimientoVehiculos";
            Size = new Size(794, 603);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel gridVehiculos;
        private Button btnBack;
        private Button btnForward;
        private Button btnGuardar;
    }
}
