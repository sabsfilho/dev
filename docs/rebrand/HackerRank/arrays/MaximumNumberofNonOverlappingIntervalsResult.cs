// Maximum Number of Non-Overlapping Intervals

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



class MaximumNumberofNonOverlappingIntervalsResult
{

    /*
     * Complete the 'maximizeNonOverlappingMeetings' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY meetings as parameter.
     */

    public static int maximizeNonOverlappingMeetings(List<List<int>> meetings)
    {
        if (meetings == null || meetings.Count == 0) return 0;
        
        /*
        1-2
        2-3
        3-4
        1-3
        sort by end
        1-2*2 => count == 0
        2-3*3 => start >= lastEnd
        1-3=
        3-4*4 => start >= lastEnd
        
        */
        
        var intervals = meetings.OrderBy(x=>x[1]).ToList();
        int lastEnd = 0;
        int count = 0;
        foreach(List<int> m in intervals)
        {
            if (count == 0 || m[0] >= lastEnd)
            {
                count++;
                lastEnd = m[1]; 
            }
        }
        
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int meetingsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int meetingsColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> meetings = new List<List<int>>();

        for (int i = 0; i < meetingsRows; i++)
        {
            meetings.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(meetingsTemp => Convert.ToInt32(meetingsTemp)).ToList());
        }

        int result = Result.maximizeNonOverlappingMeetings(meetings);

        Console.WriteLine(result);
    }
}
