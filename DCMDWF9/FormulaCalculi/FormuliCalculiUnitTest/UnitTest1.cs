using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FormulaCalculi;
using System.Security.Cryptography.X509Certificates;

namespace FormuliCalculiUnitTest
{
    [TestClass]
    public class FCompTest
    {
        [TestMethod]
        public void In2ඞ2ඞ2_Outneg33point13()
        {
            //Input values
            double x = 2;
            double y = 2;
            double z = 2;

            //Real answer
            double Expected = -33.13;

            //Method's returned value
            WPracticeLab9 Tester = new WPracticeLab9();
            String RetStr = Tester.FormulaeCalculation(x, y, z);
            double RetVal = Math.Round(Convert.ToDouble(RetStr), 2);

            Assert.AreEqual(Expected, RetVal,0.3);
        }
        [TestMethod]
        public void In1ඞ1ඞ1_Outneg2point90()
        {
            //Input values
            double x = 1;
            double y = 1;
            double z = 1;

            //Real answer
            double Expected = -2.90;

            //Method's returned value
            WPracticeLab9 Tester = new WPracticeLab9();
            String RetStr = Tester.FormulaeCalculation(x, y, z);
            double RetVal = Math.Round(Convert.ToDouble(RetStr), 2);

            Assert.AreEqual(Expected, RetVal, 0.3);
        }
        [TestMethod]
        public void Inneg1ඞneg1ඞneg1_Out0point22()
        {
            //Input values
            double x = -1;
            double y = -1;
            double z = -1;

            //Real answer
            double Expected = 0.22;

            //Method's returned value
            WPracticeLab9 Tester = new WPracticeLab9();
            String RetStr = Tester.FormulaeCalculation(x, y, z);
            double RetVal = Math.Round(Convert.ToDouble(RetStr), 2);

            Assert.AreEqual(Expected, RetVal, 0.3);
        }
    }
}
