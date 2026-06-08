// Place N Cameras Without Conflict on Blocked Grid
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



class PlaceNCamerasWithoutConflictonBlockedGridResult
{

    /*
     * Complete the 'canPlaceSecurityCameras' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts following parameters:
     *  1. INTEGER N
     *  2. 2D_INTEGER_ARRAY grid
     */

    public static bool canPlaceSecurityCameras(int N, List<List<int>> grid)
    {
        if (grid == null || grid.Count == 0 || N == 0) return false;
                
        var blockedCols = new HashSet<int>();
        var blockedDownDiags = new HashSet<int>(); // col-row
        var blockedUpDiags = new HashSet<int>(); // col+row
        var places = new List<string>(); // place = row:col
        Search(grid, places, blockedCols, blockedDownDiags, blockedUpDiags, 0, N);
         //Console.WriteLine(n);
         //foreach(var g in grid)
           // Console.WriteLine(string.Join(" ", g));
         //foreach(var p in places)
           // Console.WriteLine(p);
           
        return places.Count == N;
    }
    
    static bool Search(List<List<int>> grid, List<string> places, HashSet<int> blockedCols, HashSet<int> blockedDownDiags, HashSet<int> blockedUpDiags, int row, int n)
    {
        if (row == n) return true;
        
        int rows = grid.Count;
        int cols = grid[0].Count;
        
        for(int col = 0; col < cols; col++)
        {
            if (blockedCols.Contains(col)) continue;
            if (blockedDownDiags.Contains(col-row)) continue;
            if (blockedUpDiags.Contains(col+row)) continue;
                        
            int cell = grid[row][col];
            if (cell == 1) continue; // blocked
            
            blockedCols.Add(col);
            blockedDownDiags.Add(col-row);
            blockedUpDiags.Add(col+row);
            
            string place = $"{row}:{col}";
            places.Add(place);
            
            bool found = Search(grid, places, blockedCols, blockedDownDiags, blockedUpDiags, row + 1, n);
            if (found) return true;
            
            //clear backtrack
            blockedCols.Remove(col);
            blockedDownDiags.Remove(col-row);
            blockedUpDiags.Remove(col+row);
            places.Remove(place);
        }
        
        return false;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        int gridRows = Convert.ToInt32(Console.ReadLine().Trim());
        int gridColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> grid = new List<List<int>>();

        for (int i = 0; i < gridRows; i++)
        {
            grid.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(gridTemp => Convert.ToInt32(gridTemp)).ToList());
        }

        bool result = Result.canPlaceSecurityCameras(N, grid);

        Console.WriteLine((result ? 1 : 0));
    }
}
