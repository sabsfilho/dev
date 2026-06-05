// Remove Elements Within K Distance
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



class RemoveElementsWithinKDistanceResult
{

    /*
     * Complete the 'debounceTimestamps' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY timestamps
     *  2. INTEGER K
     */

    public static int debounceTimestamps(List<int> timestamps, int K)
    {
        int length = timestamps.Count;
        
        int left = 0;
        
        for(int right = 1; right < timestamps.Count; right++)
        {
            int distance = timestamps[right] - timestamps[left];
            
            if (distance < K) length--;
            else left = right;                    
        }
        
        return length;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int timestampsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> timestamps = new List<int>();

        for (int i = 0; i < timestampsCount; i++)
        {
            int timestampsItem = Convert.ToInt32(Console.ReadLine().Trim());
            timestamps.Add(timestampsItem);
        }

        int K = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.debounceTimestamps(timestamps, K);

        Console.WriteLine(result);
    }
}
