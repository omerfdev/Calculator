using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathOperation:Number
    {
        public delegate double SumDelegate(double NumberX,double NumberY);
        
        public static SumDelegate sumDelegate = Sum;

        public delegate double DifDelegate(double NumberX, double NumberY);

        public static DifDelegate difDelegate = Difference;

        public delegate double MulDelegate(double NumberX, double NumberY);

        public static MulDelegate mulDelegate = Multiply;

        public delegate double DivDelegate(double NumberX, double NumberY);

        public static DivDelegate divDelegate = Divide;
        /// <summary>
        /// Method gives the sum of two numbers
        /// </summary>
        /// <returns></returns>
        public static double Sum(double NumberX, double NumberY)
        {
            return NumberX + NumberY;
        }
        /// <summary>
        /// Method gives the difference of two numbers
        /// </summary>
        /// <returns></returns>
        public static double Difference(double NumberX, double NumberY)
        {
            return NumberX - NumberY;
        }
        /// <summary>
        /// Method gives the multiply of two numbers
        /// </summary>
        /// <returns></returns>
        public static double Multiply(double NumberX, double NumberY)
        {
            return NumberX * NumberY;
        }
        /// <summary>
        /// Method gives the divide of two numbers
        /// </summary>
        /// <returns></returns>
        public static double Divide(double NumberX, double NumberY)
        {
            if (NumberY != 0)
                return NumberX / NumberY;
            else
            {
                Console.WriteLine("Divide by Zero Exception!");
                return 0.0;
            }
        }
    }
}
