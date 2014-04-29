using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            Console.WriteLine("Project Euler - Problem 1");
            Problem1 problem1 = new Problem1();
            problem1.Solve();
            Console.ReadKey();


            Console.WriteLine("Project Euler - Problem 2");
            Problem2.Solve();
            Console.ReadKey();

            Console.WriteLine("Project Euler - Problem 3");
            Problem3.Solve();
            Console.ReadKey();

            Console.WriteLine("Project Euler - Problem 4");
            Problem4.Solve();
            Console.ReadKey();

            Console.WriteLine("Project Euler - Problem 5");
            Problem5.Solve();
            Console.ReadKey();

            Console.WriteLine("Project Euler - Problem 6");
            Problem6.Solve();
            Console.ReadKey();

            Console.WriteLine("Project Euler - Problem 7");
            Problem7.Solve();
            Console.ReadKey();

            Console.WriteLine("Project Euler - Problem 8");
            Problem8.Solve();
            Console.ReadKey();

            Console.WriteLine("Project Euler - Problem 9");
            Problem9.Solve();
            Console.ReadKey();

            Console.WriteLine("Project Euler - Problem 10");
            Problem10.Solve();
            Console.ReadKey();
        }
    }
}
