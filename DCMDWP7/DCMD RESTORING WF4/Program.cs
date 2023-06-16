using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMDWF4
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
            Application.Run(new GraphBuilder());
        }

        /// <summary>
        /// Function that solves equation for specific value of x, a and by that it gets in it's input values.
        /// </summary>
        public static double equationTabbySolver(double x, double a, double b)
        {
            double y = 0;

            y = 1.2 * Math.Pow((a - b), 3) * Math.Pow(Math.E, Math.Pow(x,2)) + x;

            return Math.Round(y,3);
        }


    }
}
