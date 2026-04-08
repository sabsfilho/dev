public class MedianFinderSolution
{
    public class MedianFinderHeap
    {
        //Find Median From Data Stream using Heap solution
        /*
        divide two queues : low and high
        take the first ones
        if quantity equals then ( low[0]+high[0] ) / 2
        if odd get the higher queue first element

        */        
        PriorityQueue<int, int> lows;
        PriorityQueue<int, int> highs;

        public MedianFinderHeap()
        {
            lows = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            highs = new PriorityQueue<int, int>();
        }

        public void AddNum(int num)
        {
            lows.Enqueue(num, num);
            int maxLow = lows.Dequeue();
            highs.Enqueue(maxLow, maxLow);

            if (highs.Count > lows.Count)
            { 
                int minHigh = highs.Dequeue();
                lows.Enqueue(minHigh, minHigh);
            }
        }

        public double FindMedian()
        {
            // 1,3,4,5,6,7 => c=6 => m=3 => [m-1],[m] => [2,3] => 4,5 => 9/2 => 4.5
            
            if (lows.Count == 0 && highs.Count == 0) return 0;
            if (lows.Count > highs.Count) return lows.Peek();

            return ( lows.Peek() + highs.Peek() ) / 2.0;
        }
    }
    public class MedianFinderList
    {
        //Find Median From Data Stream using sorted List
        List<int> nums;

        public MedianFinderList()
        {
            nums = new List<int>();
        }

        public void AddNum(int num)
        {
            nums.Add(num);
        }

        public double FindMedian()
        {
            // 1,3,4,5,6,7 => c=6 => m=3 => [m-1],[m] => [2,3] => 4,5 => 9/2 => 4.5
            int c = nums.Count;
            if (c == 0) return 0;
            if (c == 1) return nums[0];

            nums.Sort();

            if (c == 2) return (nums[0] + nums[1]) / 2.0;
            bool even = c % 2 == 0;
            int m = c / 2;
            if (even)
            {
                return (nums[m - 1] + nums[m]) / 2.0;
            }
            else
            {
                return nums[m];
            }
        }
    }

    private static void Print(double answer, int[] arr)
    {
        var medianFinderList = new MedianFinderList();
        var medianFinderHeap = new MedianFinderHeap();

        foreach (var n in arr)
        {
            medianFinderList.AddNum(n);
            medianFinderHeap.AddNum(n);
        }

        var mineList = medianFinderList.FindMedian();
        var mineHeap = medianFinderHeap.FindMedian();

        Console.WriteLine($"LIST => {string.Join(',', arr)}, answer: {answer}, mine: {mineList} {(answer == mineList ? "OK" : "WRONG")}");
        Console.WriteLine($"HEAP => {string.Join(',', arr)}, answer: {answer}, mine: {mineHeap} {(answer == mineHeap ? "OK" : "WRONG")}");
    }

    struct AnswerStruct
    {
        public double answer;
        public int[] context;

        public AnswerStruct(double answer, int[] context)
        {
            this.answer = answer;
            this.context = context;
        }
    }

    public static void Print()
    {
        var xs = new AnswerStruct[]
        {
            new AnswerStruct( 2, new int[] { 1, 2, 3} ),
            new AnswerStruct( 2, new int[] { 1, 3, 2} ),
            new AnswerStruct( 2.5, new int[] { 1, 2, 3, 4} ),
            new AnswerStruct( 2.5, new int[] { 1, 4, 2, 3} ),
            new AnswerStruct( 3, new int[] { 1, 4, 5, 2, 3} ),
        };

        foreach (var x in xs)
        {
            Print(x.answer, x.context);
        }
    }
}