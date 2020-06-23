using AvaliacaoA1;
using AvaliacaoA1.View;
using AvaliacaoA1.View.FiltrosRelatoriosForms;
using AvaliacaoA1.View.RelatoriosForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoA1
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
