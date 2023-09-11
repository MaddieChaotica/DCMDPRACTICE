using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaCalculi
{
    public class WPracticeLab9
    {
        public string FormulaeCalculation(double x, double y, double z)
        {


            double firstDiv = (Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1 / 3)) / (x * x + y * y + 2);
            double eula = Math.Pow(Math.E, Math.Abs(x - y)) * (Math.Pow((Math.Pow(Math.Tan(z), 2)) + 1, x));

            double Ans = firstDiv - eula;
            string Answer = Convert.ToString(Ans);
            return Answer;
        }
    }
}
