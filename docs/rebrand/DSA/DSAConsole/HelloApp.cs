class HelloApp {
    public static void Print(){

        Console.WriteLine("Test!");

        Test01();
    }

    static void Test01()
    {
        var arr = new int[] { 9,2,5,7 };

        Array.Sort(arr, (a, b) => b.CompareTo(a));

        //Array.Reverse(arr);

        foreach(var a in arr)
        {
            Console.WriteLine(a);
        }
    }
}