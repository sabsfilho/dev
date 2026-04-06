public class KthSmallestSolution {
    // Kth Smallest Integer in BST
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
    public int KthSmallest(TreeNode root, int k) {
        var lst = new List<int>();
        AddValue(root, lst);
        lst.Sort();
        return lst[k-1];
    }
    void AddValue(TreeNode? root, List<int> lst)
    {
        if (root == null) return;
        lst.Add(root.val);
        AddValue(root.left, lst);
        AddValue(root.right, lst);
    }
}
