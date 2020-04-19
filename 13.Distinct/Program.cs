using System;
using System.Collections.Generic;

namespace _13.Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetDistinct(new int[] { 2, 1, 1, 2, 3, 1});
            Console.WriteLine(result);
        }

        /* Write a function that, given an array A consisting of N integers, returns the number of distinct values in array A.
         * 
         * Write an efficient algorithm for the following assumptions:
         * N is an integer within the range [0..100,000];
         * each element of array A is an integer within the range [−1,000,000..1,000,000].
         */

        public static int GetDistinct(int[] A)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                int value = A[i];
                set.Add(value);
            }

            return set.Count;
        }
    }
}
