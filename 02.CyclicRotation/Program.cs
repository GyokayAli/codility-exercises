using System;

namespace _02.CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = GetCyclicRotation(new int[] { 3, 8, 9, 7, 6 }, 3);
            Console.WriteLine(string.Join(", ", result1));

            var result2 = GetCyclicRotation(new int[] { 1, 2, 3, 4 }, 4);
            Console.WriteLine(string.Join(", ", result2));
        }

        /*
         * An array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index,
         * and the last element of the array is moved to the first place. 
         * For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7] (elements are shifted right by one index and 6 is moved to the first place).
         * 
         * The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.
         * 
         * Write a function that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.
         * For example, given A = [3, 8, 9, 7, 6] and K = 3 the function should return [9, 7, 6, 3, 8]. Three rotations were made.
         */

        /*
         * Assume that:
         * N and K are integers within the range [0..100]
         * each element of array A is an integer within the range [−1,000..1,000]
         */

        public static int[] GetCyclicRotation(int[] A, int K)
        {
            int[] resultArray = A;

            if (A.Length > 1)
            {
                int arrLen = A.Length;

                for (int k = 0; k < K; k++)
                {
                    // create a fresh array
                    int[] tempArray = new int[arrLen];
                    // copy over numbers except the last one
                    Array.Copy(resultArray, 0, tempArray, 1, arrLen - 1);
                    // put at first position the missing number
                    tempArray[0] = resultArray[arrLen - 1];
                    // update the main array
                    resultArray = tempArray;
                }
            }
            return resultArray;
        }
    }
}
