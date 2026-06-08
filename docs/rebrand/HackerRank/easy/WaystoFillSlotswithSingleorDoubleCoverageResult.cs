// Ways to Fill Slots with Single or Double Coverage
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


using System.Numerics;

class WaystoFillSlotswithSingleorDoubleCoverageResult
{

    /*
     * Complete the 'countInstallationSequences' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER n as parameter.
     */

    public static string countInstallationSequences(int n)
    {
        if (n < 2) return "1";
        
        BigInteger a = 1;
        BigInteger b = 1;
        BigInteger c = 1;
        
        for(int i = 1; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        
        return a.ToString();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.countInstallationSequences(n);

        Console.WriteLine(result);
    }
}
