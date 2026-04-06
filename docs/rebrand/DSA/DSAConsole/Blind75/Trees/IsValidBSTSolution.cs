public class IsValidBSTSolution {
    // Valid Binary Search Tree
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
    public bool IsValidBST(TreeNode root) {
        return IsValid(root, null, null);
    }

    private bool IsValid(TreeNode? node, int? min, int? max) {
        if (node == null) return true;
        if ((min != null && node.val <= min) || (max != null && node.val >= max)) return false;
        return IsValid(node.left, min, node.val) && IsValid(node.right, node.val, max);
    }
}