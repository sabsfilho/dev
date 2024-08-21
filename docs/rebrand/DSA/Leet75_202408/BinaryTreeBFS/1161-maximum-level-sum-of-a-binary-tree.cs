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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var ns = new List<int>();
        LeafBuild(root1, ns);
        string x1 = string.Join("-", ns);
        ns = new List<int>();
        LeafBuild(root2, ns);
        string x2 = string.Join("-", ns);
        return x1 == x2;
    }
    static void LeafBuild(TreeNode root, List<int> ns) {
        if (root == null) return;
        if (root.left == null && root.right == null) {
            ns.Add(root.val);
            return;
        }

        LeafBuild(root.left, ns);
        LeafBuild(root.right, ns);
    }
}