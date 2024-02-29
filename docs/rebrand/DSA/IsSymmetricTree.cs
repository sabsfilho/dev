void Main()
{
	
}

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
// Define other methods and classes here
static bool IsSymmetric(TreeNode root) {

	if (root == null) return true;
	
	var stack = new Stack<TreeNode>();
	
	stack.Push(root.left);
	stack.Push(root.right);
	
	while(stack.Count > 0) {
		var n1 = stack.Pop();
		var n2 = stack.Pop();
		if (n1 == null && n2 == null) continue;
		if (n1 == null || n2 == null || n1.value != n2.value) return false;
		stack.Push(n1.left);
		stack.Push(n2.right);
		stack.Push(n1.right);
		stack.Push(n2.left);
	}
	
	return true;

}