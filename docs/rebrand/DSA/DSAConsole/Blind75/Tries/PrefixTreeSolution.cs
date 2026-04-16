public class PrefixTreeSolution {
//Implement Trie (Prefix Tree)
    class Trie
    {
        public Dictionary<char, Trie> map = new Dictionary<char, Trie>();
        public bool WordEnd;
    }

    Trie root;

    public PrefixTreeSolution() {
        root = new Trie();
    }
    
    public void Insert(string word) {
        var curr = root;
        foreach(char c in word)
        {
            if (!curr.map.TryGetValue(c, out Trie? t))
            {
                t = new Trie();
                curr.map[c] = t;
            }
            curr = t;
        }
        curr.WordEnd = true;
    }
    
    public bool Search(string word) {
 return StartsWith(word, true);       
    }
    
    public bool StartsWith(string prefix) {
        return StartsWith(prefix, false);
    }
    
    bool StartsWith(string prefix, bool all) {
        var curr = root;
        foreach(char c in prefix)
        {
            if (!curr.map.TryGetValue(c, out Trie? t))
            {
                return false;
            }
            curr = t;
        }
        return all ? curr.WordEnd : true;
    }
}
