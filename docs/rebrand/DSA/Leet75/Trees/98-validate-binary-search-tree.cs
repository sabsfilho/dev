﻿/**
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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {

        if (subRoot == null) return true;
        if (root == null) return false;

        if (IsSameTree(root, subRoot)) return true;

        return
            IsSubtree(root.left, subRoot) ||
            IsSubtree(root.right, subRoot);

    }

    bool IsSameTree(TreeNode p, TreeNode q){
        if (p == null && q == null) return true;
        if (p != null && q != null && p.val == q.val) {
            return 
                IsSameTree(p.left, q.left) && 
                IsSameTree(p.right, q.right); 
        }
        return false;
    }
}