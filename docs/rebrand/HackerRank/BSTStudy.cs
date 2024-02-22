void Main()
{
var zs = @"7
3
5
2
1
4
6
7".Split('\n');
int i = 0;
        Node root=null;
        int T=Int32.Parse(zs[i++]);
        while(T-->0){
            int data=Int32.Parse(zs[i++]);
            root=insert(root,data);            
        }
        int height=getHeight(root);
        height.Dump();
}


class Node
{
	public Node left = null;
	public Node right = null;
	public int data = 0;
	public Node(int data)
	{
		this.data = data;
	}
}

static int getHeight(Node root)
{	
	if (
		root == null || 
		(root.left == null && root.right == null)
	)
	{
		return 0;
	}
	else
	{
		return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
	}
}

	static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
