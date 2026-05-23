public class GraphValidTreeSolution {
    //Graph Valid Tree
    /*
    0
    1 - 2 - 3
    4
    
    0
    1
    2 - 3 - 4
    3

    2-3
    0
    1
    4

    node => children
    child must have a single parent
    */
    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length == 0) return true;
        if (edges.Length != n - 1) return false;
        var nodes = new Dictionary<int, List<int>>();
        foreach(var c in edges)
        {
            int root = c[0];
            int child = c[1];
            if(!nodes.TryGetValue(root, out List<int>? cs))
            {
                cs = new List<int>();
                nodes.Add(root, cs);
            }
            cs.Add(child);
            if(!nodes.TryGetValue(child, out List<int>? cs2))
            {
                cs2 = new List<int>();
                nodes.Add(child, cs2);
            }
            cs2.Add(root);
        }

        var visited = new HashSet<int>();

        if (!CheckNode(nodes, 0, visited, -1)) return false;

        return visited.Count == n;
    }

    bool CheckNode(Dictionary<int, List<int>> nodes, int k, HashSet<int> visited, int parent)
    {

        if (!nodes.ContainsKey(k)) return true;
        if (visited.Contains(k)) return false;
        visited.Add(k);
        var cs = nodes[k];
        foreach(int p in cs)
        {
            if (p == parent) continue;
            if (!CheckNode(nodes, p, visited, k)) return false;
        }
        return true;
    }
}
