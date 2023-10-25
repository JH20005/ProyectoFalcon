namespace proyectoFalcon.Vistas
{
    partial class NuevoUsuario
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
            rdbVendedor = new RadioButton();
            rdbComprador = new RadioButton();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new MaskedTextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rdbVendedor);
            panel1.Controls.Add(rdbComprador);
            panel1.Location = new Point(98, 344);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 27);
            panel1.TabIndex = 49;
            // 
            // rdbVendedor
            // 
            rdbVendedor.AutoSize = true;
            rdbVendedor.Location = new Point(111, 3);
            rdbVendedor.Name = "rdbVendedor";
            rdbVendedor.Size = new Size(75, 19);
            rdbVendedor.TabIndex = 1;
            rdbVendedor.TabStop = true;
            rdbVendedor.Text = "Vendedor";
            rdbVendedor.UseVisualStyleBackColor = true;
            // 
            // rdbComprador
            // 
            rdbComprador.AutoSize = true;
            rdbComprador.Location = new Point(3, 3);
            rdbComprador.Name = "rdbComprador";
            rdbComprador.Size = new Size(86, 19);
            rdbComprador.TabIndex = 0;
            rdbComprador.TabStop = true;
            rdbComprador.Text = "Comprador";
            rdbComprador.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(212, 69);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(86, 25);
            label11.TabIndex = 48;
            label11.Text = "Apellidos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(212, 241);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(79, 25);
            label10.TabIndex = 47;
            label10.Text = "Teléfono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(212, 151);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(72, 25);
            label9.TabIndex = 46;
            label9.Text = "Usuario";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(31, 269);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(156, 23);
            txtCorreo.TabIndex = 43;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(224, 269);
            txtTelefono.Mask = "####-####";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(149, 23);
            txtTelefono.TabIndex = 42;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(224, 97);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(149, 23);
            txtApellido.TabIndex = 41;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(31, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 23);
            txtNombre.TabIndex = 40;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(31, 179);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PasswordChar = '*';
            maskedTextBox1.Size = new Size(156, 23);
            maskedTextBox1.TabIndex = 45;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 241);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 39;
            label4.Text = "Correo";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(13, 393);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(241, 43);
            button2.TabIndex = 38;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 73);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 37;
            label3.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 36;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(115, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 35;
            label1.Text = "CREAR CUENTA";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(277, 393);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(96, 43);
            button1.TabIndex = 50;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(98, 316);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 51;
            label5.Text = "Tipo de cuenta";
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RadioButton rdbVendedor;
        private RadioButton rdbComprador;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtCorreo;
        private MaskedTextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label4;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label5;
    }
}