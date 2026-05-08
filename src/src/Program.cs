using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.Vista;

namespace src
{
    // Clase estática de arranque; contiene el método Main que inicia toda la app.
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Activa los estilos visuales modernos de Windows (botones, barras, etc.).
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // La app comienza en el formulario de Login; todo lo demás se abre desde ahí.
            Application.Run(new FormLogin());
        }
    }
}
