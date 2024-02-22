void Main()
{
        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        int n = 6;
        int? max = null;
        for (int i = 0; i < n - 2; i++) {
            for (int j = 0; j < n - 2; j++) {
                int r = Calc(arr, i, j);
                if (r > max || !max.HasValue)
                {
                    max = r;
                }
            }
        }
        Console.WriteLine(max);
	
}


    
    static int Calc(List<List<int>> arr, int row, int col)
    {
        int sum = arr[row+1][col+1];
        for (int c = 0; c < 3; c++)
        {
            sum += arr[row][col + c];
            sum += arr[row+2][col + c];
        }
        return sum;
    }
