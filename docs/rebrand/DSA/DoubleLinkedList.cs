void Main()
{
	var z = new DoubleLinkedList<int>();
	z.Load(new int[] { 1, 10, 15, 25 });
	
	z.InsertFirst(9);
	z.InsertLast(29);
	z.DeleteFirstNode();
	z.DeleteLastNode();
	
	z.Print();
}

// Define other methods and classes here
public class DoubleLinkedList<T>{
	class ListNode<K> {
		public K data;
		public ListNode<K> prev;
		public ListNode<K> next;
		
		public ListNode(K data){
			this.data = data;
		}
	}
	
	ListNode<T> head;
	ListNode<T> tail;
	
	public int Length
	{
		get;
		private set;
	}
	
	public DoubleLinkedList() {
		head = null;
		tail = null;
		Length = 0;
	}
	
	public void Load(T[] arr) {
		var h = new ListNode<T>(default(T));
		var t = h;
		foreach(var a in arr) {
			var n = new ListNode<T>(a);
			t.next = n;
			t = n;
			Length++;
		}
		head = h.next;
		tail = t;
	}
	
	public void InsertFirst(T data){
		var n = new ListNode<T>(data);
		if (head == null) {
			tail = n;
		}
		else {
			head.prev = n;
		}
		n.next = head;
		head = n;
		Length++;
	}
	
	public void InsertLast(T data){
		var n = new ListNode<T>(data);
		if (head == null) {
			head = n;
		}
		else {
			var prev = tail;
			tail = n;
			prev.next = tail;
			tail.prev = prev;
		}
		Length++;
	}
	
	public void DeleteFirstNode(){
		if (head == null) return;
		if (tail == null) {
			head = null;
			Length = 0;
			return;
		}
		
		var n = head.next;
		n.prev = null;
		head = n;
		if (head == tail) {
			tail = null;		
		}
	}
	public void DeleteLastNode(){
		if (head == null) return;
		if (tail == null) {
			head = null;
			Length = 0;
			return;
		}
		
		var n = tail.prev;
		n.next = null;
		tail = n;
		if (head == tail) {
			tail = null;		
		}
	}
	
	public void Print() {
		if (head == null) return;
		var t = head;
		while(t != null) {
			Console.Write(string.Concat(t.data, " => "));
			t = t.next;
		}		
		Console.WriteLine("null");
		
		Console.WriteLine(string.Concat("Length=", Length));
	}
}