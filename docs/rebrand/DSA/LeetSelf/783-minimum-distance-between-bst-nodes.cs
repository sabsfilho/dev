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
    public int MinDiffInBST(TreeNode root) {
        var ns = new List<int>();
        Dfs(ns, root);
        ns.Sort();
        int d = int.MaxValue;
        for(int i=1; i < ns.Count; i++){
            d = Math.Min(d, ns[i]-ns[i-1]);
        }
        return d;
    }

    void Dfs(List<int> ns, TreeNode n) {
        if (n == null) return;
        ns.Add(n.val);
        if (n.left != null) {
            Dfs(ns, n.left);
        }
        if (n.right != null) {
            Dfs(ns, n.right);
        } 
    }
}