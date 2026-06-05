// Two Sum
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



class TwoSumResult
{

    /*
     * Complete the 'findTaskPairForSlot' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY taskDurations
     *  2. INTEGER slotLength
     */

    public static List<int> findTaskPairForSlot(List<int> taskDurations, int slotLength)
    {
        // 7 & 8 crashed, need to optimize
        Dictionary<int, int> dic = new Dictionary<int, int>(); // num, position
        
        for(int i=0; i < taskDurations.Count; i++)
        {
            int num = taskDurations[i];            
            if (dic.TryGetValue(slotLength - num, out int j) && i != j) return new List<int>() { j, i };
            dic[num] = i;
        }
        
        return new List<int>(){ -1, -1 };
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int taskDurationsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> taskDurations = new List<int>();

        for (int i = 0; i < taskDurationsCount; i++)
        {
            int taskDurationsItem = Convert.ToInt32(Console.ReadLine().Trim());
            taskDurations.Add(taskDurationsItem);
        }

        int slotLength = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> result = Result.findTaskPairForSlot(taskDurations, slotLength);

        Console.WriteLine(String.Join("\n", result));
    }
}
