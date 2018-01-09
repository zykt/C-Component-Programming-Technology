using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Task2._1
{
    public static class GlobalForms
    {
        public static IntroForm introForm;
        public static CalcForm calcForm;
    }
    
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IntroForm());
        }
    }
}
