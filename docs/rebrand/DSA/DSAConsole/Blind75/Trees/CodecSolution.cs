public class CodecSolution {
    // Serialize and Deserialize Binary Tree
 public class TreeNode {
      public int val;
      public TreeNode? left;
      public TreeNode? right;
      public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }

    // Encodes a tree to a single string.
    public string Serialize(TreeNode? root) {
        /*
        binary tree
        preorder
        print
        depth-left
        depth-right

        print null => N
        */
        if (root == null) return "N";

        int v = root.val;
        string left = Serialize(root.left);
        string right = Serialize(root.right);

        return $"{v},{left},{right}";
    }

    // Decodes your encoded data to tree.
    public TreeNode? Deserialize(string data) {
        /*
        tree.left = BuildNode
        tree.right = BuildNode
        
        N=>skip

        */
        // Console.WriteLine(data);
        var xs = data.Split(',');
        int i = -1;
        var root = BuildNode(xs, ref i);
        return root;        
    }
    TreeNode? BuildNode(string[] xs, ref int i)
    {
        i++;
        if (xs[i] == "N") return null;

        var node = new TreeNode(int.Parse(xs[i]));
        node.left = BuildNode(xs, ref i);
        node.right = BuildNode(xs, ref i);
        
        return node;
    }

}
