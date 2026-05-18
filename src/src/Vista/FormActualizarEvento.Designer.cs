namespace src.Vista
{
    partial class FormActualizarEvento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizarEvento));
            this.dtpFechaHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHoraFin    = new System.Windows.Forms.DateTimePicker();
            // Nuevos pickers de hora
            this.tpHoraInicio       = new System.Windows.Forms.DateTimePicker();
            this.tpHoraFin          = new System.Windows.Forms.DateTimePicker();
            this.txtTipoEvent       = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreEvent     = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTipo            = new MaterialSkin.Controls.MaterialLabel();
            this.txtFechafin        = new MaterialSkin.Controls.MaterialLabel();
            this.txtFechaini        = new MaterialSkin.Controls.MaterialLabel();
            this.txtNom             = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1     = new MaterialSkin.Controls.MaterialLabel();
            this.btnAcept           = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel          = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1   = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2   = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();

            // dtpFechaHoraInicio — solo fecha de inicio
            this.dtpFechaHoraInicio.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.dtpFechaHoraInicio.Font      = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaHoraInicio.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.dtpFechaHoraInicio.Format    = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHoraInicio.Location  = new System.Drawing.Point(230, 273);
            this.dtpFechaHoraInicio.Name      = "dtpFechaHoraInicio";
            this.dtpFechaHoraInicio.Size      = new System.Drawing.Size(155, 23);
            this.dtpFechaHoraInicio.TabIndex  = 24;

            // tpHoraInicio — solo hora de inicio
            this.tpHoraInicio.Format      = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpHoraInicio.ShowUpDown  = true;
            this.tpHoraInicio.BackColor   = System.Drawing.Color.FromArgb(242, 242, 242);
            this.tpHoraInicio.Location    = new System.Drawing.Point(395, 273);
            this.tpHoraInicio.Name        = "tpHoraInicio";
            this.tpHoraInicio.Size        = new System.Drawing.Size(80, 23);
            this.tpHoraInicio.TabIndex    = 29;

            // dtpFechaHoraFin — solo fecha de fin
            this.dtpFechaHoraFin.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.dtpFechaHoraFin.Font      = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaHoraFin.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.dtpFechaHoraFin.Format    = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHoraFin.Location  = new System.Drawing.Point(230, 342);
            this.dtpFechaHoraFin.Name      = "dtpFechaHoraFin";
            this.dtpFechaHoraFin.Size      = new System.Drawing.Size(155, 23);
            this.dtpFechaHoraFin.TabIndex  = 23;

            // tpHoraFin — solo hora de fin
            this.tpHoraFin.Format      = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpHoraFin.ShowUpDown  = true;
            this.tpHoraFin.BackColor   = System.Drawing.Color.FromArgb(242, 242, 242);
            this.tpHoraFin.Location    = new System.Drawing.Point(395, 342);
            this.tpHoraFin.Name        = "tpHoraFin";
            this.tpHoraFin.Size        = new System.Drawing.Size(80, 23);
            this.tpHoraFin.TabIndex    = 30;

            // txtTipoEvent
            this.txtTipoEvent.AnimateReadOnly = false;
            this.txtTipoEvent.BackColor       = System.Drawing.Color.FromArgb(242, 242, 242);
            this.txtTipoEvent.BorderStyle     = System.Windows.Forms.BorderStyle.None;
            this.txtTipoEvent.Depth           = 0;
            this.txtTipoEvent.Font            = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipoEvent.ForeColor       = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.txtTipoEvent.LeadingIcon     = null;
            this.txtTipoEvent.Location        = new System.Drawing.Point(230, 178);
            this.txtTipoEvent.MaxLength       = 50;
            this.txtTipoEvent.MouseState      = MaterialSkin.MouseState.OUT;
            this.txtTipoEvent.Multiline       = false;
            this.txtTipoEvent.Name            = "txtTipoEvent";
            this.txtTipoEvent.Size            = new System.Drawing.Size(211, 50);
            this.txtTipoEvent.TabIndex        = 22;
            this.txtTipoEvent.Text            = "";
            this.txtTipoEvent.TrailingIcon    = null;

            // txtNombreEvent
            this.txtNombreEvent.AnimateReadOnly = false;
            this.txtNombreEvent.BackColor       = System.Drawing.Color.FromArgb(242, 242, 242);
            this.txtNombreEvent.BorderStyle     = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEvent.Depth           = 0;
            this.txtNombreEvent.Font            = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEvent.ForeColor       = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.txtNombreEvent.LeadingIcon     = null;
            this.txtNombreEvent.Location        = new System.Drawing.Point(230, 92);
            this.txtNombreEvent.MaxLength       = 50;
            this.txtNombreEvent.MouseState      = MaterialSkin.MouseState.OUT;
            this.txtNombreEvent.Multiline       = false;
            this.txtNombreEvent.Name            = "txtNombreEvent";
            this.txtNombreEvent.Size            = new System.Drawing.Size(211, 50);
            this.txtNombreEvent.TabIndex        = 21;
            this.txtNombreEvent.Text            = "";
            this.txtNombreEvent.TrailingIcon    = null;

            // txtTipo
            this.txtTipo.AutoSize   = true;
            this.txtTipo.BackColor  = System.Drawing.Color.FromArgb(242, 242, 242);
            this.txtTipo.Depth      = 0;
            this.txtTipo.Font       = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipo.ForeColor  = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.txtTipo.Location   = new System.Drawing.Point(93, 209);
            this.txtTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTipo.Name       = "txtTipo";
            this.txtTipo.Size       = new System.Drawing.Size(37, 19);
            this.txtTipo.TabIndex   = 20;
            this.txtTipo.Text       = "Tipo ";

            // txtFechafin — label actualizado
            this.txtFechafin.AutoSize   = true;
            this.txtFechafin.BackColor  = System.Drawing.Color.FromArgb(242, 242, 242);
            this.txtFechafin.Depth      = 0;
            this.txtFechafin.Font       = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechafin.ForeColor  = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.txtFechafin.Location   = new System.Drawing.Point(50, 347);
            this.txtFechafin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechafin.Name       = "txtFechafin";
            this.txtFechafin.Size       = new System.Drawing.Size(115, 19);
            this.txtFechafin.TabIndex   = 19;
            this.txtFechafin.Text       = "Fecha / Hora Fin";

            // txtFechaini — label actualizado
            this.txtFechaini.AutoSize   = true;
            this.txtFechaini.BackColor  = System.Drawing.Color.FromArgb(242, 242, 242);
            this.txtFechaini.Depth      = 0;
            this.txtFechaini.Font       = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaini.ForeColor  = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.txtFechaini.Location   = new System.Drawing.Point(50, 279);
            this.txtFechaini.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechaini.Name       = "txtFechaini";
            this.txtFechaini.Size       = new System.Drawing.Size(130, 19);
            this.txtFechaini.TabIndex   = 18;
            this.txtFechaini.Text       = "Fecha / Hora Inicio";

            // txtNom
            this.txtNom.AutoSize   = true;
            this.txtNom.BackColor  = System.Drawing.Color.FromArgb(242, 242, 242);
            this.txtNom.Depth      = 0;
            this.txtNom.Font       = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNom.ForeColor  = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.txtNom.Location   = new System.Drawing.Point(93, 123);
            this.txtNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNom.Name       = "txtNom";
            this.txtNom.Size       = new System.Drawing.Size(57, 19);
            this.txtNom.TabIndex   = 17;
            this.txtNom.Text       = "Nombre";

            // materialLabel1
            this.materialLabel1.AutoSize   = true;
            this.materialLabel1.BackColor  = System.Drawing.Color.FromArgb(242, 242, 242);
            this.materialLabel1.Depth      = 0;
            this.materialLabel1.Font       = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType   = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor  = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.materialLabel1.Location   = new System.Drawing.Point(208, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name       = "materialLabel1";
            this.materialLabel1.Size       = new System.Drawing.Size(189, 29);
            this.materialLabel1.TabIndex   = 16;
            this.materialLabel1.Text       = "Actualizar Evento";

            // btnAcept
            this.btnAcept.AutoSizeMode          = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcept.Density               = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAcept.Depth                 = 0;
            this.btnAcept.HighEmphasis          = true;
            this.btnAcept.Icon                  = null;
            this.btnAcept.Location              = new System.Drawing.Point(213, 396);
            this.btnAcept.Margin                = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAcept.MouseState            = MaterialSkin.MouseState.HOVER;
            this.btnAcept.Name                  = "btnAcept";
            this.btnAcept.NoAccentTextColor     = System.Drawing.Color.Empty;
            this.btnAcept.Size                  = new System.Drawing.Size(154, 36);
            this.btnAcept.TabIndex              = 25;
            this.btnAcept.Text                  = "Aceptar cambios";
            this.btnAcept.Type                  = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAcept.UseAccentColor        = false;
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);

            // btnCancel
            this.btnCancel.AutoSizeMode          = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density               = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth                 = 0;
            this.btnCancel.HighEmphasis          = true;
            this.btnCancel.Icon                  = null;
            this.btnCancel.Location              = new System.Drawing.Point(213, 444);
            this.btnCancel.Margin                = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState            = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name                  = "btnCancel";
            this.btnCancel.NoAccentTextColor     = System.Drawing.Color.Empty;
            this.btnCancel.Size                  = new System.Drawing.Size(96, 36);
            this.btnCancel.TabIndex              = 26;
            this.btnCancel.Text                  = "Cancelar";
            this.btnCancel.Type                  = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor        = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // materialDivider1
            this.materialDivider1.BackColor  = System.Drawing.Color.FromArgb(30, 0, 0, 0);
            this.materialDivider1.Depth      = 0;
            this.materialDivider1.Location   = new System.Drawing.Point(-17, -6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name       = "materialDivider1";
            this.materialDivider1.Size       = new System.Drawing.Size(611, 34);
            this.materialDivider1.TabIndex   = 27;
            this.materialDivider1.Text       = "materialDivider1";

            // materialDivider2
            this.materialDivider2.BackColor  = System.Drawing.Color.FromArgb(30, 0, 0, 0);
            this.materialDivider2.Depth      = 0;
            this.materialDivider2.Location   = new System.Drawing.Point(-17, 489);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name       = "materialDivider2";
            this.materialDivider2.Size       = new System.Drawing.Size(611, 34);
            this.materialDivider2.TabIndex   = 28;
            this.materialDivider2.Text       = "materialDivider2";

            // FormActualizarEvento
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage     = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize          = new System.Drawing.Size(586, 518);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.tpHoraInicio);
            this.Controls.Add(this.tpHoraFin);
            this.Controls.Add(this.dtpFechaHoraInicio);
            this.Controls.Add(this.dtpFechaHoraFin);
            this.Controls.Add(this.txtTipoEvent);
            this.Controls.Add(this.txtNombreEvent);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtFechafin);
            this.Controls.Add(this.txtFechaini);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name      = "FormActualizarEvento";
            this.Padding   = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text      = "Actualizar Evento";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker   dtpFechaHoraInicio;
        private System.Windows.Forms.DateTimePicker   dtpFechaHoraFin;
        private System.Windows.Forms.DateTimePicker   tpHoraInicio;
        private System.Windows.Forms.DateTimePicker   tpHoraFin;
        private MaterialSkin.Controls.MaterialTextBox txtTipoEvent;
        private MaterialSkin.Controls.MaterialTextBox txtNombreEvent;
        private MaterialSkin.Controls.MaterialLabel   txtTipo;
        private MaterialSkin.Controls.MaterialLabel   txtFechafin;
        private MaterialSkin.Controls.MaterialLabel   txtFechaini;
        private MaterialSkin.Controls.MaterialLabel   txtNom;
        private MaterialSkin.Controls.MaterialLabel   materialLabel1;
        private MaterialSkin.Controls.MaterialButton  btnAcept;
        private MaterialSkin.Controls.MaterialButton  btnCancel;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}
