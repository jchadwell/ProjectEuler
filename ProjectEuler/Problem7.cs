using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem7
    {
        // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        // What is the 10001st prime number?
        public static void Solve()
        {
            int num = 1;
            int prime = 1;

            while (prime < 10001)
            {
                num = num + 2;  // obviously even numbers (except for 2) are not prime numbers, so we can skip them)
                if (IsPrime(num))
                    prime++;
            }
            Console.WriteLine("The 10,001st prime number is {0}.", num);
        }

        private static bool IsPrime(int number)
        {
            if (number == 1)
                return false;
            if (number == 2)
                return true;
            //if (number % 2 == 0)
            //    return false;
            for (int i = 3; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
