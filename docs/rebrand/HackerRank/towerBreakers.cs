void Main()
{
Go();	
}

// Define other methods and classes here
public static void Go()
        {
            /*2       t = 2
2 2     n = 2, m = 2
1 4     n = 1, m = 4
            out 2
            out 1

            n towers
            m height
            Console.WriteLine(towerBreakers(2, 6)) = 2;
            Console.WriteLine(towerBreakers(2, 2)) = 2;
            Console.WriteLine(towerBreakers(1, 4)) = 1;
            Console.WriteLine(towerBreakers(1, 7)) = 1;
            */
            Console.WriteLine(towerBreakers(1, 7));
        }
        static int towerBreakers(int n, int m)
        {
    
            if (m == 1) {
                return 2;
            }
    
            return n % 2 == 0 ? 2 : 1;
        }

