using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecucion_Nominas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Define un valor para idUsuario
            string idUsuario = "1"; // Reemplaza esto con el valor adecuado
            Application.Run(new Capa_Vista_Nominas.frm_principal_nominas(idUsuario));
        }
    }
}
