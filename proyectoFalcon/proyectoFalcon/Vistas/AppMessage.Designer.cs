namespace proyectoFalcon.Vistas
{
    partial class AppMessage
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
            lblTitle = new Label();
            pbIcon = new PictureBox();
            lblMessage = new Label();
            btnAceptar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 33, 31);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 36);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(8, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Click += lblTitle_Click;
            // 
            // pbIcon
            // 
            pbIcon.Location = new Point(5, 40);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(94, 84);
            pbIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            pbIcon.TabIndex = 1;
            pbIcon.TabStop = false;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(109, 40);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(232, 84);
            lblMessage.TabIndex = 2;
            lblMessage.Click += label1_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(255, 128, 128);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 33, 31);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(130, 139);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 38);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // AppMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 186);
            Controls.Add(btnAceptar);
            Controls.Add(lblMessage);
            Controls.Add(pbIcon);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppMessage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AppMessage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbIcon;
        private Label lblMessage;
        private Label lblTitle;
        private Button btnAceptar;
    }
}