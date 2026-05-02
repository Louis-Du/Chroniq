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
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnCrear = new MaterialSkin.Controls.MaterialButton();
            this.lblBienv = new MaterialSkin.Controls.MaterialLabel();
            this.lblNomlid = new MaterialSkin.Controls.MaterialLabel();
            this.nombreEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraIniEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraFinEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.creadoPor});
            this.dgvEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEventos.Location = new System.Drawing.Point(31, 159);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.Size = new System.Drawing.Size(738, 208);
            this.dgvEventos.TabIndex = 1;
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
            this.btnActualizar.Location = new System.Drawing.Point(445, 409);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = false;
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
            this.btnCrear.Location = new System.Drawing.Point(243, 409);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrear.Size = new System.Drawing.Size(67, 36);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear";
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
            // FormLider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
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
    }
}