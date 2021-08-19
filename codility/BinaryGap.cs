using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result: 100%
class Solution {
    public int solution(int N) {
        var maxGapLength = 0;
        var currentGapLength = 0;
        var binaryRepresentation = Convert.ToString(N, 2);

        for (int i = 0; i < binaryRepresentation.Length; i++)
        {
            if (binaryRepresentation[i] == '0')
            {
                currentGapLength++;
            }
            else
            {
                if (currentGapLength > maxGapLength)
                {
                    maxGapLength = currentGapLength;
                }

                currentGapLength = 0;
            }
        }

        return maxGapLength;
    }
}