using System;

namespace _05.PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FindPermMissingElem(new int[] { 1, 2, 3, 5 });
            Console.WriteLine(result);
        }

        /* An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], 
         * which means that exactly one element is missing.
         */

        /* Your goal is to find that missing element. 
         * Write a function that, given an array A, returns the value of the missing element.
         * 
         * For example, given array A such that:
         * A[0] = 2, A[1] = 3, A[2] = 1, A[3] = 5
         * the function should return 4, as it is the missing element.
         */

        /* Write an efficient algorithm for the following assumptions:
         * N is an integer within the range [0..100,000];
         * the elements of A are all distinct;
         * each element of array A is an integer within the range [1..(N + 1)].
         */
        public static int FindPermMissingElem(int[] A)
        {
            int i, total = 1;

            for (i = 2; i <= (A.Length + 1); i++)
            {
                total += i;
                total -= A[i - 2];
            }
            return total;
        }
    }
}