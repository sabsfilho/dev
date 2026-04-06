public class LevelOrderSolution {
    // Binary Tree Level Order Traversal
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
    public List<List<int>> LevelOrder(TreeNode root) {
        /*
        breadth-search
        */
        var lst = new List<List<int>>();
        if (root == null) return lst;
        
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0)
        {
            var q2 = new Queue<TreeNode>();
            var xs = new List<int>();
            while (q.Count > 0)
            {
                var n = q.Dequeue();
                xs.Add(n.val);

                if (n.left != null) q2.Enqueue(n.left);
                if (n.right != null) q2.Enqueue(n.right);
            }
            lst.Add(xs);
            q = q2;
        }

        return lst;
        
    }
}
