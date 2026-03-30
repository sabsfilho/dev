class BinarySearchSolution
{
    static int BinarySearch(int[] arr, int target)
    {
        /*
        divide and conquer halves sub problems
        sort arr first !!!
        L,R,M=half.position
        */
        Array.Sort(arr);

        int L = 0;
        int R = arr.Length - 1;

        while(L <= R)
        {
            int M = (L + R) / 2;
            int v = arr[M];
            if (target > v) // go right
                L = M + 1;
            else if (target < v) // go left
                R = M - 1;
            else if (target == v)
                return M;
            
        }

        return -1;               
    }
    
    public static void Print()
    {
        void Eval(int[] arr, int target, int answer)
        {
            int mine = BinarySearch(arr, target);
            Console.WriteLine($"{string.Join(",", arr)}, target: {target}, answer: {answer}, mine: {mine} {(answer==mine?"OK":"WRONG")}");
        }

        var xs = new int[] {2,5,1,6,1,4}; // 1,1,2,4,5,6

        Eval(xs, 5, 4);
        Eval(xs, 3, -1);
        Eval(xs, 9, -1);
        Eval(xs, 0, -1);
        Eval(xs, 6, 5);
        Eval(xs, 2, 2);
        Eval(xs, 1, 0);
    }
}