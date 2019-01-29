using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /* 
    * Given an array p[] which represents the chain of matrices such that the ith matrix Ai 
    * is of dimension p[i-1] x p[i]. We need to write a function MatrixChainOrder() 
    * that should return the minimum number of multiplications needed to multiply the chain
    */

namespace MatrixChainOrder
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 40, 20, 30, 10, 30 };

            MatrixChainOrder(arr);
        }

        static void MatrixChainOrder(int[] arr)
        {
            Console.WriteLine("Please find the below order of matrix chain:");
            int unicode = 65;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                char character = (char)unicode;
                string text = character.ToString();
                Console.WriteLine("{2} => {0} X {1}", arr[i], arr[i + 1], character);
                unicode++;
            }
            Console.ReadLine();
        }
    }
}
