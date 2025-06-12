using System.Runtime.CompilerServices;
using System;
using System.Windows.Forms;

namespace Gratuation_project
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
            MainMenu mainMenu = new MainMenu();
            Application.Run(mainMenu);
        }
    }
}