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
    public TreeNode SearchBST(TreeNode root, int val) {
        return Search(root, val);
    }
    static TreeNode Search(TreeNode root, int val) {
        if (root == null) return null;
        if (root.val == val) return root;
        var l = Search(root.left, val);
        if (l != null) return l;
        var r = Search(root.right, val);
        if (r != null) return r;
        return null;
    }
}