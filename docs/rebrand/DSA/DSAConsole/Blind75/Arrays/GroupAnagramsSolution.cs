namespace Blind75;
public class GroupAnagramsSolution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        /*
dic[ k=ordered string, v=list-of-anagrams ]
loop strs , each str, ordered str into k, if k not exists on dic then create list into dic, add str into list
        */

        string BuildOrderedKey(string v)
        {
            return new String(v.ToCharArray().OrderBy(x => x).ToArray());
        }

        var dic = new Dictionary<string, List<string>>();

        foreach(var str in strs)
        {
            string k = BuildOrderedKey(str);
            if (!dic.ContainsKey(k))
            {
                var lst = new List<string>();
                dic.Add(k, lst);
            }
            dic[k].Add(str);
        }
        
        return dic.Values.ToList();
    }

    public static void Print()
    {
        var x = new GroupAnagramsSolution();
        var testCase1 = new string[] {"act","pots","tops","cat","stop","hat"};
        var zs = x.GroupAnagrams(testCase1);
        foreach (var z in zs)
        {
            Console.WriteLine(string.Join(",", z));
        }        
    }
}
