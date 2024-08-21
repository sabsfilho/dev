public class RecentCounter {

    List<int> qs = null;

    public RecentCounter() {
    }
    
    public int Ping(int t) {
        if (qs == null) qs = new List<int>();
        qs.Add(t);
        int d = t - 3000;
        int sum = 0;
        int q = qs.Count - 1;
        while(q >= 0){
            int n = qs[q];
            if (n >= d) {
                sum++;
                q--;
            }
            else {
                break;
            }
        }
        return sum;    
    }
}
