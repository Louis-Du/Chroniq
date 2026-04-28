namespace src.Vista
{
    partial class FormInvitado
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dgInvitEventos = new System.Windows.Forms.DataGridView();
            this.lblBienv = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.nombreEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoevent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahorainiEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahorafinEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvitEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.dgInvitEventos);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 89);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(766, 288);
            this.materialCard1.TabIndex = 0;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(336, 232);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(91, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Ingresar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // dgInvitEventos
            // 
            this.dgInvitEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvitEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEvent,
            this.creadoPor,
            this.tipoevent,
            this.fechahorainiEvent,
            this.fechahorafinEvent});
            this.dgInvitEventos.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgInvitEventos.Location = new System.Drawing.Point(109, 32);
            this.dgInvitEventos.Name = "dgInvitEventos";
            this.dgInvitEventos.Size = new System.Drawing.Size(542, 171);
            this.dgInvitEventos.TabIndex = 0;
            // 
            // lblBienv
            // 
            this.lblBienv.AutoSize = true;
            this.lblBienv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblBienv.Depth = 0;
            this.lblBienv.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBienv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBienv.Location = new System.Drawing.Point(239, 56);
            this.lblBienv.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBienv.Name = "lblBienv";
            this.lblBienv.Size = new System.Drawing.Size(83, 19);
            this.lblBienv.TabIndex = 1;
            this.lblBienv.Text = "Bienvenido:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(350, 56);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(107, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "materialLabel2";
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
            this.btnVolver.Location = new System.Drawing.Point(68, 46);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // nombreEvent
            // 
            this.nombreEvent.HeaderText = "Nombre Evento";
            this.nombreEvent.Name = "nombreEvent";
            // 
            // creadoPor
            // 
            this.creadoPor.HeaderText = "Creado Por";
            this.creadoPor.Name = "creadoPor";
            // 
            // tipoevent
            // 
            this.tipoevent.HeaderText = "Tipo Evento";
            this.tipoevent.Name = "tipoevent";
            // 
            // fechahorainiEvent
            // 
            this.fechahorainiEvent.HeaderText = "Hora Inicio";
            this.fechahorainiEvent.Name = "fechahorainiEvent";
            // 
            // fechahorafinEvent
            // 
            this.fechahorafinEvent.HeaderText = "Hora Fin";
            this.fechahorafinEvent.Name = "fechahorafinEvent";
            // 
            // FormInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lblBienv);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "FormInvitado";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "FormInvitado";
            this.Load += new System.EventHandler(this.FormInvitado_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvitEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblBienv;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgInvitEventos;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoevent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahorainiEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahorafinEvent;
    }
}