public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);

        int i = 0;
        int j = people.Length-1;
        int q = 0;
        int p = 0;
        while(i < j){
            int x = people[i];
            int y = people[j];

            if (y == limit){
                q++;
                p++;
                j--;
                if (x == limit){
                    q++;
                    p++;
                    i++;
                }
                continue;
            }
            else if (x+y > limit){
                j--;
                q++;
                p++;
                continue;
            }
            q++;
            p+=2;
            i++;
            j--;
        }
        int d = people.Length - p;
        //Console.WriteLine("d="+d+";q="+q+";p="+p+";ps="+people.Length);
        if (d > 0) q += d;
        return q;
    }
}