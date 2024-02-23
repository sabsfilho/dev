void Main()
{
	new SinglyLinkedList().Load();
}

class SinglyLinkedList{
	public class ListNode {
		public ListNode next = null;
		public object data;
		public ListNode(object data){
			this.data = data;
		}
	}
	
	ListNode head = null;
	
	public int Length{
		get;
		private set;
	}
	
	public void InsertFirst(object data){
		var n = new ListNode(data);
		n.next = head;
		head = n;
	}
	
	public void InsertLast(object data){
		var n = new ListNode(data);
		if (head == null){
			head = n;
			return;
		}
		var x = head;
		while(x.next != null){
			x = x.next;
		}
		x.next = n;
	}
	public ListNode GetNode(int i){
		//ZERO-BASED
		var prv = head;
		int q = 0;
		while(prv != null && q < i){
			prv = prv.next;
			q++;
		}
		return prv;
	}
	
	public ListNode FindNode(object v, ListNode baseNode){
	
		if (baseNode == null) {
			baseNode = head;
		}
		
		if (baseNode == null) return null;
		
		var n = baseNode;
		while(n != null){
			if (n.data.Equals(v)) {
				return n;
			}
			n = n.next;
		}
		return null;
	}
	
	public void Insert(object data, int i){
		
		if (i == 0) {
			InsertFirst(data);
			return;
		}
		
		var prv = GetNode(i-1);
		
		var n = new ListNode(data);
		
		var curr = prv.next;
		n.next = curr;
		prv.next = n;
		
	}
	
	public void Delete(int i){
	// one based position
		if (head == null) return;
		
		if (i == 0){
			head = head.next;
			return;
		}
		
		var prv = GetNode(i-1);
		
		if (
			prv == null || 
			prv.next == null
		) {
			return;
		}
		
		prv.next = prv.next.next;
	}
	
	public ListNode FindNodeFromEnd(int n){
		ListNode x = head;
		ListNode y = head; // fast
		
		int i = 0;
		while(i++ < n){
			y = y.next;
		}
		
		while(y != null) {
			y = y.next;
			x = x.next;
		}
		
		return x;
	}
	
	public void Reverse() {
	
		if (head == null) return;
	
		ListNode prev = null, curr = null, next = null;
		
		curr = head;
		while(curr != null){
			next = curr.next;
			curr.next = prev;
			prev = curr;
			curr = next;			
		}
		
		head = prev;
	}
	
	public void Load() {
		head = new ListNode(10);
		var second = new ListNode(1);
		var third = new ListNode(8);
		var fourth = new ListNode(11);
		
		head.next = second;
		second.next = third;
		third.next = fourth;
		
		InsertFirst(50);
		InsertLast(400);
		
		Insert(2,1);
		
		//Delete(6);
		//Delete(2);
		
		Print();
		
		Reverse();
		
		Console.WriteLine("######");
		
		Print();
	}
	
	public void Print(){
		
		Console.WriteLine(string.Concat("n[2]=", GetNode(2).data));
		Console.WriteLine(string.Concat("f[8]=", FindNode(8, null).data));
		Console.WriteLine(string.Concat("fEND[2]=", FindNodeFromEnd(2).data));
		
		var n = head;
		int j = 0;
		while(n != null) {
			Console.WriteLine(string.Concat(j++, "=", n.data));
			Length++;
			n = n.next;
		}
		
		Console.WriteLine(string.Concat("Length=",Length));
	}

}