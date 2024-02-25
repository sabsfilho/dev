void Main()
{

	var lifo = new StackLinkedListLIFO<int>();
	lifo.Push(10);
	lifo.Push(15);
	lifo.Push(20);
	
	lifo.Print();
	
	Console.WriteLine(lifo.Peek());
	
	Console.WriteLine(lifo.Pop());
	
	Console.WriteLine(lifo.Peek());
	
}

public class StackLinkedListLIFO<T> {
	//STACK LIFO
	class ListNode<K> {
		public K data;
		public ListNode<K> next;
		public ListNode(K data) {
			this.data = data;
		}
	}
	
	ListNode<T> top = null;
	
	public int Length { get; private set;}
	
	public void Push(T data){
		var t = new ListNode<T>(data);
		t.next = top;
		top = t;
		Length++;
	}
	
	public T Pop() {
		if (top == null) {
			throw new NullReferenceException();
		}
	
		T r = top.data;
		
		top = top.next;
		
		Length--;
		return r;
	}
	
	public T Peek() {
		if (top == null) {
			throw new NullReferenceException();
		}
	
		return top.data;
	}
	
	public void Print() {
		if (top == null) {
			throw new NullReferenceException();
		}
		var t = top;
		while(t != null) {
			Console.Write(string.Concat(t.data, " => "));
			t = t.next;
		}
		Console.WriteLine("null");
	}
}