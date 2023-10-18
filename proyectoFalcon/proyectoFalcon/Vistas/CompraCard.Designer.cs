namespace proyectoFalcon.Vistas
{
    partial class CompraCard
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
            pbFoto = new PictureBox();
            lblMarca = new Label();
            lblModelo = new Label();
            lblPrecio = new Label();
            label2 = new Label();
            lblFechaPago = new Label();
            pnlFechaPagado = new Panel();
            lblFecha = new Label();
            lblVendedor = new Label();
            btnPagar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            pnlFechaPagado.SuspendLayout();
            SuspendLayout();
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(2, 2);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(194, 95);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 0;
            pbFoto.TabStop = false;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarca.Location = new Point(202, 6);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(67, 25);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblModelo.Location = new Point(202, 37);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(81, 25);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(202, 68);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(68, 25);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(365, 6);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "Vendedor";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaPago.Location = new Point(28, 15);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(61, 25);
            lblFechaPago.TabIndex = 5;
            lblFechaPago.Text = "Fecha";
            // 
            // pnlFechaPagado
            // 
            pnlFechaPagado.Controls.Add(lblFecha);
            pnlFechaPagado.Controls.Add(lblFechaPago);
            pnlFechaPagado.Location = new Point(337, 49);
            pnlFechaPagado.Name = "pnlFechaPagado";
            pnlFechaPagado.Size = new Size(255, 44);
            pnlFechaPagado.TabIndex = 6;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.Location = new Point(128, 15);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 25);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVendedor.Location = new Point(465, 6);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(81, 25);
            lblVendedor.TabIndex = 7;
            lblVendedor.Text = "Modelo";
            // 
            // btnPagar
            // 
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagar.Location = new Point(629, 25);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(134, 55);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "         Proceder a pago";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // CompraCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPagar);
            Controls.Add(lblVendedor);
            Controls.Add(pnlFechaPagado);
            Controls.Add(label2);
            Controls.Add(lblPrecio);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(pbFoto);
            Name = "CompraCard";
            Size = new Size(766, 100);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            pnlFechaPagado.ResumeLayout(false);
            pnlFechaPagado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFoto;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblPrecio;
        private Label label2;
        private Label lblFechaPago;
        private Panel pnlFechaPagado;
        private Label lblFecha;
        private Label lblVendedor;
        private Button btnPagar;
    }
}
