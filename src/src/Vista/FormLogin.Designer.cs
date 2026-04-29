namespace src.Vista
{
    partial class FormLogin
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
            this.btnIniciarsesion = new MaterialSkin.Controls.MaterialButton();
            this.txtNomuser = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtContraseña = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblNomuser = new MaterialSkin.Controls.MaterialLabel();
            this.lblContraseña = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalirlogin = new MaterialSkin.Controls.MaterialButton();
            this.swtOscuro = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // btnIniciarsesion
            // 
            this.btnIniciarsesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciarsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnIniciarsesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciarsesion.Depth = 0;
            this.btnIniciarsesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIniciarsesion.HighEmphasis = true;
            this.btnIniciarsesion.Icon = null;
            this.btnIniciarsesion.Location = new System.Drawing.Point(351, 346);
            this.btnIniciarsesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIniciarsesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciarsesion.Name = "btnIniciarsesion";
            this.btnIniciarsesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIniciarsesion.Size = new System.Drawing.Size(128, 36);
            this.btnIniciarsesion.TabIndex = 0;
            this.btnIniciarsesion.Text = "Iniciar sesión";
            this.btnIniciarsesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIniciarsesion.UseAccentColor = false;
            this.btnIniciarsesion.UseVisualStyleBackColor = false;
            this.btnIniciarsesion.Click += new System.EventHandler(this.btnIniciarsesion_Click_1);
            // 
            // txtNomuser
            // 
            this.txtNomuser.AnimateReadOnly = false;
            this.txtNomuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNomuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomuser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomuser.Depth = 0;
            this.txtNomuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomuser.HideSelection = true;
            this.txtNomuser.LeadingIcon = null;
            this.txtNomuser.Location = new System.Drawing.Point(301, 130);
            this.txtNomuser.MaxLength = 32767;
            this.txtNomuser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomuser.Name = "txtNomuser";
            this.txtNomuser.PasswordChar = '\0';
            this.txtNomuser.PrefixSuffixText = null;
            this.txtNomuser.ReadOnly = false;
            this.txtNomuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNomuser.SelectedText = "";
            this.txtNomuser.SelectionLength = 0;
            this.txtNomuser.SelectionStart = 0;
            this.txtNomuser.ShortcutsEnabled = true;
            this.txtNomuser.Size = new System.Drawing.Size(250, 48);
            this.txtNomuser.TabIndex = 2;
            this.txtNomuser.TabStop = false;
            this.txtNomuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomuser.TrailingIcon = null;
            this.txtNomuser.UseSystemPasswordChar = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.AnimateReadOnly = false;
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseña.HideSelection = true;
            this.txtContraseña.LeadingIcon = null;
            this.txtContraseña.Location = new System.Drawing.Point(301, 224);
            this.txtContraseña.MaxLength = 32767;
            this.txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.PrefixSuffixText = null;
            this.txtContraseña.ReadOnly = false;
            this.txtContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.ShortcutsEnabled = true;
            this.txtContraseña.Size = new System.Drawing.Size(250, 48);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.TabStop = false;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.TrailingIcon = null;
            this.txtContraseña.UseSystemPasswordChar = false;
            // 
            // lblNomuser
            // 
            this.lblNomuser.AutoSize = true;
            this.lblNomuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblNomuser.Depth = 0;
            this.lblNomuser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNomuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNomuser.Location = new System.Drawing.Point(141, 144);
            this.lblNomuser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNomuser.Name = "lblNomuser";
            this.lblNomuser.Size = new System.Drawing.Size(135, 19);
            this.lblNomuser.TabIndex = 4;
            this.lblNomuser.Text = "Nombre de usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblContraseña.Depth = 0;
            this.lblContraseña.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContraseña.Location = new System.Drawing.Point(194, 235);
            this.lblContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(82, 19);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(253, 46);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(319, 41);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Bienvenido a Chroniq";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(328, 307);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(179, 14);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "¿no te has registrado? entra aquí";
            // 
            // btnSalirlogin
            // 
            this.btnSalirlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSalirlogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnSalirlogin.Depth = 0;
            this.btnSalirlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirlogin.HighEmphasis = true;
            this.btnSalirlogin.Icon = null;
            this.btnSalirlogin.Location = new System.Drawing.Point(683, 390);
            this.btnSalirlogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalirlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirlogin.Name = "btnSalirlogin";
            this.btnSalirlogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalirlogin.Size = new System.Drawing.Size(64, 36);
            this.btnSalirlogin.TabIndex = 8;
            this.btnSalirlogin.Text = "Salir";
            this.btnSalirlogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalirlogin.UseAccentColor = true;
            this.btnSalirlogin.UseVisualStyleBackColor = false;
            this.btnSalirlogin.Click += new System.EventHandler(this.btnSalirlogin_Click);
            // 
            // swtOscuro
            // 
            this.swtOscuro.AutoSize = true;
            this.swtOscuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.swtOscuro.Depth = 0;
            this.swtOscuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.swtOscuro.Location = new System.Drawing.Point(620, 17);
            this.swtOscuro.Margin = new System.Windows.Forms.Padding(0);
            this.swtOscuro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swtOscuro.MouseState = MaterialSkin.MouseState.HOVER;
            this.swtOscuro.Name = "swtOscuro";
            this.swtOscuro.Ripple = true;
            this.swtOscuro.Size = new System.Drawing.Size(153, 37);
            this.swtOscuro.TabIndex = 9;
            this.swtOscuro.Text = "Modo Oscuro";
            this.swtOscuro.UseVisualStyleBackColor = false;
            this.swtOscuro.CheckedChanged += new System.EventHandler(this.swtOscuro_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 606);
            this.Controls.Add(this.swtOscuro);
            this.Controls.Add(this.btnSalirlogin);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNomuser);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNomuser);
            this.Controls.Add(this.btnIniciarsesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "Chroniq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnIniciarsesion;
        private MaterialSkin.Controls.MaterialTextBox2 txtNomuser;
        private MaterialSkin.Controls.MaterialTextBox2 txtContraseña;
        private MaterialSkin.Controls.MaterialLabel lblNomuser;
        private MaterialSkin.Controls.MaterialLabel lblContraseña;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnSalirlogin;
        private MaterialSkin.Controls.MaterialSwitch swtOscuro;
    }
}