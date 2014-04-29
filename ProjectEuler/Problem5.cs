using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem5
    {
        // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        public static void Solve()
        {
            int lcm = 1;
            for (int i = 2; i <= 20; i++)
                lcm = LeastCommonMultiple(lcm, i);
            Console.WriteLine("The smallest positive number is {0}.", lcm);
        }

        private static int LeastCommonMultiple(int a, int b)
        {
            int num1 = a;
            int num2 = b;

            while (a != b)  // if a and b are not the same then, we keep "multiplying" by adding the numbers to themselves until they match
            {
                if (a < b)
                    a += num1;
                else
                    b += num2;
            }
            return a;
        }
    }
}
