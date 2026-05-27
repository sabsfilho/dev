// Min-Tracking Stack Implementation

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



class MinTrackingStackImplementationResult
{

    /*
     * Complete the 'processCouponStackOperations' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts STRING_ARRAY operations as parameter.
     */

    public static List<int> processCouponStackOperations(List<string> operations)
    {
        var rtn = new List<int>();
        
        var stack = new Stack<int>();
        int min = int.MaxValue;
        foreach(var op in operations)
        {
            var os = op.Split(' ');
            string cmd = os[0];
            
            if (cmd == "getMin") rtn.Add(min);
            else if (cmd == "top") rtn.Add(stack.Peek());
            else if (cmd == "pop") 
            {
                int v = stack.Pop();
                if (v == min)
                {
                    min = stack.Min();
                }
            }
            else if (cmd == "push" && os.Length == 2)
            {
                int n = int.Parse(os[1]);
                min = Math.Min(min, n);
                stack.Push(n);
            }            
            
        }
        
        return rtn;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int operationsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> operations = new List<string>();

        for (int i = 0; i < operationsCount; i++)
        {
            string operationsItem = Console.ReadLine();
            operations.Add(operationsItem);
        }

        List<int> result = Result.processCouponStackOperations(operations);

        Console.WriteLine(String.Join("\n", result));
    }
}
