using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result: 100%
// Detected time complexity: O(1)
class Solution {
    public int solution(int A, int B, int K) {
        // prefix sum
        return A % K == 0
            ? (B / K) - (A / K) + 1
            : (B / K) - (A / K);
    }
}