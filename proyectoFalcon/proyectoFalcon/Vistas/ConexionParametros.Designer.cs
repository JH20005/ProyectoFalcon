namespace proyectoFalcon.Vistas
{
    partial class ConexionParametros
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
            label1 = new Label();
            txtHost = new TextBox();
            txtbdName = new TextBox();
            label2 = new Label();
            txtUser = new TextBox();
            label3 = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 63);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Host:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(140, 60);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(241, 23);
            txtHost.TabIndex = 1;
            // 
            // txtbdName
            // 
            txtbdName.Location = new Point(140, 106);
            txtbdName.Name = "txtbdName";
            txtbdName.Size = new Size(241, 23);
            txtbdName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 109);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Base de datos:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(140, 149);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(241, 23);
            txtUser.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 152);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Usuario:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(140, 192);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(241, 23);
            txtPass.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 195);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 250);
            button1.Name = "button1";
            button1.Size = new Size(116, 46);
            button1.TabIndex = 8;
            button1.Text = "Probar conexión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(140, 250);
            button2.Name = "button2";
            button2.Size = new Size(116, 46);
            button2.TabIndex = 9;
            button2.Text = "Continuar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(77, 19);
            label5.Name = "label5";
            label5.Size = new Size(229, 25);
            label5.TabIndex = 10;
            label5.Text = "Parámetros de conexión";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(265, 250);
            button3.Name = "button3";
            button3.Size = new Size(116, 46);
            button3.TabIndex = 11;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ConexionParametros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(391, 307);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(txtbdName);
            Controls.Add(label2);
            Controls.Add(txtHost);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConexionParametros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConexionParametros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHost;
        private TextBox txtbdName;
        private Label label2;
        private TextBox txtUser;
        private Label label3;
        private TextBox txtPass;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private Button button3;
    }
}