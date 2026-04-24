using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.Vista
{
    public class BaseMaterialForm : MaterialForm
    {
        public BaseMaterialForm()
        {
            // Configuramos el gestor de temas una sola vez
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo600,
                Primary.Indigo800,
                Primary.Indigo100,
                Accent.Pink200,
                TextShade.WHITE
            );
        }

        public void AlternarTema()
        {
            var manager = MaterialSkinManager.Instance;
            manager.Theme = (manager.Theme == MaterialSkinManager.Themes.LIGHT)
                ? MaterialSkinManager.Themes.DARK
                : MaterialSkinManager.Themes.LIGHT;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCAPTION = 0x02;

            base.WndProc(ref m);

            // Si el usuario hace clic (test de golpe), le decimos que golpeó el "Caption" (Barra de título)
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTCAPTION;
            }
        }
    }
}
