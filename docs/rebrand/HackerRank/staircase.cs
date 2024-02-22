void Main()
{
	
}

// Define other methods and classes here
public static void staircase(int n)
    {
        for(int i=0;i<n;i++){
            string x = string.Empty;
            string y = string.Empty;
            for(int j=0;j<n;j++){
                if (j < (n-i-1)){
                    x = string.Concat(x, " ");
                }
                else{                
                    x = string.Concat(x, "#");
                }
            }
            Console.WriteLine(string.Concat(x,y));
        }

    }
