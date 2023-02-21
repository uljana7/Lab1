using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лаба1прога;


namespace WindowsFormsApp1
{
    internal static class Program
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
            //Application.Run(new Class1());
            Class1 a = new Class1();
            a.mathoper();

        }
    }

    internal class Class1
    {
        public int a = 3;
        public short b = 2;
        public double[] arr = { 2.6, 45.87, 123.009, -1.65 };
        enum Season : int
        {
            Spring,
            Summer,
            Outumn,
            Winter
        }
        public void mathoper()
        {
            for (int i=0;i<4;i++)
            {
                arr[i] += a;
                arr[i] *= b;
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
