using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result: 100%
class Solution {
    public int[] solution(int[] A, int K) {
        if (A == null || A.Length == 0)
        {
            return A;
        }

        // When K = A.Length we rotate back to the starting point
        // Hence we can modulo to skip all full rotations
        K = K % A.Length;
        if (K == 0)
        {
            return A;
        }

        var rotated = new int[A.Length];

        for (int i = 0; i < K ; i++)
        {
            rotated[i] = A[A.Length - K + i];
        }

        for (int i = 0; i < A.Length - K; i++)
        {
             rotated[K + i] = A[i];
        }

        return rotated;
    }
}