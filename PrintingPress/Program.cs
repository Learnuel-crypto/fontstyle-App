using PrintingPress.API.Startups;
using System;
using System.Windows.Forms;
namespace PrintingPress
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadScreenFrm());
        }
    }
}
