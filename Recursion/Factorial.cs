using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Recursion
{
    public class Factorial
    {
        public int FactorialViaRecursion(int number)
        {
            if (number == 0)
                return 1;

            return number * FactorialViaRecursion(--number);
        }

        public int FactorialViaIterative(int number)
        {
            if (number == 0)
                return 1;

            int fact = 1;
            for (int i = number; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

    }
}
