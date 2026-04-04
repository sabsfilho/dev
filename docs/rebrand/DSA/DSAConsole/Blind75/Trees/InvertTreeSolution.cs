public class InvertTreeSolution {

//Definition for a binary tree node.
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

    public TreeNode? InvertTree(TreeNode root) {
        if (root == null) return null;
        var tmp = root.left;
        root.left = root.right;
        root.right = tmp;
        if (root.left != null)
            InvertTree(root.left);
        if (root.right != null)
            InvertTree(root.right);
        return root;        
    }
}
