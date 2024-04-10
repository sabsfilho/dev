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
    public IList<IList<int>> LevelOrder(TreeNode root) {

        var lst = new List<IList<int>>();

        DoBFS(root, lst, 0);

        return lst;        
    }

    static void DoBFS(TreeNode root, List<IList<int>> lst, int level){
        if (root == null) return;
        List<int> ts = null;
//Console.WriteLine("n="+root.val+";q="+lst.Count+";l="+level);
        if (level >= lst.Count) {
            ts = new List<int>();
            lst.Add(ts);
        }
        else {
            ts = lst[level] as List<int>;
        }
        ts.Add(root.val);
        DoBFS(root.left, lst, level + 1);
        DoBFS(root.right, lst, level + 1);
    }
}