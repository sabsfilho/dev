class HelloWorld {
    static void Main() {
        Console.WriteLine(IsPrime(1));
    }
    
    static bool IsPrime(int n) {
        if (n < 2) return false;
        Console.WriteLine(Math.Sqrt(n));
        for(int i = 2, sqrt=(int)Math.Sqrt(n); i <= sqrt; i++){
            if (n % i == 0) return false;
        }
        return true;
    }
}