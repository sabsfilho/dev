// Check Valid Anagram
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



class CheckValidAnagramResult
{

    /*
     * Complete the 'isAnagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. STRING t
     */

    public static int isAnagram(string s, string t)
    {
        return s.Length > 0 && s.Length == t.Length && Sorted(s) == Sorted(t) ? 1 : 0;
    }
    
    static string Sorted(string s)
    {
        var arr = s.ToCharArray();
        Array.Sort(arr);
        return new string(arr);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int result = Result.isAnagram(s, t);

        Console.WriteLine(result);
    }
}
