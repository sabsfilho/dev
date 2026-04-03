public class FindMinSolution
{
    public int FindMin(int[] nums)
    {
        /*
        binary search, L = low, R = high, M = (L+R) / 2
        target = lowest
        ordered sequence paged
        loop until all L < R return L
        ex. 3, 4, 5, 6, 1, 2 => n=6

        */
        int L = 0;
        int R = nums.Length - 1;
        while(L < R)
        {
            int M = (L+R) / 2;
            int low = nums[L];
            int high = nums[R];
            int m = nums[M];
            if (low < high)
                return low;
            if (m >= low)
                L = M + 1;
            else
                R = M;

        }

        return nums[L];
    }

    public static void Print()
    {
        void Print(int[] arr, int answer)
        {
            int mine = new FindMinSolution().FindMin(arr);

            Console.WriteLine($"{string.Join(',', arr)}, answer: {answer}, mine: {mine} {(answer==mine?"OK":"WRONG")}");
        }

        Print(new int[]{ 3, 4, 5, 6, 1, 2 }, 1);
        Print(new int[]{ 4, 5, 0, 1, 2, 3 }, 0);
        Print(new int[]{ 5, 0, 1, 2, 3, 4 }, 0);
        Print(new int[]{ 2, 1 }, 1);
    }
}