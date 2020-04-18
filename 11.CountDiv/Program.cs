using System;

namespace _11.CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = CountDivs(5, 11, 2);
            Console.WriteLine(result);
        }

        /* Write a function that, given three integers A, B and K, returns the number of integers 
         * within the range [A..B] that are divisible by K, i.e.:
         * { i : A ≤ i ≤ B, i mod K = 0 }
         * 
         * For example, for A = 6, B = 11 and K = 2, your function should return 3, 
         * because there are three numbers divisible by 2 within the range [6..11], namely 6, 8 and 10.
         * 
         * Write an efficient algorithm for the following assumptions:
         * A and B are integers within the range [0..2,000,000,000];
         * K is an integer within the range [1..2,000,000,000];
         * A ≤ B
         */

        public static int CountDivs(int A, int B, int K)
        {
            var divB = B / K;
            var divA = A / K;
            var inclusive = A % K == 0 ? 1 : 0;

            int count = divB - divA + inclusive;
            
            return count;
        }
    }
}
