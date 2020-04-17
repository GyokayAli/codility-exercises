using System;
using System.Linq;

namespace _09.MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = FindMissingInteger(new int[] { 1, 3, 6, 4, 1, 2 });
            Console.WriteLine(result1);
            var result2 = FindMissingInteger(new int[] { 1, 2, 3 });
            Console.WriteLine(result2);
            var result3 = FindMissingInteger(new int[] { -1, -3 });
            Console.WriteLine(result3);
        }

        /* Write a function that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
         * 
         * For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
         * Given A = [1, 2, 3], the function should return 4.
         * Given A = [−1, −3], the function should return 1.
         * 
         * Write an efficient algorithm for the following assumptions:
         * N is an integer within the range [1..100,000];
         * each element of array A is an integer within the range [−1,000,000..1,000,000];
         */

        public static int FindMissingInteger(int[] A)
        {
            var enumerable = Enumerable.Range(1, int.MaxValue).Except(A);
            var firstMissing = enumerable.First(x => x > 0);

            return firstMissing;
        }
    }
}
