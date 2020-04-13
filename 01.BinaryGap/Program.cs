﻿using System;
using System.Linq;

namespace _01.BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindBinaryGap(529));
            Console.WriteLine(FindBinaryGap(20));
            Console.WriteLine(FindBinaryGap(15));
            Console.WriteLine(FindBinaryGap(32));
        }

        /* A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.
          For example, number 9 has binary representation 1001 and contains a binary gap of length 2.
          The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3.
          The number 20 has binary representation 10100 and contains one binary gap of length 1.
          The number 15 has binary representation 1111 and has no binary gaps.
          The number 32 has binary representation 100000 and has no binary gaps. */

        /*
         Write a function that, given a positive integer N, returns the length of its longest binary gap.
         The function should return 0 if N doesn't contain a binary gap.
         For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5.
         Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.
             */
    
        /// Write an efficient algorithm for the following assumptions: N is an integer within the range [1..2,147,483,647]
        public static int FindBinaryGap(int N)
        {
            // convert to binary
            string binaryNumber = Convert.ToString(N, 2);

            // clean leading and trailing zeros
            int indexOneFirst = binaryNumber.IndexOf('1');
            int indexOneLast = binaryNumber.LastIndexOf('1');
            binaryNumber = binaryNumber.Substring(indexOneFirst, indexOneLast);

            // create an array of zeros
            var zerosArray = binaryNumber.Split('1');

            // find the longest sequence of zeros in the array
            int longestSequence = zerosArray.OrderByDescending(x => x.Length).First().Length;

            return longestSequence;
        }
    }
}
