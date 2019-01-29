using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestChainArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 0, 3, 1, 6, 2 };
            int n = arr.Length;
            Console.WriteLine(maxLength(arr, n));
            Console.ReadLine();
        }
        static void aNesting(int[] arr, int start, ref int max)
        {
            int localMax = 0;
            int temp;
            Console.WriteLine("Start point:");
            Console.WriteLine(start);
            while(arr[start] != -1)
            {
                Console.Write("Next point >> ");
                Console.WriteLine(start);
                localMax++;
                temp = arr[start];
                arr[start] = -1;
                start = temp;
            }
            if (localMax > max)
                max = localMax;
        }
        static int maxLength(int[] arr, int n)
        {
            int max = 0;
            for(int i = 0; i < n; i++)
            {
                aNesting(arr, i, ref max);
            }
            return max;
        }
    }
}
