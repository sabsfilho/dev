void Main()
{
	var xs = "1 2 2 3 3 4".Split(' ');
	Node head = null;
	foreach(var x in xs)
	{
		head = insert(head, int.Parse(x));
	}
	display(head);
	"#removeDuplicates#".Dump();
	//removeDuplicates(head);	
	removeDuplicates(head);
	display(head);
}


class Node
{
	public Node next;
	public int data;
	public Node(int data)
	{
		this.data = data;
	}
}

	static  Node insert(Node head,int data)
	{
      var node = new Node(data);
      
      if (head != null) 
      {
	  	Node tail = head;
	  	while(tail.next != null)
		{		
			tail = tail.next;
		}		
		tail.next = node;
	  	return head;
      }
      
      return node;
    }
	static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			start.data.Dump();
			start=start.next;
		}
	}
	static Node removeDuplicates(Node head){
	    var xs = new List<int>();
	    Node prev = null;
	    Node n = head;
	    while(n != null){
	        var nxt = n.next;        
	        if (xs.Count == 0){
	            xs.Add(n.data);
	        }
	        else {
	            var v = n.data;
	            if (xs.Contains(v)){
					n = nxt;
	                prev.next = nxt;
					continue;
	            }
	            else {
	                xs.Add(v);
	            }
	        }
	        prev = n;
	        n = nxt;
	    }
		return head;
	  }
	  
	  
	  static Node removeDuplicates2(Node head){
	    //Write your code here
	    int current = head.data;
	    
	    Node currentNode = head;
	    while(currentNode.next != null) {
	       
	        if(currentNode.next.data == current) {
	            currentNode.next = currentNode.next.next;
	        }
	        else {
	            current = currentNode.next.data;
	            currentNode = currentNode.next;
	        }
	        
	    }
	    
	    return head;
  	}
