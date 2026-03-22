namespace ArrayLab;

public class ArrayLab
{
    static void SortArray(int[] ns, bool descending=false)
    {
        int len = ns.Length;
        for(int i = 0; i < len - 1; i++)
        {
            for(int j = i + 1; j < len; j++)
            {
                int b = ns[j];
                if ( (!descending && b < ns[i]) ||
                 (descending && b > ns[i]) )
                {
                    ns[j] = ns[i];
                    ns[i] = b;
                } 
            }
        }
    }

    static int[] CopySorting(int[] ns, bool descending=false)
    {
        int k = 0;
        int len = ns.Length;
        int[] rs = new int[len];
        bool[] oks = new bool[len];
        for(int i = 0; i < len; i++)
        {
            k = 0;
            for(int j = 0; j < len; j++)
            {
                if (!oks[j])
                {
                    break;
                }
                k++;
            }
            int a = ns[k];
            for(int j = k+1; j < len; j++)
            {
                if (oks[j]) continue;

                int b = ns[j];
                if (!descending && b > a) continue;
                if (descending && b < a) continue;

                a = b;
                k = j;
            }
            rs[i] = a;
            oks[k] = true;
            
        }

        return rs;
    }

    static void Print(int[] arr)
    {
        Console.WriteLine(string.Join(",", arr));
    }

    public static void Print()
    {
        Console.WriteLine("ok");
        int[] arr = new int[10];

        for(int i=0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, 100);
        }

        Print(arr);
        Print(arr.OrderBy(x=>x).ToArray());
        //Print(CopySorting(arr));
        //Print(arr.OrderByDescending(x=>x).ToArray());
        //Print(CopySorting(arr, true));

        SortArray(arr);
        Print(arr);
        SortArray(arr, true);
        Print(arr);
    }
}