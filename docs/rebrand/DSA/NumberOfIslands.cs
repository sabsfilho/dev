void Main()
{
	var g = new Graph(4);
	
	g.AddEdge(0, 0);
	g.AddEdge(0, 1);
	g.AddPoint(2, 2);
	g.AddPoint(3, 3);
	//g.AddPoint(2, 3);
	//g.AddPoint(0, 3);
	//g.AddPoint(0, 2);
	
	g.matrix.Dump();
	
	g.CountIslands().Dump();
}

class Graph {

	public int[,] matrix;
	
	public Graph(int n) {
		matrix = new int[n,n];
	}
	
	public void AddPoint(int u, int v) {
		matrix[u, v] = 1;
	}
	
	public void AddEdge(int u, int v) {
		matrix[u, v] = 1;
		matrix[v, u] = 1;
	}
	
	public int CountIslands() {
		int n = matrix.GetUpperBound(0) + 1;
		int vertices = matrix.Length;
		var visited = new bool[n,n];
		int numberOfIslands = 0;
		for(int i=0; i < n; i++){
			for(int j=0; j < n; j++){
				if (!visited[i,j] && matrix[i,j] == 1) {
					DepthSearch(i, j, visited);
					numberOfIslands++;
				}
			}
		}
		return numberOfIslands;

	}
	void DepthSearch(int row, int col, bool[,] visited) {
		int n = matrix.GetUpperBound(0) + 1;
		if (
			row < 0 ||
			col < 0 ||
			row >= n || 
			col >= n ||
			visited[row,col] ||
			matrix[row,col] == 0
		){
			return;
		}
		visited[row,col] = true;
		DepthSearch(row, col - 1, visited);		
		DepthSearch(row - 1, col, visited);		
		DepthSearch(row, col + 1, visited);		
		DepthSearch(row + 1, col, visited);		
	}

}