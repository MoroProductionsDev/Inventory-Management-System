using System.Windows.Forms;
using Inventory_Managment_System.View;

namespace Inventory_Managment_System.Controller
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        public static void ShowInitialAppForm()
        {
            Application.OpenForms["MainForm"].Show();
        }

        public static void HideInitialAppForm()
        {
            Application.OpenForms["MainForm"].Hide();
        }
    }
}