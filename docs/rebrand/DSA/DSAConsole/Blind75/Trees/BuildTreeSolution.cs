public class BuildTreeSolution {
    // Construct Binary Tree from Preorder and Inorder Traversal
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
    public TreeNode? BuildTree(int[] preorder, int[] inorder) {
        /*

        Binary Tree 

        preorder = 1,2,3,4
        Print
        ReadNode
        ReadNode
        preorder first is the root = 1

        inorder = 2,1,3,4
        ReadNode
        Print
        ReadNode
        inorder partition root by left and right
        left[2]
        right[3,4]

        must skip the root before recursion
        */
        if (preorder == null || inorder == null) return null;
        if (preorder.Length < 1 || inorder.Length < 1) return null;

        var root = new TreeNode(preorder[0]);
        int rootPos = Array.IndexOf(inorder, preorder[0]);
        if (rootPos == -1) return null;

        /* partition */
        root.left = BuildTree(Slice(preorder, 1, rootPos + 1), Slice(inorder, 0, rootPos));
        root.right = BuildTree(Slice(preorder, rootPos + 1, preorder.Length), Slice(inorder, rootPos + 1, inorder.Length));

        return root;
    }
    
    int[] Slice(int[] arr, int start, int end)
    {
        if (start >= end) return new int[0];
        return arr.Skip(start).Take(end - start).ToArray();
    }
}