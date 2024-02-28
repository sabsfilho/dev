void Main()
{
	var g = new Graph(5);
	
	g.AddEdge(0, 1);
	g.AddEdge(1, 2);
	g.AddEdge(2, 3);
	g.AddEdge(3, 0);
	g.AddEdge(2, 4);
	
	g.BreadthSearch(0);
	g.DepthSearch(0);
	
	//g.matrix.Dump();
	
}

class Graph {
	public LinkedList<int>[] matrix;
	
	public Graph(int n) {
		matrix = new LinkedList<int>[n];
		for(int i = 0; i < n; i++) {
			matrix[i] = new LinkedList<int>();
		}
	}
	public void AddEdge(int u, int v) {
		matrix[u].AddLast(v);
		matrix[v].AddLast(u);
	}

	public void BreadthSearch(int s) {
		int vertices = matrix.Length;
		var visited = new bool[vertices];
		var q = new Queue<int>();
		visited[s] = true;
		q.Enqueue(s);
		while(q.Count > 0) {
			var u = q.Dequeue();
			Console.WriteLine(u);
			foreach(int v in matrix[u]){
				if (!visited[v]) {
					visited[v] = true;
					q.Enqueue(v);
				}
			}
		}

	}

	public void DepthSearch(int s) {
		int vertices = matrix.Length;
		var visited = new bool[vertices];
		var q = new Stack<int>();
		visited[s] = true;
		q.Push(s);
		while(q.Count > 0) {
			var u = q.Pop();
			Console.WriteLine(u);
			foreach(int v in matrix[u]){
				if (!visited[v]) {
					visited[v] = true;
					q.Push(v);
				}
			}
		}

	}
}