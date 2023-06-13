using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMD_lab3
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
            Application.Run(new calculateFunctions());
        }
        /// <summary>
        /// Solves the equation based on input patametres
        /// Takes int as it's first parametre. That int decides what f(x) solves as.
        /// </summary>
        static public string SolveEquations(int Funct, double x, double y)
        {
            double answ = 0;
            double Function = 0;
            switch( Funct )
            { 
                case 1:
                    Function = Math.Sinh(x);
                    break;
                case 2:
                    Function = x*x;
                    break;
                case 3:
                    Function = Math.Pow(Math.E,x); 
                    break;
            }

            if (y == 0)
            {
                return "0";
            }
            if (x == 0)
            {
                return Convert.ToString(Math.Pow((Math.Pow(Function,2) + y),3));
            }

            if ((x/y) > 0)
            {
                return Convert.ToString( Math.Log(Function) + Math.Pow((Function*Function) + y, 3));
            }
            if ((x/y) < 0)
            {
                return Convert.ToString(Math.Log(Math.Abs(Function/y))) + Math.Pow((Function+y),3);
            }



            string Answer = Convert.ToString(answ);
            return Answer;
        }

    }
}
