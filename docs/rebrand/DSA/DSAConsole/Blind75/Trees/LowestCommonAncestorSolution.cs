public class LowestCommonAncestorSolution {
    // Lowest Common Ancestor in Binary Search Tree
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
    public TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode? p, TreeNode? q) {
        if (root == null || (p != null && root.val == p.val) || (q != null && root.val == q.val)) return root;
        
        if (p != null && p.val < root.val && q != null && q.val < root.val) return LowestCommonAncestor(root.left, p, q);
        if (p != null && p.val > root.val && q != null && q.val > root.val) return LowestCommonAncestor(root.right, p, q);
        
        return root;
    }
}