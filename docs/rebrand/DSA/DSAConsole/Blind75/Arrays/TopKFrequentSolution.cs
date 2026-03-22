namespace Blind75;
public class TopKFrequentSolution {
    public int[] TopKFrequent(int[] nums, int k) {
        /*
descending rank limited to first k elements
group elements count by element
order descending by count
take first k elements
use dictionary and linq
        */
        var dic = new Dictionary<int, int>();

        foreach(int n in nums)
        {
            if (!dic.ContainsKey(n))
            {
                dic.Add(n, 1);
            }
            else 
            {
                dic[n]++;
            }
        }

        return dic
            .OrderByDescending(x => x.Value)
            .Select(x => x.Key)
            .Take(k)
            .ToArray();
        
    }

    public static void Print()
    {
        var x = new TopKFrequentSolution();
        var testCase1 = new int[] {1,2,2,3,3,3};
        int k =2;
        var zs = x.TopKFrequent(testCase1, k);
        foreach (var z in zs)
        {
            Console.WriteLine(string.Join(",", z));
        }        
    }
}
