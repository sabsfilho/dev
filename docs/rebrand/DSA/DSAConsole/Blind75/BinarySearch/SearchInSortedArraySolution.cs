using System.Linq.Expressions;

public class SearchInSortedArraySolution
{
    public int Search(int[] nums, int target)
    {
        /*
        Search in Rotated Sorted Array
        binary search, L = low, R = high, M = (L+R) / 2
        target = M
        ordered sequence paged
        loop until all L <= R return L
        ex. 3, 4, 5, 6, 1, 2 => n=6
        if [M] == target return M

        check each half
        if (low <= [M]) LEFT
            if (target >= low && target < M) R = M - 1;
            else L = M + 1;

        if (low > [M]) RIGHT
            if (target > [M] && target < high) L = L + 1;
            else R = R - 1


        */
        int L = 0;
        int R = nums.Length - 1;
        while(L <= R)
        {
            int M = (L + R) / 2;
            int low = nums[L];
            int high = nums[R];
            int m = nums[M];

            if (target == m) return M;

            if (low <= m) // LEFT
            {
                if (target >= low && target < m) R = M - 1;
                else L = M + 1;
            }
            else // RIGHT
            {
                if (target > m && target <= high) L = M + 1;
                else R = M - 1;
            }

        }

        return -1;
    }

    public static void Print()
    {
        void Print(int[] arr, int target, int answer)
        {
            int mine = new SearchInSortedArraySolution().Search(arr, target);

            Console.WriteLine($"{string.Join(',', arr)}, target: {target}, answer: {answer}, mine: {mine} {(answer==mine?"OK":"WRONG")}");
        }

        Print(new int[]{ 3, 4, 5, 6, 1, 2 }, 1, 4);
        Print(new int[]{ 3, 5, 6, 0, 1, 2 }, 4, -1);
        Print(new int[]{ 4, 5, 6, 7, 0, 1, 2 }, 0, 4);
        Print(new int[]{ 1 }, 1, 0);
        Print(new int[]{ 1 }, 2, -1);
    }
}