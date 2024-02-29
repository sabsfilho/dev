void Main()
{	
	var t = new Trie();
	t.Insert("dog");
	t.Dump();

}

class Trie {
	public class TrieNode {
		public TrieNode[] Children { get; set; }
		public bool IsWord { get; set; }
		
		public TrieNode() {
			Children = new TrieNode[26]; // a-z
			IsWord = false;
		}
	}
	
	public TrieNode root;
	
	public Trie() {
		root = new TrieNode();
	}
	
	public void Insert(string word) {
		TrieNode curr = root;
		for(int i = 0; i < word.Length; i++) {
			int idx = word[i] - 'a';
			var n = curr.Children[idx];
			if (n == null) {
				n = new TrieNode();
				curr.Children[idx] = n;
			}
			curr = n;
		}
		curr.IsWord = true;
	}
	
	public bool Search(string word) {
		return false;
	}
}