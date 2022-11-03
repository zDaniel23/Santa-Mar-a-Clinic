using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDaniel
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmBienvenida frmBienvenida = new FrmBienvenida();  
            frmBienvenida.ShowDialog();
            /*
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
            */
            Application.Run();
        }
    }
}
