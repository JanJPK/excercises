using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result: 100%
// Detected time complexity: O(N) or O(N * log(N))
class Solution {
    public int solution(int[] A) {
        Array.Sort(A);

        if (A.Length == 0 || A[0] > 1)
        {
            return 1;
        }

        if (A[A.Length - 1] == A.Length)
        {
            return A.Length + 1;
        }

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] + 1 != A[i + 1])
            {
                return A[i] + 1;
            }
        }

        return -1;
    }
}

// below works too if you use integers long enough for sums
// class Solution {
//     public int solution(int[] A) {
//         if (A.Length == 0)
//         {
//             return 1;
//         }

//         var n = A.Length + 1; // count of numbers
//         var expectedSum = n * (n + 1) / 2;
//         //var actualSum = A.Sum(); // LINQ is expensive
//         var actualSum = 0;
//         for (int i = 0; i < A.Length; i++)
//         {
//             actualSum += A[i];
//         }

//         return expectedSum - actualSum;
//     }
// }