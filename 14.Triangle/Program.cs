using System;

namespace _14.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FindTriangularTriplet(new int[] { int.MaxValue, int.MaxValue, int.MaxValue });
            Console.WriteLine(result);
        }

        /* An array A consisting of N integers is given. A triplet (P, Q, R) is triangular if 0 ≤ P < Q < R < N and: 
         * A[P] + A[Q] > A[R],
         * A[Q] + A[R] > A[P],
         * A[R] + A[P] > A[Q].
         * 
         * For example, consider array A such that:
         * A[0] = 10    A[1] = 2    A[2] = 5
         * A[3] = 1     A[4] = 8    A[5] = 20
         * Triplet (0, 2, 4) is triangular. So the function should return 1.
         * 
         * Write a function that, given an array A consisting of N integers, returns 1 if there exists a triangular triplet for this array and returns 0 otherwise.
         * 
         * Write an efficient algorithm for the following assumptions:
         * N is an integer within the range [0..100,000];
         * each element of array A is an integer within the range [−2,147,483,648..2,147,483,647];
         */

        public static int FindTriangularTriplet(int[] A)
        {
            int N = A.Length;
            Array.Sort(A);

            if (N >= 3)
            {
                for (int i = 0; i < N - 2; i++)
                {
                    // using long to prevent overflow
                    long P = A[i];
                    long Q = A[i + 1];
                    long R = A[i + 2];

                    if (P + Q > R)
                        return 1;
                }
            }

            return 0;
        }
    }
}