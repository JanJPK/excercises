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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        var firstSum = sumFunc(arr, 0);
        var min = firstSum;
        var max = firstSum;

        for (int i = 1; i < arr.Count; i++)
        {
            var sum = sumFunc(arr, i);

            if (sum < min)
            {
                min = sum;
            }
            else if (sum > max)
            {
                max = sum;
            }
        }

        Console.WriteLine($"{min} {max}");
    }

    public static long sumFunc(List<int> arr, int skipIndex)
    {
        long sum = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (i != skipIndex)
            {
                sum += arr[i];
            }
        }

        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
