class Array_LeetCode_SearchKeyInSortedMatrix{
    
    private static (int i, int j) Search(int[,] xs, int n, int k) {
        int i = 0;
        int j = n - 1;
        while (i < n && j >= 0){
            int x = xs[i, j];
            if (x == k){
                return (i, j);
            }
            if (x > k){
                j--;
            }
            else {
                i++;
            }
        }
        return (-1, -1);
    }

    public static void Print(){
        Console.WriteLine("Array_LeetCode_SearchKeyInSortedMatrix");

        int[,] xs = {
            {10,20,30,40},
            {15,25,35,45},
            {27,29,37,48},
            {32,33,39,51}
        };

        int k = 36;

        int n = xs.GetUpperBound(0) + 1;

        var p = Search(xs, n, k);

        Console.WriteLine(
            p.i == -1 ? $"{k} not found" :
            $"{k} found at ({p.i}, {p.j})"
        );        
    }
}