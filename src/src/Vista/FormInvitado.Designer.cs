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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvitado));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgInvitEventos = new System.Windows.Forms.DataGridView();
            this.nombreEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoevent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahorainiEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahorafinEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBienv = new MaterialSkin.Controls.MaterialLabel();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvitEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgInvitEventos);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(70, 146);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(640, 232);
            this.materialCard1.TabIndex = 0;
            // 
            // dgInvitEventos
            // 
            this.dgInvitEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgInvitEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvitEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEvent,
            this.creadoPor,
            this.tipoevent,
            this.fechahorainiEvent,
            this.fechahorafinEvent});
            this.dgInvitEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgInvitEventos.Location = new System.Drawing.Point(47, 34);
            this.dgInvitEventos.Name = "dgInvitEventos";
            this.dgInvitEventos.Size = new System.Drawing.Size(542, 171);
            this.dgInvitEventos.TabIndex = 0;
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
            // lblBienv
            // 
            this.lblBienv.AutoSize = true;
            this.lblBienv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblBienv.Depth = 0;
            this.lblBienv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBienv.Location = new System.Drawing.Point(347, 103);
            this.lblBienv.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBienv.Name = "lblBienv";
            this.lblBienv.Size = new System.Drawing.Size(79, 19);
            this.lblBienv.TabIndex = 1;
            this.lblBienv.Text = "Bienvenido";
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
            this.btnVolver.Location = new System.Drawing.Point(53, 103);
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
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblBienv);
            this.Controls.Add(this.materialCard1);
            this.Name = "FormInvitado";
            this.Text = "FormInvitado";
            this.Load += new System.EventHandler(this.FormInvitado_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvitEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblBienv;
        private System.Windows.Forms.DataGridView dgInvitEventos;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoevent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahorainiEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahorafinEvent;
    }
}