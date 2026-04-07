public class PathSumSolution {
    // Binary Tree Maximum Path Sum
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
    public int MaxPathSum(TreeNode root) {
        if (root == null) return 0;
        int max = int.MinValue;
        PathSum(root, ref max);
        return max;
    }
    int PathSum(TreeNode? root, ref int max) {
        if (root == null) return 0;
        int ml = PathSum(root.left, ref max);
        int mr = PathSum(root.right, ref max);
        int v = root.val;
        if (ml > 0) v += ml;
        if (mr > 0) v += mr;
        max = Math.Max(v, max);
        return root.val + Math.Max(0, Math.Max(ml, mr));
    }
}