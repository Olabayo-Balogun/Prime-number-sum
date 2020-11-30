    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekfourTaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of all prime numbers between 0 and 2,147,483,647");

            DateTime startTime = DateTime.Now;
            bool isPrimeNumber = true;

            for (int i = 2; i < 2147483647; i++)
            {
                for (int j = 2; j < 2147483647; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        isPrimeNumber = false;
                        break;
                    }

                }
                if (isPrimeNumber)
                {
    
                   int[] primeValues = { i };

                    int sum = 0;
                    foreach (int item in primeValues)
                    {
                        sum += item;
                    }

                    Console.WriteLine(sum);

                }
                isPrimeNumber = true;
            }

            DateTime endTime = DateTime.Now;

            TimeSpan responseTime = endTime - startTime;

            double result = responseTime.TotalMinutes;
            Console.WriteLine($"It took {result} minutes to generate your result");
            Console.ReadLine();





        }
    }
}
