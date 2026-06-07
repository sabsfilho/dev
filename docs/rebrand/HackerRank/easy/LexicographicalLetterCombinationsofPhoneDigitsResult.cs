// Lexicographical Letter Combinations of Phone Digits
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



class LexicographicalLetterCombinationsofPhoneDigitsResult
{

    /*
     * Complete the 'minTasksToCancelForNoConflict' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING digits as parameter.
     */

    public static List<string> minTasksToCancelForNoConflict(string digits)
    {
        var rs = new List<string>();
        
        var xs = Convert(digits);
        
        int i = 0;
        Build(rs, xs, string.Empty, ref i);
        
        return rs;
    }
    
    static List<string> Convert(string digits)
    {
        var lst = new List<string>();
        
        var map = new Dictionary<char, string>() 
        {
            { '0', "0" },
            { '1', "1" },
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" },
        };
        foreach(char d in digits)
        {
            lst.Add(map[d]);
        }
        return lst;
    }
    
    static void Build(List<string> rs, List<string> lst, string pfx, ref int i)
    {
        if (i == lst.Count) 
        {
            rs.Add(pfx);
            return;
        }
        
        var ws = lst[i].ToCharArray();
        for(int j=0; j < ws.Length; j++)
        {
            i++;
            Build(rs, lst, $"{pfx}{ws[j]}", ref i);
            i--; // backtrack
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string digits = Console.ReadLine();

        List<string> result = Result.minTasksToCancelForNoConflict(digits);

        Console.WriteLine(String.Join("\n", result));
    }
}
