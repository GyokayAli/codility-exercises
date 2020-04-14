﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetOddOccurancesInArray(new int[] { 9, 3, 9, 3, 9, 7, 9 });
            Console.WriteLine(result);
        }

        /* A non-empty array A consisting of N integers is given. 
         * The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value,
         * except for one element that is left unpaired.
         */

        /* For example, in array A such that:
         * A[0] = 9  A[1] = 3  A[2] = 9
         * A[3] = 3  A[4] = 9  A[5] = 7 A[6] = 9
         * 
         * the elements at indexes 0 and 2 have value 9,
         * the elements at indexes 1 and 3 have value 3,
         * the elements at indexes 4 and 6 have value 9,
         * the element at index 5 has value 7 and is unpaired.
         */

        /* 
         * Write a function that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.
         */

        /*
         * Write an efficient algorithm for the following assumptions:
         * N is an odd integer within the range [1..1,000,000];
         * each element of array A is an integer within the range [1..1,000,000,000];
         * all but one of the values in A occur an even number of times;
         */
        public static int GetOddOccurancesInArray(int[] A)
        {
            // store the occurance for each number
            Dictionary<int, int> dict = A
                        .GroupBy(item => item)
                        .ToDictionary(item => item.Key, item => item.Count());

            // find the number with odd occurance
            var oddOccurance = dict.First(x => x.Value % 2 == 1).Key;

            return oddOccurance;
        }
    }
}