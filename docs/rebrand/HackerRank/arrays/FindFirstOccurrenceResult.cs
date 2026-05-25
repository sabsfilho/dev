// Find First Occurrence

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



class FindFirstOccurrenceResult
{

    /*
     * Complete the 'findFirstOccurrence' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY nums
     *  2. INTEGER target
     */

    public static int findFirstOccurrence(List<int> nums, int target)
    {
        if (nums == null || nums.Count == 0) return -1;
        if (target < nums[0]) return -1;
        int len = nums.Count;
        if (target > nums[len-1]) return -1;
        if (len == 1) return target == nums[0] ? 0 : -1;
        
        int result = -1;
        
        int L = 0;
        int R = len - 1;
        
        while(L <= R)
        {
            int M = (L + R) / 2;
            int mid = nums[M];
            if (target == mid)
            {
                result = M;
                R = M - 1;
            }
            else if (mid < target)
            {
                L = M + 1;
            }            
            else 
            {
                R = M - 1;
            }            
        }
        
        return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int numsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> nums = new List<int>();

        for (int i = 0; i < numsCount; i++)
        {
            int numsItem = Convert.ToInt32(Console.ReadLine().Trim());
            nums.Add(numsItem);
        }

        int target = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.findFirstOccurrence(nums, target);

        Console.WriteLine(result);
    }
}
