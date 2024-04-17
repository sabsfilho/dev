public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {

        var lst = new List<IList<int>>();
        
        F(candidates, lst, new List<int>(), 0, 0, target);

        return lst;
    }

    static void F(int[] cs, List<IList<int>> lst, List<int> ns, int sum, int i, int t) {
        if (sum == t){
            lst.Add(ns.ToArray());
            //Console.WriteLine("INSERT;ns="+string.Join(";",ns));
            return;
        }
        if (i >= cs.Length || sum > t) return;
        int c = cs[i];

        var ns2 = ns.ToList();
        ns2.Add(c);
        //Console.WriteLine("sum="+sum+";c="+c+";i="+i+";t="+t+";ns="+string.Join(";",ns));
        F(cs, lst, ns2, sum + c, i, t);
        F(cs, lst, ns, sum, i+1, t);
    }
}