

class Queue_LeetCode_BinaryNumbers {

    public static void Print() {
        int n = 5;

        var arr = new string[n]; 

        for(int i = 0; i < n; i++){
            arr[i] = ConvertToBinary(i+1);
        }

        var arr2 = ConvertToBinaryQueue(n);

        Console.WriteLine(string.Join(",", arr));
        Console.WriteLine(string.Join(",", arr2));
    }

    private static string[] ConvertToBinaryQueue(int n)
    {
        var arr = new string[n];
        var fifo = new Queue<string>();
        fifo.Enqueue("1");
        for(int i = 0; i < n; i++){
           var v = fifo.Dequeue();
           arr[i] = v; 
           var n1 = string.Concat(v, "0");
           var n2 = string.Concat(v, "1");
           fifo.Enqueue(n1);
           fifo.Enqueue(n2);
        }

        return arr;
    }

    private static string ConvertToBinary(int x)
    {
        string w = string.Empty;
        while(x>0)
        {
            w = $"{(x%2==1?1:0)}{w}";
            x = (int) (x / 2);
        }
        return w;
    }
	
	private static void ConvertToBinary(int n) {
		var fifo = new Queue<int>();
		fifo.Enqueue(1);
		for(int i = 0; i < n. i++){
			int x = fifo.Dequeue();
			Console.WriteLine(x);
			fifo.Enqueue(x * 10);
			fifo.Enqueue(x * 10 + 1);
		}
	}
}