namespace proyectoFalcon.Vistas
{
    partial class ConfirmarPago
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
            panel1 = new Panel();
            btnRealizarPago = new Button();
            lblMonto = new Label();
            label5 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            txtNumCuenta = new MaskedTextBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(btnRealizarPago);
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNumCuenta);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 539);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnRealizarPago
            // 
            btnRealizarPago.BackColor = Color.FromArgb(255, 128, 128);
            btnRealizarPago.Cursor = Cursors.Hand;
            btnRealizarPago.DialogResult = DialogResult.OK;
            btnRealizarPago.FlatStyle = FlatStyle.Flat;
            btnRealizarPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRealizarPago.ForeColor = SystemColors.Control;
            btnRealizarPago.Location = new Point(116, 495);
            btnRealizarPago.Margin = new Padding(4, 5, 4, 5);
            btnRealizarPago.Name = "btnRealizarPago";
            btnRealizarPago.Size = new Size(145, 32);
            btnRealizarPago.TabIndex = 10;
            btnRealizarPago.Text = "Realizar pago";
            btnRealizarPago.UseVisualStyleBackColor = false;
            btnRealizarPago.Click += btnRealizarPago_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonto.ForeColor = Color.White;
            lblMonto.Location = new Point(131, 437);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(241, 37);
            lblMonto.TabIndex = 9;
            lblMonto.Text = "CONFIRMAR PAGO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 283);
            label5.Name = "label5";
            label5.Size = new Size(51, 30);
            label5.TabIndex = 8;
            label5.Text = "CCV";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.FromArgb(255, 128, 128);
            maskedTextBox2.BorderStyle = BorderStyle.None;
            maskedTextBox2.ForeColor = Color.White;
            maskedTextBox2.Location = new Point(10, 316);
            maskedTextBox2.Mask = "000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(362, 16);
            maskedTextBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 197);
            label4.Name = "label4";
            label4.Size = new Size(215, 30);
            label4.TabIndex = 6;
            label4.Text = "Fecha de vencimiento";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.FromArgb(255, 128, 128);
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.ForeColor = Color.White;
            maskedTextBox1.Location = new Point(10, 230);
            maskedTextBox1.Mask = "00/00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(362, 16);
            maskedTextBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 109);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 4;
            label3.Text = "Tarjeta";
            label3.Click += label3_Click;
            // 
            // txtNumCuenta
            // 
            txtNumCuenta.BackColor = Color.FromArgb(255, 128, 128);
            txtNumCuenta.BorderStyle = BorderStyle.None;
            txtNumCuenta.ForeColor = Color.White;
            txtNumCuenta.Location = new Point(10, 142);
            txtNumCuenta.Mask = "0000-0000-0000-0000";
            txtNumCuenta.Name = "txtNumCuenta";
            txtNumCuenta.Size = new Size(362, 16);
            txtNumCuenta.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 4);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 395);
            label2.Name = "label2";
            label2.Size = new Size(97, 37);
            label2.TabIndex = 1;
            label2.Text = "Monto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 19);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 0;
            label1.Text = "CONFIRMAR PAGO";
            // 
            // ConfirmarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(386, 543);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmarPago";
            Text = "ConfirmarPago";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private MaskedTextBox txtNumCuenta;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label lblMonto;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Button btnRealizarPago;
    }
}