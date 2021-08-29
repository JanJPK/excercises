using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var positiveCount = 0;
        var negativeCount = 0;
        var zeroCount = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            var num = arr[i];

            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeCount++;
            }
            else
            {
                zeroCount++;
            }
        }

        writeRatio(positiveCount, arr.Count);
        writeRatio(negativeCount, arr.Count);
        writeRatio(zeroCount, arr.Count);

    }

    public static void writeRatio(int count, int total)
    {
        var ratio = (double)count / total;
        Console.WriteLine(Math.Round(ratio, 6));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
