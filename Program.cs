using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco;
using Entities;

namespace Banco
{
    internal static class Program //Classes static não podem ser instanciadas ou herdadas
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo. 
        /// </summary>
        [STAThread]
         static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
            
        }
    }
}
