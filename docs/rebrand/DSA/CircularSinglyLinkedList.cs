void Main()
{
	var x = new CircularSinglyLinkedList();
	x.Load(new int[]{1,5,10,15});
	x.InsertLast(33);
	x.InsertFirst(7);
	x.RemoveFirst();
	x.Print();
}

class CircularSinglyLinkedList{
	public class ListNode {
		public ListNode next = null;
		public int data;
		public ListNode(int data){
			this.data = data;
		}
	}
	
	ListNode head = null;
	ListNode tail = null;
	
	public void Load(int[] arr) {
		var h = new ListNode(0);
		var t = h;
		foreach(var a in arr) {
			var n = new ListNode(a);            
			t.next = n;
			t = n;
		}
		head = h.next;
		tail = t;
		t.next = head;
	}
	
	public void InsertFirst(int data) {
		var n = new ListNode(data);
		if (head == null) {
			head = n;
			head.next = n;
			tail = n;
			tail.next = n;
		}
		else {
			n.next = head;
			tail.next = n;
			head = n;
		}
	}
	
	
	public void InsertLast(int data) {
		var n = new ListNode(data);
		if (tail == null) {
			tail = n;
			tail.next = tail;
		}
		else {
			n.next = tail.next;
			tail.next = n;
			tail = n;
		}
	}

    public void RemoveFirst() {
        if (head == null) return;
        if (head == tail) {
            head = null;
			tail = null;			
        }
		tail.next = head.next;
		head = head.next;
    }
	
	
	public void Print() {
		if (head == null) return;
		var t = head;
		while(t != null) {
			Console.Write(string.Concat(t.data, " => "));
			t = t.next;
			if (t == head) break;
		}		
		Console.WriteLine(head.data);
	}
}