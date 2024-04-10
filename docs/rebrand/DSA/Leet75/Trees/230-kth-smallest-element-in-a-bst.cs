/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        var lst = new List<int>();
        DoBST(root, lst);
        lst.Sort();
        return lst[k-1];
    }
    static void DoBST(TreeNode n, List<int> lst){
        if (n == null) return;
        lst.Add(n.val);
        DoBST(n.left, lst);
        DoBST(n.right, lst);
    }
}