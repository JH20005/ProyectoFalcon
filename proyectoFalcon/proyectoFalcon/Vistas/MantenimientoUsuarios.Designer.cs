namespace proyectoFalcon.Vistas
{
    partial class MantenimientoUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lstUsuarios = new DataGridView();
            pnlUsuario = new Panel();
            pnlUserInfo = new Panel();
            cmbRol = new ComboBox();
            label8 = new Label();
            txtPassword = new MaskedTextBox();
            label7 = new Label();
            txtUsername = new TextBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new MaskedTextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblId = new Label();
            btnReiniciar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)lstUsuarios).BeginInit();
            pnlUsuario.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lstUsuarios
            // 
            lstUsuarios.AllowUserToAddRows = false;
            lstUsuarios.AllowUserToDeleteRows = false;
            lstUsuarios.AllowUserToResizeColumns = false;
            lstUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.NullValue = "-";
            lstUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            lstUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lstUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            lstUsuarios.BackgroundColor = Color.FromArgb(255, 128, 128);
            lstUsuarios.BorderStyle = BorderStyle.None;
            lstUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            lstUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            lstUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            lstUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(1);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            lstUsuarios.DefaultCellStyle = dataGridViewCellStyle6;
            lstUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            lstUsuarios.EnableHeadersVisualStyles = false;
            lstUsuarios.GridColor = Color.White;
            lstUsuarios.Location = new Point(15, 12);
            lstUsuarios.MultiSelect = false;
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            lstUsuarios.RowHeadersVisible = false;
            lstUsuarios.RowTemplate.Height = 25;
            lstUsuarios.ShowCellToolTips = false;
            lstUsuarios.ShowEditingIcon = false;
            lstUsuarios.Size = new Size(761, 373);
            lstUsuarios.TabIndex = 0;
            lstUsuarios.TabStop = false;
            lstUsuarios.CellContentClick += lstUsuarios_CellContentClick;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = Color.WhiteSmoke;
            pnlUsuario.Controls.Add(pnlUserInfo);
            pnlUsuario.Controls.Add(txtCorreo);
            pnlUsuario.Controls.Add(txtTelefono);
            pnlUsuario.Controls.Add(txtApellido);
            pnlUsuario.Controls.Add(txtNombre);
            pnlUsuario.Controls.Add(lblId);
            pnlUsuario.Controls.Add(btnReiniciar);
            pnlUsuario.Controls.Add(btnEliminar);
            pnlUsuario.Controls.Add(btnGuardar);
            pnlUsuario.Controls.Add(label5);
            pnlUsuario.Controls.Add(label4);
            pnlUsuario.Controls.Add(label3);
            pnlUsuario.Controls.Add(label2);
            pnlUsuario.Controls.Add(label1);
            pnlUsuario.Location = new Point(15, 398);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(761, 172);
            pnlUsuario.TabIndex = 1;
            pnlUsuario.Paint += pnlUsuario_Paint;
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.Controls.Add(cmbRol);
            pnlUserInfo.Controls.Add(label8);
            pnlUserInfo.Controls.Add(txtPassword);
            pnlUserInfo.Controls.Add(label7);
            pnlUserInfo.Controls.Add(txtUsername);
            pnlUserInfo.Controls.Add(label6);
            pnlUserInfo.Location = new Point(428, 10);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Size = new Size(269, 159);
            pnlUserInfo.TabIndex = 14;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(43, 114);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(188, 23);
            cmbRol.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(43, 82);
            label8.Name = "label8";
            label8.Size = new Size(35, 21);
            label8.TabIndex = 19;
            label8.Text = "Rol";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(153, 37);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(113, 23);
            txtPassword.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(153, 2);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 16;
            label7.Text = "Contraseña";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(3, 37);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(112, 23);
            txtUsername.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 2);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 15;
            label6.Text = "Usuario";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(270, 126);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(140, 23);
            txtCorreo.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(109, 126);
            txtTelefono.Mask = "####-####";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(138, 23);
            txtTelefono.TabIndex = 12;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(270, 49);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(140, 23);
            txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 23);
            txtNombre.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(39, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 32);
            lblId.TabIndex = 9;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.WhiteSmoke;
            btnReiniciar.Cursor = Cursors.Hand;
            btnReiniciar.FlatAppearance.BorderColor = Color.Green;
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Image = Properties.Resources.icono_reiniciar;
            btnReiniciar.Location = new Point(715, 128);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(43, 41);
            btnReiniciar.TabIndex = 8;
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Enabled = false;
            btnEliminar.FlatAppearance.BorderColor = Color.Green;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = Properties.Resources.icono_eliminar;
            btnEliminar.Location = new Point(715, 63);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(43, 41);
            btnEliminar.TabIndex = 7;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.WhiteSmoke;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = Properties.Resources.icono_guardar;
            btnGuardar.Location = new Point(715, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(43, 41);
            btnGuardar.TabIndex = 6;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 10);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 5;
            label5.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(270, 92);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 4;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(109, 92);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 3;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(270, 10);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 10);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // MantenimientoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlUsuario);
            Controls.Add(lstUsuarios);
            Name = "MantenimientoUsuarios";
            Size = new Size(794, 599);
            ((System.ComponentModel.ISupportInitialize)lstUsuarios).EndInit();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView lstUsuarios;
        private Panel pnlUsuario;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnGuardar;
        private Button btnReiniciar;
        private Button btnEliminar;
        private Label lblId;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private MaskedTextBox txtTelefono;
        private Panel pnlUserInfo;
        private ComboBox cmbRol;
        private Label label8;
        private MaskedTextBox txtPassword;
        private Label label7;
        private TextBox txtUsername;
        private Label label6;
    }
}
