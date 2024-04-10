/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) return null;
        if (root.val == p.val || root.val == q.val) return root;
        if(p.val < root.val && q.val < root.val)
            return LowestCommonAncestor(root.left, p, q);
        if (p.val > root.val && q.val > root.val)
            return LowestCommonAncestor(root.right, p, q);
        if(p.val < q.val) {
            if (
                LowestCommonAncestor(root.left, p, p) != null &&
                LowestCommonAncestor(root.right, q, q) != null
            ){
                return root;
            }
        }
        else {
            if (
                LowestCommonAncestor(root.right, p, p) != null &&
                LowestCommonAncestor(root.left, q, q) != null
            ){
                return root;
            }
        }
        return null;
    }
}