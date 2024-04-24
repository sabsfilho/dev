public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        var q = new Queue<int>();
        int x0 = 0;
        int x1 = 0;
        int j = 0;
        foreach(var n in students) {
            int s = sandwiches[j];
            if (n == s) {
                j++;
                continue;
            }
            if (n == 0) x0++;
            else x1++;
            q.Enqueue(n);
        }
        //Console.WriteLine("x0="+x0+";x1="+x1+";q="+q.Count);
        while(q.Count > 0) {
            if (
                (x0 == 0 && x1 == 0)
            ){
                break;
            }
            //Console.WriteLine(">> x0="+x0+";x1="+x1+";n="+0+";s="+0+";j="+j+";q="+q.Count);
            int n = q.Dequeue();
            if (n == 0) x0--;
            else x1--;
            int s = sandwiches[j];
            //Console.WriteLine(">> x0="+x0+";x1="+x1+";n="+n+";s="+s+";j="+j+";q="+q.Count);
            if (n == s) {
                j++;
                continue;
            }
            if (n == 0) x0++;
            else x1++;
            q.Enqueue(n);
            if (
                (x0 == 0 && x1 == q.Count) ||
                (x1 == 0 && x0 == q.Count)
            )
            {
                break;
            }
            //Console.WriteLine("<< x0="+x0+";x1="+x1+";n="+n+";s="+s+";j="+j+";q="+q.Count);

        }

        return x0+x1;
    }
}