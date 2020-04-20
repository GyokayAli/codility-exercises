using System;

namespace _15.MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = FindMaxProductOfThree(new int[] { -3, 1, 2, -2, 5, 6 });
            Console.WriteLine(result1);
            var result2 = FindMaxProductOfThree(new int[] { -5, 5, -5, 4 });
            Console.WriteLine(result2);
        }

        /* A non-empty array A consisting of N integers is given. The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R] (0 ≤ P < Q < R < N).
         * For example, array A such that:
         * A[0] = -3
         * A[1] = 1
         * A[2] = 2
         * A[3] = -2
         * A[4] = 5
         * A[5] = 6
         * contains the following example triplets:
         * (0, 1, 2), product is −3 * 1 * 2 = −6
         * (1, 2, 4), product is 1 * 2 * 5 = 10
         * (2, 4, 5), product is 2 * 5 * 6 = 60
         * So the function should return 60, as the product of triplet (2, 4, 5) is maximal.
         * 
         * Write an efficient algorithm for the following assumptions:
         * N is an integer within the range [3..100,000];
         * each element of array A is an integer within the range [−1,000..1,000].
         */

        static int FindMaxProductOfThree(int[] A)
        {
            int N = A.Length;

            Array.Sort(A);

            if (N >= 3)
            {
                int firstTriplet = A[0] * A[1] * A[N - 1];
                int lastTriplet = A[N - 1] * A[N - 2] * A[N - 3];
                
                return Math.Max(firstTriplet, lastTriplet);
            }
            return 0;
        }
    }
}