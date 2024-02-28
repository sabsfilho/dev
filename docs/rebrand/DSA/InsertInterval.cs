void Main()
{
	var xs = new List<Interval>() {
		new Interval(1,3),
		new Interval(5,7),
		new Interval(8,10),
		new Interval(11,12)
	};
	//xs.Dump();
	//xs.Add(new Interval(4,9));
	//Merge(xs).Dump();
	InsertInterval(xs, new Interval(4,9)).Dump();
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


static List<Interval> InsertInterval(List<Interval> intervals, Interval newInterval) {

	if (intervals == null || intervals.Count == 0) {
		return new List<Interval>(){ newInterval };
	}
	
	var rs = new List<Interval>();
	
	int i = 0;
	while (
		i < intervals.Count &&
		intervals[i].End < newInterval.Start
	)
	{
		rs.Add(intervals[i++]);
	}
	
	while (
		i < intervals.Count &&
		intervals[i].Start <= newInterval.End
	)
	{
		var curr = intervals[i];
		newInterval.Start = curr.Start < newInterval.Start ? curr.Start : newInterval.Start;
		newInterval.End = curr.End > newInterval.End ? curr.End : newInterval.End;
		i++;
	}
	rs.Add(newInterval);
	
	while(i < intervals.Count) {
		rs.Add(intervals[i++]);
	}
	
	return rs;
}