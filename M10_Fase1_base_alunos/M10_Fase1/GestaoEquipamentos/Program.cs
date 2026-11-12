using GestaoEquipamentos.Interface;
using GestaoEquipamentos.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoEquipamentos
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada da aplicação.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
        
    }
}
