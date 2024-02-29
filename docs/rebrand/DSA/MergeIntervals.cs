void Main()
{
	var xs = new List<Interval>() {
		new Interval(2,6),
		new Interval(1,3),
		new Interval(8,10)
	};
	xs.Dump();
	Merge(xs).Dump();
}

class Interval {
	public int Start { get; set; }
	public int End { get; set; }
	
	public Interval(int start, int end) {
		Start = start;
		End = end;
	}
	
}

static List<Interval> Merge(List<Interval> intervals) {

	if (intervals.Count < 2) return intervals;
	
	intervals = intervals.OrderBy(x=>{
		return x.Start;
	})
	.ToList();
	
	var result = new List<Interval>();
	var first = intervals[0];
	int start = first.Start;
	int end = first.End;
	
	for(int i=1; i < intervals.Count; i++) {
		var curr = intervals[i];
		if (curr.Start <= end) {
			if (curr.End > end) {
				end = curr.End;
			}
		}
		else {
			result.Add(new Interval(start, end));
			start = curr.Start;
			end = curr.End;
		}
	}
	result.Add(new Interval(start, end));
	return result;
}