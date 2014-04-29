using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem4
    {
        // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        // Find the largest palindrome made from the product of two 3-digit numbers.
        public static void Solve()
        {
            bool found = false;
            int firstHalf = 998;
            int palindrome = 0;
            int[] factors = new int[2];

            while (!found)
            {
                firstHalf--;
                palindrome = makePalindrome(firstHalf);
                for (int i = 999; i > 99; i--)
                {
                    if ((palindrome / i) > 999 || i * i < palindrome)  // Stop checking, because the solution no longer consists of 3-digit numbers
                        break;

                    if (palindrome % i == 0)
                    {
                        found = true;
                        factors[0] = palindrome / i;
                        factors[1] = i;
                        break;
                    }
                }
            }
            Console.WriteLine("Found the palindrome {0}, which is made from {1} * {2}.", palindrome, factors[0], factors[1]);
        }

        //Method to make palindromes
        private static int makePalindrome(int firstHalf)
        {
            char[] reversed = firstHalf.ToString().Reverse().ToArray();
            return Convert.ToInt32(firstHalf + new string(reversed));
        }
    }
}
