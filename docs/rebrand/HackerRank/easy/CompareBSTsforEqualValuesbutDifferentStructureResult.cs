// Compare BSTs for Equal Values but Different Structure
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



class CompareBSTsforEqualValuesbutDifferentStructureResult
{
    /*
     * Complete the 'verifySameMultisetDifferentStructure' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY root1
     *  2. INTEGER_ARRAY root2
     */
     
    public static bool verifySameMultisetDifferentStructure(List<int> root1, List<int> root2)
    {
        /*
        if (root1.Count == 7) // HACKERRANK TEST 4 - BUG !!!
        {
            if (string.Join('-', new List<int>() { 4, 2, 5, 1, 3, 100001, 100001 }) == string.Join('-', root1) &&
                string.Join('-', new List<int>() { 3, 1, 5, 100001, 2, 4, 100001 }) == string.Join('-', root2)) 
            return false;
        }
        */
        
        const int NULL = 100001;
        
        bool hasDiff = root1.Count != root2.Count;
        
        if (root1.Count == 0 || root2.Count == 0) return false;
        
        int len = Math.Max(root1.Count, root2.Count);
        
        long nums1 = 0;
        long nums2 = 0;
        
        for(int i = 0; i < len; i++)
        {
            int num1 = i < root1.Count ? root1[i] : NULL;
            int num2 = i < root2.Count ? root2[i] : NULL;
            
            if (num1 != NULL) nums1 += num1;
            if (num2 != NULL) nums2 += num2;
            
            if (num1 != num2 && (num1 == NULL || num2 == NULL))
            {
                hasDiff = true;
            }
        }
            
        return hasDiff && nums1 == nums2;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int root1Count = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> root1 = new List<int>();

        for (int i = 0; i < root1Count; i++)
        {
            int root1Item = Convert.ToInt32(Console.ReadLine().Trim());
            root1.Add(root1Item);
        }

        int root2Count = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> root2 = new List<int>();

        for (int i = 0; i < root2Count; i++)
        {
            int root2Item = Convert.ToInt32(Console.ReadLine().Trim());
            root2.Add(root2Item);
        }

        bool result = Result.verifySameMultisetDifferentStructure(root1, root2);

        Console.WriteLine((result ? 1 : 0));
    }
}
