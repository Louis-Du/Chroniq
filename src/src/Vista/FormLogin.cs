using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin; 

namespace src.Vista
{
    public partial class FormLogin : BaseMaterialForm
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void swtOscuro_CheckedChanged(object sender, EventArgs e)
        {
            AlternarTema();
        }

        private void btnSalirlogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
