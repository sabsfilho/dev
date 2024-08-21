public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {

        var xs = 
            intervals
            .Select(x=>new {
                start = x[0],
                end = x[1]
            })
            .OrderBy(x=>x.start)
            .ToList();
        
        int q = 0;
        int start = int.MinValue;
        int end = int.MinValue;
        foreach(var x in xs){
            //Console.WriteLine($"{x.start},{x.end}");
            if (x.start >= end) {
                start = x.start;
                end = x.end;
            }
            else {
                if (x.end < end) {
                    end = x.end;
                }
                q++;
            }
        }

        return q;
        
    }
}