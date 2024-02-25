
class BinaryTreeLinkedList{

    class TreeNode{
        public TreeNode? left;
        public TreeNode? right;
        public int data;

        public TreeNode(int data){
            this.data = data;
            left = null;
            right = null;
        }
    }

    static TreeNode Load(int[] xs, TreeNode node)
    {
        TreeNode first = node;
        TreeNode last = node;
        foreach(var x in xs) {
            var n = new TreeNode(x);
            if (last != null){
                if (last.left == null){
                    last.left = n;
                }
                else {
                    if (last.right == null){
                        last.right = n;
                    }
                    else {
                        last = last.left;
                    }
                }
            }
            else {
                first = n;
            }
            last = n;
        }
        return first;
    }

    static void PrintDFS_PreOrder_Recursive(TreeNode n){
        //DEEP
        if (n == null) return;
        Console.WriteLine(n.data);
        PrintDFS_PreOrder_Recursive(n.left);
        PrintDFS_PreOrder_Recursive(n.right);
    }

    static void PrintDFS_PreOrder_Stack(TreeNode n){
        if (n == null) return;
        var lifo = new Stack<TreeNode>();
        lifo.Push(n);
        while(lifo.Count > 0){
            var t = lifo.Pop();
            Console.WriteLine(t.data);
            if (t.right != null) {
                lifo.Push(t.right);
            }
            if (t.left != null) {
                lifo.Push(t.left);
            }            
        }
    }

    static void PrintDFS_InOrder_Stack(TreeNode n){
        if (n == null) return;
        var lifo = new Stack<TreeNode>();
        var t = n;
        while(lifo.Count > 0 || t != null) {
            if (t != null) {
                lifo.Push(t);
                t = t.left;
            }
            else {
                t = lifo.Pop();
                Console.WriteLine(t.data + " ");
                t = t.right;
            }
        }
    }

    static void PrintBFS_Queue(TreeNode n){
        if (n == null) return;
        var fifo = new Queue<TreeNode>();
        fifo.Enqueue(n);
        while(fifo.Count > 0){
            var t = fifo.Dequeue();
            Console.WriteLine(t.data);
            if (t.left != null) {
                fifo.Enqueue(t.left);
            }
            if (t.right != null) {
                fifo.Enqueue(t.right);
            }            
        }
    }

    static void PrintDFS_InOrder_Recursive(TreeNode n){
        //DEEP
        if (n == null) return;
        PrintDFS_InOrder_Recursive(n.left);
        Console.WriteLine(n.data);
        PrintDFS_InOrder_Recursive(n.right);

    }

    static int FindMax(TreeNode n){
        if (n == null) return int.MinValue;
        int r = n.data;
        int left = FindMax(n.left);
        int right = FindMax(n.right);
        return
            left > right ? left :
            right > left ? right :
            r;
    }

    static TreeNode InsertNodeRecursive(TreeNode n, int v){
        if (n == null) {
            return new TreeNode(v);
        }
        if (v < n.data) {
            n.left = InsertNodeRecursive(n.left, v);
        }
        else {
            n.right = InsertNodeRecursive(n.right, v);
        }
        return n;
        
    }

    static TreeNode Search(TreeNode n, int v){
        if (n == null || n.data == v) {
            return n;
        }
        if (v < n.data){
            return Search(n.left, v);
        }
        return Search(n.right, v);
    }

    static void SetNodes(TreeNode p, TreeNode left, TreeNode right){
        p.left = left;
        p.right = right;
    }

    public static void Build() {
        //var tree = new BinaryTreeLinkedList<int>();
        //var x = tree.Load(new int[]{ 1, 2, 3, 4, 5, 6, 7 }, null);
        
        var xs = new int[]{ 1, 2, 13, 24, 25, 36, 37 }.Select(x=>new TreeNode(x)).ToArray();
        SetNodes(xs[0], xs[1], xs[2]);
        SetNodes(xs[1], xs[3], xs[4]);
        SetNodes(xs[2], xs[5], xs[6]);
        
        /*
        var xs = new int[]{ 9, 2, 3, 4 }.Select(x=>new TreeNode(x)).ToArray();
        SetNodes(xs[0], xs[1], xs[2]);
        SetNodes(xs[1], xs[3], null);
        */
        
        //var n = xs[0];
        var n = new TreeNode(5);

        InsertNodeRecursive(n, 3);
        InsertNodeRecursive(n, 7);
        InsertNodeRecursive(n, 1);

        /*
        Console.WriteLine("DFS-PreOrder-Recursive");
        PrintDFS_PreOrder_Recursive(n);
        
        Console.WriteLine("DFS-PreOrder-Stack");
        PrintDFS_PreOrder_Stack(xs[0]);
        */
        Console.WriteLine("DFS-InOrder-Recursive");
        PrintDFS_InOrder_Recursive(n);
        /*
        Console.WriteLine("PrintDFS_InOrder_Stack");
        PrintDFS_InOrder_Stack(xs[0]);
        Console.WriteLine("PrintBFS_Queue");
        PrintBFS_Queue(n);
        */
        Console.WriteLine($"FindMax={FindMax(n)}");

        Console.WriteLine("Search");
        var z = Search(n, 3);
        PrintDFS_InOrder_Recursive(z);
    }
}