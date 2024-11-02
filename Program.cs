using System;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin()); // Garante que FormLogin está no namespace SistemaFazenda2
        }
    }
}
