using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MathOperation:Number
    {
        /// <summary>
        /// Method gives the sum of two numbers
        /// </summary>
        /// <returns></returns>
        public double Sum(double NumberX, double NumberY)
        {
            return NumberX + NumberY;
        }
        /// <summary>
        /// Method gives the difference of two numbers
        /// </summary>
        /// <returns></returns>
        public double Difference(double NumberX, double NumberY)
        {
            return NumberX - NumberY;
        }
        /// <summary>
        /// Method gives the multiply of two numbers
        /// </summary>
        /// <returns></returns>
        public double Multiply(double NumberX, double NumberY)
        {
            return NumberX * NumberY;
        }
        /// <summary>
        /// Method gives the divide of two numbers
        /// </summary>
        /// <returns></returns>
        public double Divide(double NumberX, double NumberY)
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
