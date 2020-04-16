using System;
using System.Collections.Generic;

namespace _08.PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = PermutationCheck(new int[] { 4, 1, 3 });
            Console.WriteLine(result);
        }

        /* A non-empty array A consisting of N integers is given.
         * 
         * A permutation is a sequence containing each element from 1 to N once, and only once.
         * 
         * For example, array A such that: A[0] = 4, A[1] = 1, A[2] = 3, A[3] = 2
         * is a permutation, 
         * but array A such that: A[0] = 4, A[1] = 1, A[2] = 3
         * is not a permutation, because value 2 is missing.
         * 
         * Write a function that, given an array A, returns 1 if array A is a permutation and 0 if it is not.
         * 
         * Write an efficient algorithm for the following assumptions:
         * N is an integer within the range [1..100,000];
         * each element of array A is an integer within the range [1..1,000,000,000];
         */

        public static int PermutationCheck(int[] A)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
                set.Add(A[i]);

            for (int i = 1; i <= A.Length; i++)
            {
                var exists = set.Contains(i);
                if (!exists)
                {
                    // not a permutation
                    return 0;
                }
            }
            // is a permutation
            return 1;
        }
    }
}