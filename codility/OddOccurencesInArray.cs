using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result: 100%
class Solution {
    public int solution(int[] A) {
        Array.Sort(A);

        for (int i = 0; i < A.Length - 1; i += 2)
        {
            if (A[i] != A[i + 1])
            {
                return A[i];
            }
        }

        return A[A.Length - 1];
    }
}