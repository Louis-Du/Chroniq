namespace src.Vista
{
    partial class FormLider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLider));
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.nombreEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraIniEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraFinEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnCrear = new MaterialSkin.Controls.MaterialButton();
            this.lblBienv = new MaterialSkin.Controls.MaterialLabel();
            this.lblNomlid = new MaterialSkin.Controls.MaterialLabel();
            this.btnDeshabilitarEvento = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarInvitado = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AllowUserToOrderColumns = true;
            this.dgvEventos.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEvent,
            this.tipoEvent,
            this.fechahoraIniEvent,
            this.fechahoraFinEvent,
            this.creadoPor,
            this._id,
            this.codigoEvent});
            this.dgvEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEventos.Location = new System.Drawing.Point(31, 159);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.Size = new System.Drawing.Size(738, 208);
            this.dgvEventos.TabIndex = 1;
            // 
            // nombreEvent
            // 
            this.nombreEvent.HeaderText = "Nombre ";
            this.nombreEvent.Name = "nombreEvent";
            this.nombreEvent.ReadOnly = true;
            this.nombreEvent.Width = 150;
            // 
            // tipoEvent
            // 
            this.tipoEvent.HeaderText = "Tipo";
            this.tipoEvent.Name = "tipoEvent";
            this.tipoEvent.ReadOnly = true;
            // 
            // fechahoraIniEvent
            // 
            this.fechahoraIniEvent.HeaderText = "Fecha Hora inicio";
            this.fechahoraIniEvent.Name = "fechahoraIniEvent";
            this.fechahoraIniEvent.ReadOnly = true;
            this.fechahoraIniEvent.Width = 150;
            // 
            // fechahoraFinEvent
            // 
            this.fechahoraFinEvent.HeaderText = "Fecha Hora Fin";
            this.fechahoraFinEvent.Name = "fechahoraFinEvent";
            this.fechahoraFinEvent.ReadOnly = true;
            this.fechahoraFinEvent.Width = 150;
            // 
            // creadoPor
            // 
            this.creadoPor.HeaderText = "Creado por";
            this.creadoPor.Name = "creadoPor";
            this.creadoPor.ReadOnly = true;
            this.creadoPor.Width = 150;
            // 
            // _id
            // 
            this._id.HeaderText = "id";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Visible = false;
            // 
            // codigoEvent
            // 
            this.codigoEvent.HeaderText = "codigoEvent";
            this.codigoEvent.Name = "codigoEvent";
            this.codigoEvent.ReadOnly = true;
            this.codigoEvent.Visible = false;
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
            this.btnVolver.Location = new System.Drawing.Point(31, 94);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(215, 409);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(168, 36);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar evento";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCrear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrear.Depth = 0;
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCrear.HighEmphasis = true;
            this.btnCrear.Icon = null;
            this.btnCrear.Location = new System.Drawing.Point(56, 409);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrear.Size = new System.Drawing.Size(127, 36);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear evento";
            this.btnCrear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrear.UseAccentColor = false;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblBienv
            // 
            this.lblBienv.AutoSize = true;
            this.lblBienv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblBienv.Depth = 0;
            this.lblBienv.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBienv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBienv.Location = new System.Drawing.Point(145, 104);
            this.lblBienv.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBienv.Name = "lblBienv";
            this.lblBienv.Size = new System.Drawing.Size(87, 19);
            this.lblBienv.TabIndex = 6;
            this.lblBienv.Text = "Bienvenido: ";
            // 
            // lblNomlid
            // 
            this.lblNomlid.AutoSize = true;
            this.lblNomlid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblNomlid.Depth = 0;
            this.lblNomlid.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNomlid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNomlid.Location = new System.Drawing.Point(258, 104);
            this.lblNomlid.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNomlid.Name = "lblNomlid";
            this.lblNomlid.Size = new System.Drawing.Size(107, 19);
            this.lblNomlid.TabIndex = 7;
            this.lblNomlid.Text = "materialLabel2";
            // 
            // btnDeshabilitarEvento
            // 
            this.btnDeshabilitarEvento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeshabilitarEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeshabilitarEvento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeshabilitarEvento.Depth = 0;
            this.btnDeshabilitarEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeshabilitarEvento.HighEmphasis = true;
            this.btnDeshabilitarEvento.Icon = null;
            this.btnDeshabilitarEvento.Location = new System.Drawing.Point(430, 409);
            this.btnDeshabilitarEvento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeshabilitarEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeshabilitarEvento.Name = "btnDeshabilitarEvento";
            this.btnDeshabilitarEvento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeshabilitarEvento.Size = new System.Drawing.Size(122, 36);
            this.btnDeshabilitarEvento.TabIndex = 8;
            this.btnDeshabilitarEvento.Text = "Deshabilitar";
            this.btnDeshabilitarEvento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeshabilitarEvento.UseAccentColor = false;
            this.btnDeshabilitarEvento.UseVisualStyleBackColor = false;
            this.btnDeshabilitarEvento.Click += new System.EventHandler(this.btnDeshabilitarEvento_Click);
            // 
            // btnAgregarInvitado
            // 
            this.btnAgregarInvitado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarInvitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarInvitado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarInvitado.Depth = 0;
            this.btnAgregarInvitado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarInvitado.HighEmphasis = true;
            this.btnAgregarInvitado.Icon = null;
            this.btnAgregarInvitado.Location = new System.Drawing.Point(574, 409);
            this.btnAgregarInvitado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarInvitado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarInvitado.Name = "btnAgregarInvitado";
            this.btnAgregarInvitado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarInvitado.Size = new System.Drawing.Size(167, 36);
            this.btnAgregarInvitado.TabIndex = 8;
            this.btnAgregarInvitado.Text = "Agregar invitados";
            this.btnAgregarInvitado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarInvitado.UseAccentColor = false;
            this.btnAgregarInvitado.UseVisualStyleBackColor = false;
            this.btnAgregarInvitado.Click += new System.EventHandler(this.btnAgregarInvitado_Click);
            // 
            // FormLider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnDeshabilitarEvento);
            this.Controls.Add(this.btnAgregarInvitado);
            this.Controls.Add(this.lblNomlid);
            this.Controls.Add(this.lblBienv);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvEventos);
            this.Name = "FormLider";
            this.Text = "FormLider";
            this.Load += new System.EventHandler(this.FormLider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEventos;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private MaterialSkin.Controls.MaterialButton btnCrear;
        private MaterialSkin.Controls.MaterialLabel lblBienv;
        private MaterialSkin.Controls.MaterialLabel lblNomlid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahoraIniEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahoraFinEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEvent;

        private MaterialSkin.Controls.MaterialButton btnDeshabilitarEvento;

        private MaterialSkin.Controls.MaterialButton btnAgregarInvitado;

    }
}