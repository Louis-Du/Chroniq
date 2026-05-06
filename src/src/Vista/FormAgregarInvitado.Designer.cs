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
            this.dgvInvitados = new System.Windows.Forms.DataGridView();
            this.btnInvitarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.numeroCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvitados
            // 
            this.dgvInvitados.AllowUserToAddRows = false;
            this.dgvInvitados.AllowUserToDeleteRows = false;
            this.dgvInvitados.AllowUserToOrderColumns = true;
            this.dgvInvitados.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvInvitados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvitados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvInvitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroCedula,
            this.nombreUser,
            this.edadUser,
            this.generoUser,
            this.emailUser,
            this.telefonoUser});
            this.dgvInvitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInvitados.Location = new System.Drawing.Point(31, 117);
            this.dgvInvitados.Name = "dgvInvitados";
            this.dgvInvitados.ReadOnly = true;
            this.dgvInvitados.Size = new System.Drawing.Size(738, 208);
            this.dgvInvitados.TabIndex = 2;
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
            // FormAgregarInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnInvitarUsuario);
            this.Controls.Add(this.dgvInvitados);
            this.Name = "FormAgregarInvitado";
            this.Text = "FormAgregarInvitado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvitados;
        private MaterialSkin.Controls.MaterialButton btnInvitarUsuario;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoUser;
    }
}