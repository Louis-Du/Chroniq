using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;

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

    }
}
