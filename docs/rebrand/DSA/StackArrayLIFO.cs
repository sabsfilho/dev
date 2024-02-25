void Main()
{
	var lifo = new StackArrayLIFO<int>();
	lifo.Push(10);
	lifo.Push(15);
	lifo.Push(20);
	
	lifo.Print();
	
	Console.WriteLine(lifo.Peek());
	
	Console.WriteLine(lifo.Pop());
	
	Console.WriteLine(lifo.Peek());
}

class StackArrayLIFO<T> {

	List<T> arr = new List<T>();
	
	public int Length
	{
		get { return arr.Count; }
	}
	
	public void Push(T data){
		arr.Add(data);
	}
	
	public T Pop() {
		if (Length == 0) {
			throw new NullReferenceException();
		}
		
		T r = arr[arr.Count - 1];
		arr.RemoveAt(arr.Count - 1);
		
		return r;
	}
	
	public T Peek() {
		if (Length == 0) {
			throw new NullReferenceException();
		}
	
		return arr[arr.Count - 1];
	}
	
	public void Print() {
		if (Length == 0) {
			throw new NullReferenceException();
		}
		foreach(var t in arr) {
			Console.Write(string.Concat(t, " => "));
		}
		Console.WriteLine("null");
	}
}