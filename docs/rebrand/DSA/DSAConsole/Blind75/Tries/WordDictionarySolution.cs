public class WordDictionarySolution {
//Design Add and Search Word Data Structure
    class Trie
    {
        public Dictionary<char, Trie> map;
        public bool tail;

        public Trie()
        {
            map = new Dictionary<char, Trie>();
            tail = false;
        }
    }

    Trie? root;
    
    public void AddWord(string word) {
        if (string.IsNullOrEmpty(word)) return; 

        if (root == null) root = new Trie();

        Trie curr = root;

        foreach(char c in word)
        {
            if (!curr.map.TryGetValue(c, out Trie? t))
            {
                t = new Trie();
                curr.map[c] = t;
            }
                curr = t;
        }
        curr.tail = true;
    }
    
    public bool Search(string word) {
        return Search(word, root);
    }
    
    static bool Search(string word, Trie? r) {
        if (r == null) return false;
        if (string.IsNullOrEmpty(word)) return r.tail;

        Trie curr = r;
        //Console.WriteLine(curr.map.Count);

        for(int i=0; i < word.Length; i++)
        {
            char c = word[i];
                //Console.WriteLine(c);
            if (c == '.') {
                foreach(var m in curr.map.Values)
                {
                    if (Search(word.Substring(i+1), m)) return true;
                }
                return false;
            }
            if (curr.map.TryGetValue(c, out Trie? t))
            {
                curr = t;
            }
            else {
                //Console.WriteLine('F');
                return false;
            }
        }
        
        return curr.tail;
    }
}
