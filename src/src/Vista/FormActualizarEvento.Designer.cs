namespace src.Vista
{
    partial class FormActualizarEvento
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
            this.dtpFechaHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHoraFin = new System.Windows.Forms.DateTimePicker();
            this.txtTipoEvent = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreEvent = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTipo = new MaterialSkin.Controls.MaterialLabel();
            this.txtFechafin = new MaterialSkin.Controls.MaterialLabel();
            this.txtFechaini = new MaterialSkin.Controls.MaterialLabel();
            this.txtNom = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardarCambio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaHoraInicio
            // 
            this.dtpFechaHoraInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpFechaHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaHoraInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFechaHoraInicio.Location = new System.Drawing.Point(240, 300);
            this.dtpFechaHoraInicio.Name = "dtpFechaHoraInicio";
            this.dtpFechaHoraInicio.Size = new System.Drawing.Size(245, 23);
            this.dtpFechaHoraInicio.TabIndex = 24;
            // 
            // dtpFechaHoraFin
            // 
            this.dtpFechaHoraFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtpFechaHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaHoraFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFechaHoraFin.Location = new System.Drawing.Point(240, 368);
            this.dtpFechaHoraFin.Name = "dtpFechaHoraFin";
            this.dtpFechaHoraFin.Size = new System.Drawing.Size(245, 23);
            this.dtpFechaHoraFin.TabIndex = 23;
            // 
            // txtTipoEvent
            // 
            this.txtTipoEvent.AnimateReadOnly = false;
            this.txtTipoEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtTipoEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoEvent.Depth = 0;
            this.txtTipoEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipoEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTipoEvent.LeadingIcon = null;
            this.txtTipoEvent.Location = new System.Drawing.Point(241, 193);
            this.txtTipoEvent.MaxLength = 50;
            this.txtTipoEvent.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTipoEvent.Multiline = false;
            this.txtTipoEvent.Name = "txtTipoEvent";
            this.txtTipoEvent.Size = new System.Drawing.Size(211, 50);
            this.txtTipoEvent.TabIndex = 22;
            this.txtTipoEvent.Text = "";
            this.txtTipoEvent.TrailingIcon = null;
            // 
            // txtNombreEvent
            // 
            this.txtNombreEvent.AnimateReadOnly = false;
            this.txtNombreEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNombreEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEvent.Depth = 0;
            this.txtNombreEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombreEvent.LeadingIcon = null;
            this.txtNombreEvent.Location = new System.Drawing.Point(241, 127);
            this.txtNombreEvent.MaxLength = 50;
            this.txtNombreEvent.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEvent.Multiline = false;
            this.txtNombreEvent.Name = "txtNombreEvent";
            this.txtNombreEvent.Size = new System.Drawing.Size(211, 50);
            this.txtNombreEvent.TabIndex = 21;
            this.txtNombreEvent.Text = "";
            this.txtNombreEvent.TrailingIcon = null;
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtTipo.Depth = 0;
            this.txtTipo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTipo.Location = new System.Drawing.Point(104, 210);
            this.txtTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(37, 19);
            this.txtTipo.TabIndex = 20;
            this.txtTipo.Text = "Tipo ";
            // 
            // txtFechafin
            // 
            this.txtFechafin.AutoSize = true;
            this.txtFechafin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtFechafin.Depth = 0;
            this.txtFechafin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechafin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFechafin.Location = new System.Drawing.Point(103, 368);
            this.txtFechafin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechafin.Name = "txtFechafin";
            this.txtFechafin.Size = new System.Drawing.Size(70, 19);
            this.txtFechafin.TabIndex = 19;
            this.txtFechafin.Text = "Fecha Fin";
            // 
            // txtFechaini
            // 
            this.txtFechaini.AutoSize = true;
            this.txtFechaini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtFechaini.Depth = 0;
            this.txtFechaini.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFechaini.Location = new System.Drawing.Point(103, 305);
            this.txtFechaini.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechaini.Name = "txtFechaini";
            this.txtFechaini.Size = new System.Drawing.Size(86, 19);
            this.txtFechaini.TabIndex = 18;
            this.txtFechaini.Text = "Fecha Inicio";
            // 
            // txtNom
            // 
            this.txtNom.AutoSize = true;
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNom.Depth = 0;
            this.txtNom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNom.Location = new System.Drawing.Point(104, 145);
            this.txtNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(57, 19);
            this.txtNom.TabIndex = 17;
            this.txtNom.Text = "Nombre";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(205, 47);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(189, 29);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Actualizar Evento";
            // 
            // btnGuardarCambio
            // 
            this.btnGuardarCambio.Location = new System.Drawing.Point(201, 422);
            this.btnGuardarCambio.Name = "btnGuardarCambio";
            this.btnGuardarCambio.Size = new System.Drawing.Size(182, 30);
            this.btnGuardarCambio.TabIndex = 25;
            this.btnGuardarCambio.Text = "Guardar cambios";
            this.btnGuardarCambio.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(201, 461);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(182, 30);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormActualizarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 518);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarCambio);
            this.Controls.Add(this.dtpFechaHoraInicio);
            this.Controls.Add(this.dtpFechaHoraFin);
            this.Controls.Add(this.txtTipoEvent);
            this.Controls.Add(this.txtNombreEvent);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtFechafin);
            this.Controls.Add(this.txtFechaini);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FormActualizarEvento";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraFin;
        private MaterialSkin.Controls.MaterialTextBox txtTipoEvent;
        private MaterialSkin.Controls.MaterialTextBox txtNombreEvent;
        private MaterialSkin.Controls.MaterialLabel txtTipo;
        private MaterialSkin.Controls.MaterialLabel txtFechafin;
        private MaterialSkin.Controls.MaterialLabel txtFechaini;
        private MaterialSkin.Controls.MaterialLabel txtNom;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnGuardarCambio;
        private System.Windows.Forms.Button btnCancelar;
    }
}