void Main()
{
	new SinglyLinkedList().Test();
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
	
	public void InsertSorted(int data){
		if (head == null) {
			InsertFirst(data);
			return;
		}
		
		var n = new ListNode(data);
		
		var x = head;
		if (x.next == null){
			if (data < (int)x.data) {
				n.next = x;
				head = n;
			}
			else {			
				x.next = n;
			}
			return;
		}
		while(x != null && x.next != null){
			if (data < (int)x.next.data) {
				n.next = x.next;
				x.next = n;
				break;
			}
			else {
				x = x.next;
			}
		}
		x.next = n;
		
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
	
	public void RemoveDuplicates() {
	
		if (head == null) return;
		
		var x = head;
		while(x != null && x.next != null){
			if (x.data.Equals(x.next.data)){
				x.next = x.next.next;				
			}
			else {
				x = x.next;
			}
		}
	
	}
	
	public void RemoveNode(object data){
		var x = head;
		ListNode prev = null;
		while(x != null){
			if (x.data.Equals(data)){
				if (prev == null) {
					head = head.next;
					return;
				}
				prev.next = x.next;
				return;
			}
			prev = x;
			x = x.next;
		}
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
	
	public bool HasLoop() {
	
		if (head == null) return false;
		
		ListNode fast = head;
		ListNode slow = head;
		
		while(fast != null && fast.next != null) {
			fast = fast.next.next;
			slow = slow.next;
			if (fast != null && fast.data.Equals(slow.data)){
				return true;
			}
		}
		
		return false;
	}
	
	ListNode GetStartingNodeLoop(ListNode slow){
		var x = head;
		while(x != slow) {
			x = x.next;
			slow = slow.next;
		}
		return x;
	}
	
	public ListNode GetStartingNodeLoop() {
	
		if (head == null) return null;
		
		ListNode fast = head;
		ListNode slow = head;
		
		while(fast != null && fast.next != null) {
			fast = fast.next.next;
			slow = slow.next;
			if (fast != null && fast.data.Equals(slow.data)){
				return GetStartingNodeLoop(slow);
			}
		}
		
		return null;
	}
	
	private void RemoveLoop(ListNode slow){
		var t = head;
		while(t != slow){
			t = t.next;
			slow = slow.next;
		}
		slow.next = null;
	}
	
	public void RemoveLoop() {
		var fast = head;
		var slow = head;
		
		while (fast != null && fast.next != null) {
			fast = fast.next.next;
			slow = slow.next;
			if (slow.next == fast.next) {
				RemoveLoop(slow);
				return;
			}
		}
	}
	
	public ListNode MergeSort(ListNode a, ListNode b){
		ListNode r = new ListNode(0);
		
		while(a != null && b != null){
			if ((int)a.data < (int)b.data) {
				r.next = a;
				a = a.next;
			}
			else {
				r.next = b;
				b = b.next;
			}
		}
		if (a == null){
			r.next = b;
		}
		else {
			r.next = a;
		}
		
		return r.next;
	}
	
	public void Test() {
		head = new ListNode(10);
		var second = new ListNode(1);
		var third = new ListNode(8);
		var fourth = new ListNode(11);
		
		head.next = second;
		second.next = third;
		third.next = fourth;
		
		// LOOP TEST !!!
		/*
		fourth.next = second;		
		GetStartingNodeLoop().data.Dump();		
		RemoveLoop();
		HasLoop().Dump();		
		return;
		*/
		
		InsertFirst(50);
		InsertLast(400);
		
		Insert(2,1);
		
		RemoveNode(11);
		//Delete(6);
		//Delete(2);
		
		Print();
		
		Reverse();
		
		Console.WriteLine("######");
		
		Print();
		
		head = null;		
		for (int i=1;i<6;i++){
			InsertLast(i);
		}
		Insert(2,2);
		Insert(2,3);
		Print();
		RemoveDuplicates();
		Print();
		
		
		head = null;
		var xs = new int[] { 10, 1, 16, 8 };		
		foreach(var x in xs){
			InsertSorted(x);
		}
		Print();
		
		
	}
	
	public void Print(){
		
		Console.WriteLine(string.Concat("n[2]=", GetNode(2).data));
		var z = FindNode(8, null);
		if (z != null){
			Console.WriteLine(string.Concat("f[8]=", z.data));
		}
		z = FindNodeFromEnd(2);
		if (z != null) {
			Console.WriteLine(string.Concat("fEND[2]=", z.data));
		}
		
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