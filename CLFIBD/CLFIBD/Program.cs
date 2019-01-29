using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLFIBD
{
    class Program
    {

        /*
         * For a string S let the unique set of characters that occur in it one or more times be C. Consider a permutation of the elements of C as (c1,c2,c3...). Let f(c) be the number of times c occurs in S.

If any such permutation of the elements of C satisfies f(ci)=f(ci−1)+f(ci−2) for all i≥3, the string is said to be a dynamic string.

Mr Bancroft is given the task to check if the string is dynamic, but he is busy playing with sandpaper. Would you help him in such a state?

Note that if the number of distinct characters in the string is less than 3, i.e. if |C|<3, then the string is always dynamic
*/
        static void Main(string[] args)
        {
            var countValues = new string[10];
            Console.WriteLine("Please enter the no of string to check for 'Fibonacci String':");
            var countValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The input no of lines is: " + Convert.ToString(countValue));
            Console.WriteLine("Please enter the string for test: ");
            for (int i = 0; i < countValue; i++)
            {
                countValues[i] = Convert.ToString(Console.ReadLine());
            }
            foreach

        }
    }
}
