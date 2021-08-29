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
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < k % 9; i++)
        {
            sb.Append(n);
        }

        return recurse(sb.ToString());
    }

    public static int recurse(string n)
    {
        if (n.Length == 1)
        {
            return int.Parse(n);
        }

        long sum = 0;
        for (int i = 0; i < n.Length; i++)
        {
            sum += n[i] - '0';
        }

        return recurse(sum.ToString());
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
