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

        var smallest = 1;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < 0)
            {
                continue;
            }

            if (smallest < A[i])
            {
                return smallest;
            }
            else
            {
                smallest = A[i] + 1;
            }
        }

        return smallest;
    }
}