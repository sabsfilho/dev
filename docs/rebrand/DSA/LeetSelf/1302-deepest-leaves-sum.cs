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
    
    public int DeepestLeavesSum(TreeNode root) {
        Dictionary<int, int> d = new Dictionary<int, int>(); //level,sum
        int level = PreOrder(root, d, 0);
        return d[level];
    }
    int PreOrder(TreeNode n, Dictionary<int, int> d, int level){
        if (n == null) return 0;
        if (n.left == null && n.right == null) {
            if (d.ContainsKey(level)){
                d[level]+=n.val;
            }
            else {
                d[level]=n.val;
            }
        }
        else {
            level++;
        }
        int l = PreOrder(n.left, d, level);
        int r = PreOrder(n.right, d, level);
        return Math.Max(level, Math.Max(l,r));
    }
}