using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result: 100%
// Detected time complexity: O(1)
class Solution {
    public int solution(int X, int Y, int D) {
        if (X == Y)
        {
            return 0;
        }

        var distance = Y - X;
        var jumps = (double)distance / D;
        return (int)Math.Ceiling(jumps);
    }
}