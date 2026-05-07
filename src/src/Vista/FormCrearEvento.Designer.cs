namespace src.Vista
{
    partial class FormCrearEvento
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
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNom = new MaterialSkin.Controls.MaterialLabel();
            this.txtFechaini = new MaterialSkin.Controls.MaterialLabel();
            this.txtFechafin = new MaterialSkin.Controls.MaterialLabel();
            this.txtTipo = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.btnCrear = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-5, 526);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(611, 34);
            this.materialDivider2.TabIndex = 2;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(68, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(221, 29);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Creación de eventos";
            // 
            // txtNom
            // 
            this.txtNom.AutoSize = true;
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNom.Depth = 0;
            this.txtNom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNom.Location = new System.Drawing.Point(93, 161);
            this.txtNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(57, 19);
            this.txtNom.TabIndex = 5;
            this.txtNom.Text = "Nombre";
            // 
            // txtFechaini
            // 
            this.txtFechaini.AutoSize = true;
            this.txtFechaini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtFechaini.Depth = 0;
            this.txtFechaini.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFechaini.Location = new System.Drawing.Point(93, 326);
            this.txtFechaini.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechaini.Name = "txtFechaini";
            this.txtFechaini.Size = new System.Drawing.Size(86, 19);
            this.txtFechaini.TabIndex = 6;
            this.txtFechaini.Text = "Fecha Inicio";
            // 
            // txtFechafin
            // 
            this.txtFechafin.AutoSize = true;
            this.txtFechafin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtFechafin.Depth = 0;
            this.txtFechafin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechafin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFechafin.Location = new System.Drawing.Point(93, 382);
            this.txtFechafin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechafin.Name = "txtFechafin";
            this.txtFechafin.Size = new System.Drawing.Size(70, 19);
            this.txtFechafin.TabIndex = 7;
            this.txtFechafin.Text = "Fecha Fin";
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtTipo.Depth = 0;
            this.txtTipo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTipo.Location = new System.Drawing.Point(93, 259);
            this.txtTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(37, 19);
            this.txtTipo.TabIndex = 8;
            this.txtTipo.Text = "Tipo ";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(230, 161);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(211, 50);
            this.materialTextBox2.TabIndex = 10;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(230, 239);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(211, 50);
            this.materialTextBox3.TabIndex = 11;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-5, -4);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(611, 34);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 324);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(230, 378);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackColor = System.Drawing.SystemColors.Control;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-508, 89);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(508, 338);
            this.materialDrawer1.TabIndex = 19;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
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
            this.btnCrear.Location = new System.Drawing.Point(397, 450);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrear.Size = new System.Drawing.Size(67, 36);
            this.btnCrear.TabIndex = 20;
            this.btnCrear.Text = "Crear";
            this.btnCrear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrear.UseAccentColor = false;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
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
            this.btnVolver.Location = new System.Drawing.Point(142, 450);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormCrearEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 557);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialTextBox3);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtFechafin);
            this.Controls.Add(this.txtFechaini);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDrawer1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "FormCrearEvento";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "FormCrearEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel txtNom;
        private MaterialSkin.Controls.MaterialLabel txtFechaini;
        private MaterialSkin.Controls.MaterialLabel txtFechafin;
        private MaterialSkin.Controls.MaterialLabel txtTipo;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialButton btnCrear;
        private MaterialSkin.Controls.MaterialButton btnVolver;
    }
}