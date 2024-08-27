public class StockSpanner {

    List<int> stack = null;

    public StockSpanner() {
        stack = new List<int>();
    }
    
    public int Next(int price) {
        stack.Add(price);
        //Console.WriteLine(price);
        //Console.WriteLine(string.Join(",", stack));
        int q = 0;
        for(int i = stack.Count - 1; i >= 0; i--) {
            int v = stack[i];
            if (v > price) return q;
            q++;
        }
        return q;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */