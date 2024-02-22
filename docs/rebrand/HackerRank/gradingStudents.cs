void Main()
{
	var xs = @"73
67
38
33".Split('\n').Select(x=>int.Parse(x)).ToList();

gradingStudents(xs).Dump();
}

// Define other methods and classes here
public static List<int> gradingStudents(List<int> grades)
    {
		var xs = grades;
		
		for(int i=0,l=xs.Count;i<l;i++)
		{
			var v = xs[i];
			if (v >= 38){
				int k = v % 5;
				int w = v - k + 5;
				int d = w - v;
				if (d < 3){
					xs[i] = w;
				}				
			}
		}
		
		return xs;
    }
