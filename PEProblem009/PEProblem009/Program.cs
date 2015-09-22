using System;
/*
 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
 * a2 + b2 = c2
 * For example, 32 + 42 = 9 + 16 = 25 = 52.
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * Find the product abc.
 * 
 * 
 */
namespace PEProblem009
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            int result = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            for (int n = 1; n < 100; n++)
            {
                for (int m = n + 1; m < 100; m++)
                {
                    a = 2 * m * n; // b
                    b = m * m - n * n; // a
                    c = m * m + n * n;

                    if (a + b + c == 1000)
                    {
                        result = a * b * c;
                        break;
                    }
                }
            }

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
