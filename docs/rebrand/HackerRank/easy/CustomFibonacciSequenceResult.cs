// Custom Fibonacci Sequence
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



class CustomFibonacciSequenceResult
{

    /*
     * Complete the 'getAutoSaveInterval' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static long getAutoSaveInterval(int n)
    {
        return Fibo(n);
    }
    
    static long Fibo(int n)
    {
        if (n == 0) return 1;
        if (n == 1) return 2;
        
        long c = 1;
        long b = 1;
        long a = 1;
        // c = a + b
        for (int i = 1; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        long result = Result.getAutoSaveInterval(n);

        Console.WriteLine(result);
    }
}
