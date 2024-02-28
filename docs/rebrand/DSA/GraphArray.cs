void Main()
{
	var g = new Graph(4);
	
	g.AddEdge(0, 1);
	g.AddEdge(1, 2);
	g.AddEdge(2, 3);
	g.AddEdge(3, 0);
	
	g.matrix.Dump();
}

class Graph {

	public int[,] matrix;
	
	public Graph(int n) {
		matrix = new int[n,n];
	}
	
	public void AddEdge(int u, int v) {
		matrix[u, v] = 1;
		matrix[v, u] = 1;
	}

}