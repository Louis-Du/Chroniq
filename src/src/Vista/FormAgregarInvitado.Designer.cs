namespace src.Vista
{
    partial class FormAgregarInvitado
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
            this.dgvUsuariosDisponibles = new System.Windows.Forms.DataGridView();
            this.numeroCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInvitarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.dgvInscritos = new System.Windows.Forms.DataGridView();
            this.numeroCedulaInscrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreInscrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadInscrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoInscrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailInscrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoInscrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscritos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuariosDisponibles
            // 
            this.dgvUsuariosDisponibles.AllowUserToAddRows = false;
            this.dgvUsuariosDisponibles.AllowUserToDeleteRows = false;
            this.dgvUsuariosDisponibles.AllowUserToOrderColumns = true;
            this.dgvUsuariosDisponibles.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvUsuariosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuariosDisponibles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvUsuariosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroCedula,
            this.nombreUser,
            this.edadUser,
            this.generoUser,
            this.emailUser,
            this.telefonoUser});
            this.dgvUsuariosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUsuariosDisponibles.Location = new System.Drawing.Point(31, 117);
            this.dgvUsuariosDisponibles.Name = "dgvUsuariosDisponibles";
            this.dgvUsuariosDisponibles.ReadOnly = true;
            this.dgvUsuariosDisponibles.Size = new System.Drawing.Size(313, 208);
            this.dgvUsuariosDisponibles.TabIndex = 2;
            // 
            // numeroCedula
            // 
            this.numeroCedula.HeaderText = "Número cedula";
            this.numeroCedula.Name = "numeroCedula";
            this.numeroCedula.ReadOnly = true;
            // 
            // nombreUser
            // 
            this.nombreUser.HeaderText = "Nombre ";
            this.nombreUser.Name = "nombreUser";
            this.nombreUser.ReadOnly = true;
            this.nombreUser.Width = 150;
            // 
            // edadUser
            // 
            this.edadUser.HeaderText = "Edad";
            this.edadUser.Name = "edadUser";
            this.edadUser.ReadOnly = true;
            this.edadUser.Width = 150;
            // 
            // generoUser
            // 
            this.generoUser.HeaderText = "Genero";
            this.generoUser.Name = "generoUser";
            this.generoUser.ReadOnly = true;
            // 
            // emailUser
            // 
            this.emailUser.HeaderText = "Email";
            this.emailUser.Name = "emailUser";
            this.emailUser.ReadOnly = true;
            this.emailUser.Width = 150;
            // 
            // telefonoUser
            // 
            this.telefonoUser.HeaderText = "Telefono ";
            this.telefonoUser.Name = "telefonoUser";
            this.telefonoUser.ReadOnly = true;
            this.telefonoUser.Width = 150;
            // 
            // btnInvitarUsuario
            // 
            this.btnInvitarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInvitarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnInvitarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInvitarUsuario.Depth = 0;
            this.btnInvitarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInvitarUsuario.HighEmphasis = true;
            this.btnInvitarUsuario.Icon = null;
            this.btnInvitarUsuario.Location = new System.Drawing.Point(128, 334);
            this.btnInvitarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInvitarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInvitarUsuario.Name = "btnInvitarUsuario";
            this.btnInvitarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInvitarUsuario.Size = new System.Drawing.Size(77, 36);
            this.btnInvitarUsuario.TabIndex = 5;
            this.btnInvitarUsuario.Text = "Invitar ";
            this.btnInvitarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInvitarUsuario.UseAccentColor = false;
            this.btnInvitarUsuario.UseVisualStyleBackColor = false;
            this.btnInvitarUsuario.Click += new System.EventHandler(this.btnInvitarUsuario_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(31, 34);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvInscritos
            // 
            this.dgvInscritos.AllowUserToAddRows = false;
            this.dgvInscritos.AllowUserToDeleteRows = false;
            this.dgvInscritos.AllowUserToOrderColumns = true;
            this.dgvInscritos.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvInscritos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInscritos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvInscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroCedulaInscrito,
            this.nombreInscrito,
            this.edadInscrito,
            this.generoInscrito,
            this.emailInscrito,
            this.telefonoInscrito});
            this.dgvInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInscritos.Location = new System.Drawing.Point(402, 117);
            this.dgvInscritos.Name = "dgvInscritos";
            this.dgvInscritos.ReadOnly = true;
            this.dgvInscritos.Size = new System.Drawing.Size(313, 208);
            this.dgvInscritos.TabIndex = 7;
            // 
            // numeroCedulaInscrito
            // 
            this.numeroCedulaInscrito.HeaderText = "Número cedula";
            this.numeroCedulaInscrito.Name = "numeroCedulaInscrito";
            this.numeroCedulaInscrito.ReadOnly = true;
            // 
            // nombreInscrito
            // 
            this.nombreInscrito.HeaderText = "Nombre ";
            this.nombreInscrito.Name = "nombreInscrito";
            this.nombreInscrito.ReadOnly = true;
            this.nombreInscrito.Width = 150;
            // 
            // edadInscrito
            // 
            this.edadInscrito.HeaderText = "Edad";
            this.edadInscrito.Name = "edadInscrito";
            this.edadInscrito.ReadOnly = true;
            this.edadInscrito.Width = 150;
            // 
            // generoInscrito
            // 
            this.generoInscrito.HeaderText = "Genero";
            this.generoInscrito.Name = "generoInscrito";
            this.generoInscrito.ReadOnly = true;
            // 
            // emailInscrito
            // 
            this.emailInscrito.HeaderText = "Email";
            this.emailInscrito.Name = "emailInscrito";
            this.emailInscrito.ReadOnly = true;
            this.emailInscrito.Width = 150;
            // 
            // telefonoInscrito
            // 
            this.telefonoInscrito.HeaderText = "Telefono ";
            this.telefonoInscrito.Name = "telefonoInscrito";
            this.telefonoInscrito.ReadOnly = true;
            this.telefonoInscrito.Width = 150;
            // 
            // FormAgregarInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInscritos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnInvitarUsuario);
            this.Controls.Add(this.dgvUsuariosDisponibles);
            this.Name = "FormAgregarInvitado";
            this.Text = "FormAgregarInvitado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscritos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuariosDisponibles;
        private MaterialSkin.Controls.MaterialButton btnInvitarUsuario;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoUser;
        private System.Windows.Forms.DataGridView dgvInscritos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCedulaInscrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreInscrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadInscrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoInscrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailInscrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoInscrito;
    }
}