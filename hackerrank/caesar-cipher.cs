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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        string encrypted = "";

        foreach (char unencryptedChar in s)
        {
            if (char.IsLetter(unencryptedChar))
            {
                char encryptedChar;

                if (char.IsUpper(unencryptedChar))
                {
                    encryptedChar = (char)((((unencryptedChar + k) - 'A') % 26) + 'A');
                }
                else
                {
                    encryptedChar = (char)((((unencryptedChar + k) - 'a') % 26) + 'a');
                }

                encrypted += encryptedChar;
            }
            else
            {
                encrypted += unencryptedChar;
            }

        }

        return encrypted;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
