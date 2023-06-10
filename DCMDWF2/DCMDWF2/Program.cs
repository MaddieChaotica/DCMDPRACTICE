using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMDWF2
{
    internal static class Program
    {
        /// <summary>
        /// The main entrance point of the app.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// The function that calculated the output of the given formula
        /// </summary>
        static public string FormulaeCalculation()
        {
            double x = 4.5;
            double y = 0.75*Math.Pow(10,-4);
            double z = 0.845*Math.Pow(10,2);
            double u = -55.6848;

            double firstDiv = (Math.Pow(8 + Math.Pow(Math.Abs(x-y),2) + 1,1/3)) / (x*x+y*y+2);
            double eula = Math.Pow(Math.E,Math.Abs(x-y)) * (Math.Pow((Math.Pow(Math.Tan(z),2))+1,x));

            double Ans = firstDiv-eula;
            string Answer = Convert.ToString(Ans);
            return Answer;
        }

    }
}
