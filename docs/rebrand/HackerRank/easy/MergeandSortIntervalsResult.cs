// Merge and Sort Intervals
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



class MergeandSortIntervalsResult
{

    /*
     * Complete the 'mergeHighDefinitionIntervals' function below.
     *
     * The function is expected to return a 2D_INTEGER_ARRAY.
     * The function accepts 2D_INTEGER_ARRAY intervals as parameter.
     */

    public static List<List<int>> mergeHighDefinitionIntervals(List<List<int>> intervals)
    {
        intervals.Sort((a,b)=>a[0]-b[0]);
        var lst = new List<List<int>>();
        foreach(var x in intervals){
            int mn = x[0];
            int mx = x[1];
            int max = lst.Count == 0 ? 0 : lst[lst.Count - 1][1];
            if (lst.Count == 0 || mn > max)
            {
                lst.Add(new List<int>() { mn ,mx } );
            }
            else
            {
                lst[lst.Count - 1][1] = Math.Max(mx, max);
            }
        }

        return lst;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int intervalsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int intervalsColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> intervals = new List<List<int>>();

        for (int i = 0; i < intervalsRows; i++)
        {
            intervals.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(intervalsTemp => Convert.ToInt32(intervalsTemp)).ToList());
        }

        List<List<int>> result = Result.mergeHighDefinitionIntervals(intervals);

        Console.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));
    }
}
