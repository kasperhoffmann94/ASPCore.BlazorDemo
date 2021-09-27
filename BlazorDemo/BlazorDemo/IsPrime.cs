using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTests
{
    public class IsPrime
    {
        public bool IsNumberPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number % 1 == 0 && number % number == 0)
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
