// Target Index Search

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



class TargetIndexSearchResult
{

    /*
     * Complete the 'binarySearch' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY nums
     *  2. INTEGER target
     */

    public static int binarySearch(List<int> nums, int target)
    {
        // Console.WriteLine(string.Join(',', nums));
        // Console.WriteLine(target);
        int L = 0;
        int R = nums.Count - 1;
        
        while(L <= R)
        {
            int mid = (L + R) / 2;
            int m = nums[mid];
            if (target == m)
            {
                return mid;
            }
            if (target > m)
            {
                L = mid + 1;
            }
            else {
                R = mid - 1;
            }
        }
        
        return -1;

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

        int result = Result.binarySearch(nums, target);

        Console.WriteLine(result);
    }
}
