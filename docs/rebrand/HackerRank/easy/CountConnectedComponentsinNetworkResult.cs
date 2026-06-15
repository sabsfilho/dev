// Count Connected Components in Network
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



class CountConnectedComponentsinNetworkResult
{

    /*
     * Complete the 'countIsolatedCommunicationGroups' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. 2D_INTEGER_ARRAY links
     *  2. INTEGER n
     */

    public static int countIsolatedCommunicationGroups(List<List<int>> links, int n)
    {   
        if (n < 2 || links.Count == 0) return 0;
        
        var foundGrps = new Stack<HashSet<int>>();
        
        var found = new HashSet<int>();
        
        foreach(var link in links)
        {
            var comps = new HashSet<int>(link);
            foreach(var c in comps) found.Add(c);
            
            foundGrps = MergeGroups(foundGrps, comps);
        }
        
        int notFound = 0; // all computers matter
        for(int i=0; i<n; i++)
            if (!found.Contains(i)) notFound++;
        
         //foundGrps.ToList().ForEach(g=>Console.WriteLine(string.Join(",", g)));
        
        return foundGrps.Count + notFound;
    }
    
    static Stack<HashSet<int>> MergeGroups(Stack<HashSet<int>> grps, HashSet<int> grp)
    {
        var mergedGrps = new Stack<HashSet<int>>();
        
        bool found = false;
        
        while(grps.Count > 0)
        {
            var g = grps.Pop();
            if (grp.Any(x=>g.Contains(x)))
            {
                foreach(var x in grp) g.Add(x); // merging
                
                var mergedFoundGrps = MergeGroups(grps, g);
                while(mergedFoundGrps.Count > 0)
                    mergedGrps.Push(mergedFoundGrps.Pop());
                    
                found = true;
                
                break;
            }
            mergedGrps.Push(g);
        }
        
        if (!found)
            mergedGrps.Push(grp);
        
        return mergedGrps;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int linksRows = Convert.ToInt32(Console.ReadLine().Trim());
        int linksColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> links = new List<List<int>>();

        for (int i = 0; i < linksRows; i++)
        {
            links.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(linksTemp => Convert.ToInt32(linksTemp)).ToList());
        }

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.countIsolatedCommunicationGroups(links, n);

        Console.WriteLine(result);
    }
}
