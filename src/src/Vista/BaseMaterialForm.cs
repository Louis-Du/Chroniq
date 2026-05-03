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
        public BaseMaterialForm()
        {
            this.DoubleBuffered = true;

            this.SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);

            {
                if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                {
                    var materialSkinManager = MaterialSkinManager.Instance;

                    materialSkinManager.AddFormToManage(this);
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                }
            }
        }

        public void AlternarTema()
        {
            var manager = MaterialSkinManager.Instance;
            manager.Theme = (manager.Theme == MaterialSkinManager.Themes.LIGHT)
                ? MaterialSkinManager.Themes.DARK
                : MaterialSkinManager.Themes.LIGHT;
        }

        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_NCHITTEST = 0x84;
        //    const int HTCAPTION = 0x02;

        //    base.WndProc(ref m);

        //    // Si el usuario hace clic (test de golpe), le decimos que golpeó el "Caption" (Barra de título)
        //    if (m.Msg == WM_NCHITTEST)
        //    {
        //        m.Result = (IntPtr)HTCAPTION;
        //    }
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            DrawBackgroundShapes(g);
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
    }
}

