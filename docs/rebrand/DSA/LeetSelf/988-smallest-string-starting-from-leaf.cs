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
 /*
 t=d;L=;R=
t=e;L=;R=
t=b;L=d;R=e
t=d;L=;R=
t=e;L=;R=
t=c;L=d;R=e
t=a;L=b;R=c
 */
public class Solution {
    public string SmallestFromLeaf(TreeNode root) {        
        var ws = new HashSet<string>();

        Dfs(root, new List<char>(), ws);

        var arr = ws.ToArray();
        Array.Sort(arr);

        return arr[0];
    }

    static void Dfs(TreeNode n, List<char> xs, HashSet<string> ws) {
        if (n == null) return;

        xs.Add((char)('a'+n.val));
        
        List<char> ls = new List<char>(xs);
        List<char> rs = new List<char>(xs);
        Dfs(n.left, ls, ws);
        Dfs(n.right, rs, ws);

        string L = Build(ls);
        string R = Build(rs);
        if (n.left == null && n.right == null) {
            ws.Add(L.CompareTo(R) < 0 ? L : R);
        }
/*
        Console.WriteLine(
            "x=" + string.Join("-", xs.ToArray()) + "#" +
            "L=" + string.Join("-", ls.ToArray()) + "#" + L + "!" +
            "R=" + string.Join("-", rs.ToArray())  + "#" + R + "@" +
            "W=" + string.Join("-", ws.ToArray())
        );
*/
    }
    static string Build(List<char> cs){
        string x = string.Empty;
        foreach(var c in cs) {
            x = string.Concat(c, x);
        }
        return x;
    }
}