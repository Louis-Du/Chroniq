using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;


namespace src.Vista
{
    public class BaseMaterialForm : MaterialForm
    {
        private Bitmap _backgroundBitmap;

        public BaseMaterialForm()
        {
            this.DoubleBuffered = true;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

            // Crear el bitmap inicial
            UpdateBackgroundBitmap();
        }

        public void AlternarTema()
        {
            var manager = MaterialSkinManager.Instance;
            manager.Theme = (manager.Theme == MaterialSkinManager.Themes.LIGHT)
                ? MaterialSkinManager.Themes.DARK
                : MaterialSkinManager.Themes.LIGHT;

            // Regenerar el fondo para que el bitmap use el nuevo BackColor/tema
            UpdateBackgroundBitmap();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateBackgroundBitmap();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Dejamos que el sistema dibuje BackgroundImage + controles hijos
            base.OnPaint(e);
        }

        private void UpdateBackgroundBitmap()
        {
            // No crear durante diseño ni si tamaño inválido
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
            if (this.Width <= 0 || this.Height <= 0)
                return;

            // Crear nuevo bitmap y dibujar las formas en él
            var bmp = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(this.BackColor);
                DrawBackgroundShapes(g);
            }

            // Asignar como BackgroundImage y limpiar el anterior
            var previous = _backgroundBitmap;
            _backgroundBitmap = bmp;
            this.BackgroundImage = _backgroundBitmap;
            this.BackgroundImageLayout = ImageLayout.None;
            previous?.Dispose();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _backgroundBitmap?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void DrawBackgroundShapes(Graphics g)
        {
            int w = this.Width;
            int h = this.Height;

            // 🔘 círculo izquierda (fuera del área de inputs)
            using (Brush brush = new SolidBrush(Color.FromArgb(25, 0, 0, 0)))
            {
                g.FillEllipse(brush, -200, 100, 400, 400);
            }

            // 🔘 círculo arriba derecha
            using (Brush brush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
            {
                g.FillEllipse(brush, w - 300, -100, 350, 350);
            }

            // 🔘 círculo abajo derecha
            using (Brush brush = new SolidBrush(Color.FromArgb(15, 0, 0, 0)))
            {
                g.FillEllipse(brush, w - 400, h - 250, 500, 500);
            }

            // 🔘 puntitos decorativos (tipo Figma)
            using (Brush brush = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
            {
                for (int x = 40; x < 200; x += 20)
                {
                    for (int y = h - 120; y < h - 20; y += 20)
                    {
                        g.FillEllipse(brush, x, y, 4, 4);
                    }
                }
            }
        }

        private void ApplyTransparentToAllLabels(Control parent)
        {
            if (parent == null)
                return;

            foreach (Control c in parent.Controls)
            {
                // Evitar cambios en tiempo de diseño
                if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                    continue;

                // Solo aplicar a Label de WinForms (incluye tu TransparentLabel que herede de System.Windows.Forms.Label)
                if (c is System.Windows.Forms.Label)
                {
                    try
                    {
                        c.BackColor = Color.Transparent;
                    }
                    catch
                    {
                        // Ignoramos fallos menores para no romper la UI en tiempo de ejecución
                    }
                }

                // Recursividad para hijos
                if (c.HasChildren)
                    ApplyTransparentToAllLabels(c);
            }
        }
    }
}

