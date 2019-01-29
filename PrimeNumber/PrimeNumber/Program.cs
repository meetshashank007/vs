using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PrimeNumber
{
    class Program
    {
        /*
         * The prime 41, can be written as the sum of six consecutive primes:
         * 41 = 2 + 3 + 5 + 7 + 11 + 13
         * This is the longest sum of consecutive primes that adds to a prime below one-hundred.
         * The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.
         * Which prime, below one-million, can be written as the sum of the most consecutive primes?
         */

        // Create new stopwatch.
        static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            //Console.WriteLine("Plese select an option to work for");
            long number = 0;
            string _continue = String.Empty;

            while (_continue != "N" && _continue != "n")
            {
                Console.WriteLine("Please enter a number to chek for the prime : ");
                number = Convert.ToInt64(Console.ReadLine());
                if (Program.isPrime(number))
                {
                    Console.WriteLine("The Input number is prime number!");
                }
                else
                {
                    Console.WriteLine("The number is not prime!");
                }
                Console.WriteLine("Want to test again ? Y/N ");
                _continue = Console.ReadLine();
            }
        }

        public static bool isPrime(long number)
        {
            TimeSpan ts;
            string elapsedTime;
            // Begin timing.
            stopwatch.Start();
            int k = 0;
            for (int i  = 2; i < number; i++)
            {
                if (i != 2 && i % 2 == 0)
                    continue;
                for (int j = 1; j < Math.Sqrt(number); j++)
                {
                    k++;
                    if (i*j == number)
                    {
                        // Stop timing.
                        stopwatch.Stop();
                        ts = stopwatch.Elapsed;

                        // Format and display the TimeSpan value.
                        elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds,
                            ts.Milliseconds / 10);
                        Console.WriteLine("RunTime " + elapsedTime);
                        Console.WriteLine("Factor found: {0} * {1}", i, j);
                        Console.WriteLine("Number of executions: {0}", k);
                        return false;
                    }
                }
            }
            // Stop timing.
            stopwatch.Stop();
            ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("Number of executions: {0}", k);
            return true;
        }

        public static long getNextPrime(long number)
        {

            return number;
        }
    }
}
