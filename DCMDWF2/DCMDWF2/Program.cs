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
            Numbers numbers = new Numbers();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formula());
        }

        /// <summary>
        /// The function that calculated the output of the given formula
        /// </summary>
        static public string FormulaeCalculation(double x, double y, double z, double u)
        {


            double firstDiv = (Math.Pow(8 + Math.Pow(Math.Abs(x-y),2) + 1,1/3)) / (x*x+y*y+2);
            double eula = Math.Pow(Math.E,Math.Abs(x-y)) * (Math.Pow((Math.Pow(Math.Tan(z),2))+1,x));

            double Ans = firstDiv-eula;
            string Answer = Convert.ToString(Ans);
            return Answer;
        }



    }
}
