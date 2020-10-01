using System;
using System.Windows.Forms;

namespace CToSaM1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = new Presenter(new Form());

            presenter.Run();
        }
    }
}