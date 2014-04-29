using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem10
    {
        // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        // Find the sum of all the primes below two million.
        

        public static void Solve()
        {
            // use long - int isn't big enough and will overflow at 1179908154..a difference of 2^32 from the real answer
            long num = 1;
            long primeCount = 1;
            long primeSum = 0;

            while (num < 2000000)
            {
                num = num + 1;  // obviously even numbers (except for 2) are not prime numbers, so we can skip them)
                if (IsPrime(num))
                {
                    primeCount++;
                    primeSum += num;
                    //Console.WriteLine(num);
                }
            }
            Console.WriteLine("The sum of all primes below 2 million is {0}.", primeSum);
        }

        private static bool IsPrime(long number)
        {
            if (number == 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;
            for (long i = 3; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
