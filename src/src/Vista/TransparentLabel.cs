using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace src.Controls
{
    // Label personalizado que permite ver el fondo detrás de él, útil sobre imágenes o degradados.
    public class TransparentLabel : Label
    {
        public TransparentLabel()
        {
            // SupportsTransparentBackColor permite asignar Color.Transparent a este control.
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Color.Transparent;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                // WS_EX_TRANSPARENT (0x20) hace que Windows pinte los controles de detrás antes que este.
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        // No pintamos el fondo: dejamos visible el control padre que está debajo.
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }
    }
}
