// Generate Valid Angle Bracket Sequences
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



class GenerateValidAngleBracketSequencesResult
{

    /*
     * Complete the 'generateAngleBracketSequences' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts INTEGER n as parameter.
     */

    public static List<string> generateAngleBracketSequences(int n)
    {
        // recursion
        // open < n then add < , open++
        // close < open then add >, close++
        // open + close == txt.length == n * 2, add string
        
        var lst = new List<string>();
        if (n < 1) return lst;
        
        AddBracket(lst, string.Empty, 0, 0, n);
        
        return lst;
    }
    
    static void AddBracket(List<string> lst, string txt, int open, int close, int n)
    {        
        if (txt.Length == n * 2) 
        {
            lst.Add(txt);
            return;
        }
        if (open < n)
        {
            AddBracket(lst, txt + "<", open + 1, close, n);
        }
        if (close < open)
        {
            AddBracket(lst, txt + ">", open, close + 1, n);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> result = Result.generateAngleBracketSequences(n);

        Console.WriteLine(String.Join("\n", result));
    }
}
