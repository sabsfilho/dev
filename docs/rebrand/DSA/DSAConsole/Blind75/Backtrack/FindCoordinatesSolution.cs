public class FindCoordinatesSolution
{
    public int[][]? FindCoordinates(int[][] map, int[] nums)
    {
        List<int[]> coords = new List<int[]>();

        for (int row = 0; row < map.Length; row++)
            for (int col = 0; col < map[row].Length; col++)
                if (Walk(map, nums, row, col, coords, new List<int[]>()))
                    return coords.ToArray();

        return null;

    }

    bool Walk(int[][] map, int[] target, int row, int col, List<int[]> coords, List<int[]> auxcoords)
    {
        if (row < 0 || row == map.Length) return false;
        if (col < 0 || col == map[row].Length) return false;

        int val = map[row][col];
        if (val != target[0]) return false;

        int[]? newTarget = null;
        if (target.Length > 1)
        {
            newTarget = target.Skip(1).ToArray();
        }

        map[row][col] = int.MaxValue;

        var newAuxCoords = auxcoords.ToList();

        newAuxCoords.Add(new int[] { row, col });

        bool found =
            newTarget == null ||
            Walk(map, newTarget, row, col + 1, coords, newAuxCoords) ||
            Walk(map, newTarget, row + 1, col, coords, newAuxCoords) ||
            Walk(map, newTarget, row, col - 1, coords, newAuxCoords) ||
            Walk(map, newTarget, row - 1, col, coords, newAuxCoords);

        if (newTarget == null)
            coords.AddRange(newAuxCoords);

        map[row][col] = val; //backtracking

        return found;
    }

    public static void Print()
    {
        var map = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 8, 9, 10},
        };

        var targets = new int[][]
        {
            new int[] { 2, 5, 4 },
            new int[] { 1, 5, 4 },
            new int[] { 5, 9, 10 },
            new int[] { 5, 9, 10, 6 },
        };

        foreach (var t in targets)
        {
            Print(map, t);
        }

    }

    private static void Print(int[][] map, int[] ts)
    {
        var cs = new FindCoordinatesSolution().FindCoordinates(map, ts);

        Console.WriteLine($"[{string.Join(", ", ts)}]");

        if (cs == null)
        {
            Console.WriteLine("not found");
        }
        else
        {
            foreach (var c in cs)
            {
                Console.WriteLine(c == null ? "not found" : $"( {c[0]},{c[1]} )");
            }
        }
        Console.WriteLine("###");
    }
}