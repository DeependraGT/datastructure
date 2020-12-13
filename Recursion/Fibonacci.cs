using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Recursion
{
    public class Fibonacci
    {

        public void FiboViaRecursion(int n, int a = 0, int b = 1)
        {
            if (a == 0 && b == 1)
                Console.Write(a + " " + b);

            int sum = a + b;

            if (sum > n)
                return;

            Console.Write(" " + sum);
            FiboViaRecursion(n, b, sum);
        }

        public void FiboViaIterative(int n, int a = 0, int b = 1)
        {
            if (a == 0 && b == 1)
            {
                Console.WriteLine("");
                Console.Write(a + " " + b);
            }

            int sum = a+b;

            while (sum <= n)
            {
                Console.Write(" " + sum);
                a = b;
                b = sum;
                sum = a + b;
            }
        }

    }
}
