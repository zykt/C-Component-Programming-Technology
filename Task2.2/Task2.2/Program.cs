using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Task2._2
{
    public static class Global
    {
        public static Form1 form1;
        public static Form2 form2;
        public static Form3 form3;
        public static Form11 form11;
        public static Form12 form12;
    }

    //interface IScalable
    //{
    //    void 
    //}

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
            Application.Run(new Form1());
        }
    }
}
