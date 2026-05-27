// Validate Properly Nested Brackets

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



class ValidateProperlyNestedBracketsResult
{

    /*
     * Complete the 'areBracketsProperlyMatched' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts STRING code_snippet as parameter.
     */

    public static bool areBracketsProperlyMatched(string code_snippet)
    {
        /*
        open = ( { [ => put
        close = ) } ] => pop
        stack
        if (a[0])
        if open, put (,[
        if close, pop if popped <> close returns false
        */
        
        var brackets = new Dictionary<char, char>() // close, open
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        
        
        bool IsOpenBracket(char c)
        {
            return brackets.Values.Contains(c);
        }
        
        bool IsCloseBracket(char c)
        {
            return brackets.Keys.Contains(c);
        }
        
        bool IsMatchBracket(char open, char close)
        {
            return brackets[close] == open;
        }
        
        var stack = new Stack<char>();
        
        for(int i=0; i<code_snippet.Length; i++)
        {
            char c = code_snippet[i];
            if (IsOpenBracket(c)) stack.Push(c);
            else if (IsCloseBracket(c))
            {
                if (stack.Count == 0) return false;
                var openBracket = stack.Pop();
                if (!IsMatchBracket(openBracket, c)) return false;
            }
        }
        
        return stack.Count == 0;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string code_snippet = Console.ReadLine();

        bool result = Result.areBracketsProperlyMatched(code_snippet);

        Console.WriteLine((result ? 1 : 0));
    }
}
