// Detect Cycle in Module Dependency Graph
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



class DetectCycleinModuleDependencyGraphResult
{

    /*
     * Complete the 'hasCircularDependency' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY dependencies
     */

    public static bool hasCircularDependency(int n, List<List<int>> dependencies)
    {
        var links = new Dictionary<int, List<int>>(); // linkList: val, nexts
        
        foreach(var d in dependencies)
        {
            int v = d[0];
            int nxt = d[1];
            if (nxt == v) return true;
            
            if (SearchCycle(links, v, nxt, new HashSet<string>())) return true;
                        
            if (links.ContainsKey(v)) links[v].Add(nxt);
            else links.Add(v, new List<int>() { nxt });
        }
        
        return false;
    }
    
    static bool SearchCycle(Dictionary<int,List<int>> links, int start, int nxt, HashSet<string> visited)
    {
        string k = $"{start}-{nxt}";
        
        if (visited.Contains(k)) return false;
        
        if (links.TryGetValue(nxt, out List<int>? nxts) && nxts.Contains(start)) return true;
        
        visited.Add(k);
        
        if (nxts == null) return false;
        
        foreach(var v in nxts)
        {
            if (SearchCycle(links, start, v, visited)) return true;
        }
        
        return false;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int dependenciesRows = Convert.ToInt32(Console.ReadLine().Trim());
        int dependenciesColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> dependencies = new List<List<int>>();

        for (int i = 0; i < dependenciesRows; i++)
        {
            dependencies.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(dependenciesTemp => Convert.ToInt32(dependenciesTemp)).ToList());
        }

        bool result = Result.hasCircularDependency(n, dependencies);

        Console.WriteLine((result ? 1 : 0));
    }
}
