using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem3
    {
        // The prime factors of 13195 are 5, 7, 13 and 29.
        // What is the largest prime factor of the number 600851475143 ?
        public static void Solve()
        {
            const long number = 600851475143;
            long newNum = number;
            long largestFactor = 0;
            int counter = 2;

            while (counter * counter <= newNum)  // as long as the square of the counter is less than newNum, then we're good to go
            {
                if (newNum % counter == 0)
                {
                    newNum = newNum / counter;
                    largestFactor = counter;
                }
                else
                    counter = (counter == 2) ? 3 : counter + 2; //counter++;      compressed if construct to skip even numbers after 2.

                if (newNum > largestFactor) //the remainder is a prime number
                    largestFactor = newNum;
            }

            Console.WriteLine("Largest prime factor is {0}.", largestFactor);
        }
    }
}
