// Height of Binary Search Tree
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



class HeightofBinarySearchTreeResult
{

    /*
     * Complete the 'getBinarySearchTreeHeight' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY values
     *  2. INTEGER_ARRAY leftChild
     *  3. INTEGER_ARRAY rightChild
     */

    public static int getBinarySearchTreeHeight(List<int> values, List<int> leftChild, List<int> rightChild)
    {
        if (values.Count == 0) return 0;
        
        int h = 0;
        
        var nodes = new Queue<int>();
        
        nodes.Enqueue(0);
        while (nodes.Count > 0)
        {
            var innerNodes = new Queue<int>();
            
            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();

                if (node < leftChild.Count)
                {
                    int L = leftChild[node];
                    if (L > -1) innerNodes.Enqueue(L);
                }
                if (node < rightChild.Count)
                {
                    int R = rightChild[node];
                    if (R > -1) innerNodes.Enqueue(R);
                }
            }
            nodes = innerNodes;
            h++;
        }
        
        return h;
    }
    
    static int getBinarySearchTreeHeightForBalancedTree(List<int> values, List<int> leftChild, List<int> rightChild)
    {
        int h = 0;
        int p = 1;
        while(p <= values.Count)
        {
            p = (int) Math.Pow(2, h) - 1; //1,2,4,8 elements per level
            
            if (p >= values.Count) break;
            
            h++;
        }
        
        return h;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int valuesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> values = new List<int>();

        for (int i = 0; i < valuesCount; i++)
        {
            int valuesItem = Convert.ToInt32(Console.ReadLine().Trim());
            values.Add(valuesItem);
        }

        int leftChildCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> leftChild = new List<int>();

        for (int i = 0; i < leftChildCount; i++)
        {
            int leftChildItem = Convert.ToInt32(Console.ReadLine().Trim());
            leftChild.Add(leftChildItem);
        }

        int rightChildCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> rightChild = new List<int>();

        for (int i = 0; i < rightChildCount; i++)
        {
            int rightChildItem = Convert.ToInt32(Console.ReadLine().Trim());
            rightChild.Add(rightChildItem);
        }

        int result = Result.getBinarySearchTreeHeight(values, leftChild, rightChild);

        Console.WriteLine(result);
    }
}
