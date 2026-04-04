public class EqualsTreeSolution {
    //Subtree of Another Tree
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
    bool EqualsTree(TreeNode? p, TreeNode? q)
    {
        if (p==null && q==null) return true;
        if (p==null || q==null) return false;
        if (p.val!=q.val) return false;

        return EqualsTree(p.left, q.left) && EqualsTree(p.right, q.right);
    }
    public bool IsSubtree(TreeNode? root, TreeNode? subRoot) {
        if (root == null) return false;
        
        return 
            EqualsTree(root, subRoot) ||
            IsSubtree(root.left, subRoot) ||
            IsSubtree(root.right, subRoot);
    }
}