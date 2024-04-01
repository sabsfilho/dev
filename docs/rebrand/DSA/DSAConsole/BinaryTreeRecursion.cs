void Main()
{
        
        var xs = new int[]{ 1, 2, 13, 24, 25, 36, 37 };
		
		TreeNode n = null;
		foreach(var x in xs){
			var r = Insert(n, x);
			if (n == null) n = r;
		}
		n.Dump();
}

// Define other methods and classes here

    class TreeNode{
        public TreeNode left;
        public TreeNode right;
        public int data;

        public TreeNode(int data){
            this.data = data;
            left = null;
            right = null;
        }
    }
	
		static TreeNode Insert(TreeNode tn, int v){
			if (tn == null) {
				tn = new TreeNode(v);
			}
			else if (v < tn.data){
				tn.left = Insert(tn.left, v);
			}
			else if (v > tn.data){
				tn.right = Insert(tn.right, v);
			}
			return tn;
		}
		
		static void PreOrder(TreeNode n){
			if (n == null) return;
			Console.WriteLine(n + " ");
			PreOrder(n.left);
			PreOrder(n.right);
		}
		static void InOrder(TreeNode n){
			if (n == null) return;
			InOrder(n.left);
			Console.WriteLine(n + " ");
			InOrder(n.right);
		}
		static void PostOrder(TreeNode n){
			if (n == null) return;
			PostOrder(n.left);
			PostOrder(n.right);
			Console.WriteLine(n + " ");
		}