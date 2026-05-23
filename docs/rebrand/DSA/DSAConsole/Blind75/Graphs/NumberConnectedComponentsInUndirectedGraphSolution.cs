public class NumberConnectedComponentsInUndirectedGraphSolution {
    // Number of Connected Components in an Undirected Graph
    public int CountComponents(int n, int[][] edges) {
        if (n == 0) return 0;

        var nodes = new Dictionary<int, List<int>>();
        var visited = new HashSet<int>();

        foreach(int[] edge in edges)
        {
            if (!nodes.ContainsKey(edge[0])) nodes[edge[0]] = new List<int>();
            if (!nodes.ContainsKey(edge[1])) nodes[edge[1]] = new List<int>();
            nodes[edge[0]].Add(edge[1]);
            nodes[edge[1]].Add(edge[0]);
        }
        
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            if (!visited.Contains(i))
            {
                count++;
                Traverse(i, nodes, visited);
            }
        }

        return count;
    }

    void Traverse(int node, Dictionary<int, List<int>> nodes, HashSet<int> visited)
    { 
        if (visited.Contains(node)) return;
        visited.Add(node);
        if (nodes.TryGetValue(node, out List<int>? children))
        {
            foreach(int child in children) Traverse(child, nodes, visited);
        }
    }
}