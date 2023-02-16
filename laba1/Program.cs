using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    class Class1
    {
        public int a, b, c, n, s;
        public string st;

        public Class1()
        {
            n = 0;
        }

        public void digit()
        {
            a = (n % 1000) / 100;
            b = (n % 100) / 10;
            c = (n % 10);
            if (a > b)
                if (c < a)
                {
                    s = b + c;
                    st = Convert.ToString(b) + "+" + Convert.ToString(c) + "=";
                }
                else
                {
                    s = a + b;
                    st = Convert.ToString(a) + "+" + Convert.ToString(b) + "=";
                }
            else
                if (c < b)
            {
                s = a + c;
                st = Convert.ToString(a) + "+" + Convert.ToString(c) + "=";
            }
            else
            {
                s = a + b;
                st = Convert.ToString(a) + "+" + Convert.ToString(b) + "=";
            }
        }
    }

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
