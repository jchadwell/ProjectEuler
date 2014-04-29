using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem1
    {
        // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.
        public void Solve()
        {
            int answer = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    answer += i;
            }

            Console.WriteLine("The result is {0}.", answer);
        }

        // using LINQ, this can be done in one line.
        public static int SolveWithLinq()
        {
            return Enumerable.Range(1, 999).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
