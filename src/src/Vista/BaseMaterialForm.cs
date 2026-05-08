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
    // Clase base para todos los formularios del proyecto; agrega fondo decorativo y soporte de tema.
    // Todos los Form heredan de esta clase en lugar de MaterialForm directamente.
    public class BaseMaterialForm : MaterialForm
    {
        // Guarda el bitmap del fondo para reutilizarlo sin regenerarlo en cada repintado.
        private Bitmap _backgroundBitmap;

        public BaseMaterialForm()
        {
            // DoubleBuffered reduce el parpadeo al redibujar la ventana.
            this.DoubleBuffered = true;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);

            // LicenseUsageMode.Designtime evita que el código se ejecute dentro del editor Visual Studio.
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

            UpdateBackgroundBitmap();
        }

        // Alterna entre tema claro y oscuro; puede llamarse desde cualquier formulario hijo.
        public void AlternarTema()
        {
            var manager = MaterialSkinManager.Instance;
            manager.Theme = (manager.Theme == MaterialSkinManager.Themes.LIGHT)
                ? MaterialSkinManager.Themes.DARK
                : MaterialSkinManager.Themes.LIGHT;

            // Regeneramos el bitmap para que use el nuevo BackColor del tema aplicado.
            UpdateBackgroundBitmap();
        }

        // Cuando el formulario cambia de tamaño regeneramos el fondo para que encaje al nuevo tamaño.
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateBackgroundBitmap();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Dejamos que la clase base dibuje BackgroundImage y los controles hijos normalmente.
            base.OnPaint(e);
        }

        // Crea el bitmap de fondo con las figuras decorativas y lo asigna como BackgroundImage.
        private void UpdateBackgroundBitmap()
        {
            // Evitamos generar el bitmap en tiempo de diseño o si el tamaño es inválido.
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            if (this.Width <= 0 || this.Height <= 0) return;

            var bmp = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(this.BackColor);
                DrawBackgroundShapes(g); // Dibujamos los círculos y puntos decorativos.
            }

            // Liberamos el bitmap anterior para evitar fuga de memoria antes de asignar el nuevo.
            var previous = _backgroundBitmap;
            _backgroundBitmap        = bmp;
            this.BackgroundImage     = _backgroundBitmap;
            this.BackgroundImageLayout = ImageLayout.None;
            previous?.Dispose();
        }

        // Libera el bitmap al cerrar el formulario para evitar fuga de memoria.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _backgroundBitmap?.Dispose();

            base.Dispose(disposing);
        }

        // Dibuja las formas decorativas del fondo (círculos semitransparentes + puntos estilo Figma).
        private void DrawBackgroundShapes(Graphics g)
        {
            int w = this.Width;
            int h = this.Height;

            // Color.FromArgb(alpha, r, g, b): el primer argumento es la transparencia (0=invisible, 255=sólido).
            using (Brush brush = new SolidBrush(Color.FromArgb(25, 0, 0, 0)))
                g.FillEllipse(brush, -200, 100, 400, 400); // Círculo izquierda

            using (Brush brush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                g.FillEllipse(brush, w - 300, -100, 350, 350); // Círculo arriba derecha

            using (Brush brush = new SolidBrush(Color.FromArgb(15, 0, 0, 0)))
                g.FillEllipse(brush, w - 400, h - 250, 500, 500); // Círculo abajo derecha

            // Cuadrícula de puntos pequeños en la esquina inferior izquierda.
            using (Brush brush = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
            {
                for (int x = 40; x < 200; x += 20)
                    for (int y = h - 120; y < h - 20; y += 20)
                        g.FillEllipse(brush, x, y, 4, 4);
            }
        }

        // Aplica BackColor = Transparent a todos los Label del formulario (incluye Label hijos anidados).
        private void ApplyTransparentToAllLabels(Control parent)
        {
            if (parent == null) return;

            foreach (Control c in parent.Controls)
            {
                if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) continue;

                if (c is System.Windows.Forms.Label)
                {
                    try { c.BackColor = Color.Transparent; }
                    catch { /* Ignoramos fallos menores para no romper la UI */ }
                }

                // Llamada recursiva para aplicar también a controles dentro de paneles u otros contenedores.
                if (c.HasChildren) ApplyTransparentToAllLabels(c);
            }
        }
    }
}
