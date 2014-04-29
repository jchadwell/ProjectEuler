using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem6
    {
        // The sum of the squares of the first ten natural numbers is,
        //1^2 + 2^2 + ... + 10^2 = 385
        //The square of the sum of the first ten natural numbers is, 
        //(1 + 2 + ... + 10)^2 = 552 = 3025
        //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        public static void Solve()
        {
            int num = 100;
            int sumSquare = (num * (num + 1) * (2 * num + 1)) / 6;
            int sum = num * (num + 1) / 2;  // Good ol' high school math.  It is pretty clever how this pattern works for the sum of all numbers from 1 to num.
            int answer = sum * sum - sumSquare;

            Console.WriteLine("The difference is {0}.", answer);
        }
    }
}
