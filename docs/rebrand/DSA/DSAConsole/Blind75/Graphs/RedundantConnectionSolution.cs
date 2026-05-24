// Redundant Connection

public class RedundantConnectionSolution {
    public int[] FindRedundantConnection(int[][] edges) {
        int n = edges.Length;
        int[] parent = new int[n + 1];
        for (int i = 1; i <= n; i++) parent[i] = i;

        foreach (int[] edge in edges) {
            int rootA = Find(parent, edge[0]);
            int rootB = Find(parent, edge[1]);
            if (rootA == rootB) {
                return edge;
            }
            parent[rootA] = rootB;
        }

        return new int[2];
    }

    private int Find(int[] parent, int i) {
        if (parent[i] == i) return i;
        return parent[i] = Find(parent, parent[i]);
    }
}