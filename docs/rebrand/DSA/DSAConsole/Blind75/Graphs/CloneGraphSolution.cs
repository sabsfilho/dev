public class CloneGraphSolution {
    // Clone Graph


// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}

    public Node? CloneGraph(Node node) {
        return CloneGraph(node, new Dictionary<int, Node>()); 
    }
    Node? CloneGraph(Node node, Dictionary<int, Node> visited) {

        if (node == null) return null;

        if (visited.ContainsKey(node.val)) return visited[node.val];

        var root = new Node(node.val);

        visited.Add(node.val, root);
        
        foreach(var n in node.neighbors)
        {
            var n2 = CloneGraph(n, visited)!;

            root.neighbors.Add(n2);
        }

        return root;        
    }

}