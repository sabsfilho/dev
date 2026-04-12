class HelloApp {
    public static void Print(){

        Console.WriteLine("Test!");

        //TestStack();
    }

    static void TestStack()
    {
        var arr = new int[] { 9,2,5,5,7 };

        var stack = new Stack<int>(arr);
        stack.Push(11);

        while(stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
        
    }

    static void Test01()
    {
        var arr = new int[] { 9,2,5,7 };

        Array.Sort(arr, (a, b) => b.CompareTo(a));
        //arr.Reverse();
        //Array.Reverse(arr);

        foreach(var a in arr)
        {
            Console.WriteLine(a);
        }
    }

    static void Test02()
    {
        var nums = new int[] { 7, 2, 6, 8, 2, 3, 2 };
        nums.Sort();
        var m = new HashSet<int>(nums);
        foreach(var n in m)
        {
            Console.WriteLine(n);
        }
        var arr = m.ToArray();
        for(int i=0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        foreach(var a in arr)
        {
            Console.WriteLine(a);
        }
    }
}