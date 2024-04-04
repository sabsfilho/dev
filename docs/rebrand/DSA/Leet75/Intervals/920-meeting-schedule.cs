/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {

        var q = new Queue<Interval>();

        foreach(var n in intervals) {
            var q2 = new Queue<Interval>();
            while(q.Count > 0) {
                var x = q.Dequeue();
                if (
                    (n.start >= x.start && n.start < x.end) ||
                    (n.end >= x.start && n.end < x.end)
                 )
                 {
                    return false;
                 }
                 q2.Enqueue(x);
            }
            q2.Enqueue(n);
            q = q2;
        }

        return true;

    }
}
