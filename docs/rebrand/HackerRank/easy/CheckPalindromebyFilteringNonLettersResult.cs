// Check Palindrome by Filtering Non-Letters
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



class CheckPalindromebyFilteringNonLettersResult
{

    /*
     * Complete the 'isAlphabeticPalindrome' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts STRING code as parameter.
     */

    public static bool isAlphabeticPalindrome(string code)
    {
        if (string.IsNullOrEmpty(code)) return false;
        
        var arr = code
            .ToCharArray()
            .Where(x => char.IsLetter(x))
            .Select(x => char.ToLower(x))
            .ToArray();
        
        int L = 0;
        int R = arr.Length - 1;
        
        while(L < R)
        {
            if (arr[L] != arr[R])
            {
                return false;
            }
            L++;
            R--;
        }
        
        return true;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string code = Console.ReadLine();

        bool result = Result.isAlphabeticPalindrome(code);

        Console.WriteLine((result ? 1 : 0));
    }
}
