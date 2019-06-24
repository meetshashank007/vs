using System;
using System.Linq;
using System.Collections.Generic;
/*
 * Write a program that, given an array A[] of n numbers and another number x,
 * determines whether or not there exist two elements in S whose sum is exactly x.
 */
namespace hasArrayTwoCandidates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrList = new List<int>();
            var inputList = string.Empty;
            Console.WriteLine("Please enter the length of input array:");
            var countValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your for test: ");
            inputList = "{ ";
            for (int i = 0; i < countValue; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                arrList.Add(x);
                inputList += x.ToString();
                if(i < countValue-1)
                {
                    inputList += ", ";
                }
                else
                {
                    inputList += " }";
                }
            }
            Console.WriteLine("Your input array => ");
            Console.WriteLine(inputList);
            Console.WriteLine("Please enter the sum to chek in the list for the pair:");
            var sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your input to check => ");
            Console.WriteLine(sum);
            hasArrayTwoCandidates(arrList.ToArray(), sum);
            Console.ReadKey();
        }
        public static bool hasArrayTwoCandidates(int[] arr, int sum)
        {
            int l = 0, r, arrLength;
            r = arrLength = arr.Length - 1;
            var result = from element in arr
                         orderby element ascending
                         select element;
            arr = result.ToArray();
            while (arr[l] < arr[r])
            {
                if(arr[l] + arr[r] == sum)
                {
                    Console.WriteLine("Pair found : {0} + {1} = {2}", arr[l], arr[r], sum);
                    return true;
                }
                else if(arr[l] + arr[r] < sum)
                {
                    l++;
                }
                else if(arr[l] + arr[r] > sum)
                {
                    r--;
                }
            }
            return false;
        }
    }
}
