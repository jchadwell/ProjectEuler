using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem9
    {
        // A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        // a^2 + b^2 = c^2
        // For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        // Find the product abc.
        public static void Solve()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int sum = 1000;
            bool found = false;
            for (a = 1; a <= 500; a++)
            {
                for (b = a; b <= 500; b++)
                {
                    c = sum - a - b;
                    if (a * a + b * b == c * c)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                    break;
            }
            int product = a * b * c;
            
            //Console.WriteLine("The triple is {0}, {1}, {2}, {3} = {4}. \n Product is {5}.", a, b, c, sum, product);
            Console.WriteLine("The answer is {0}", product);
        }
    }
}
