using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTests
{
    public class IsSqrt
    {
        public bool IsNumberSqrt(int number)
        {
            var result = Math.Sqrt(number);
            if (number < 1)
            {
                return false;
            }

            if (Math.Sqrt(number) == result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
