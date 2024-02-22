void Main()
{
var ls = new List<int>(){ 2, 4, 5, 9, 15, 20, 25, 26, 37 };	
SortedInsert(ls, 3);
SortedInsert(ls, 1);
SortedInsert(ls, 12);
SortedInsert(ls, 78);
}


void SortedInsert(List<int> lst, int v)
{
	int d = lst.Count - 1;
	while(d>1 && v < lst[d])
	{
		d = d / 2;
	}
	if (v > lst[d])
	{
		while(d < lst.Count)
		{
			if (v<=lst[d]){
				break;
			}
			d++;
		}
	}
	else{
		while(d>0 && v <= lst[d])
		{
			if (v>lst[d-1]){
				break;
			}
			d--;
		}
	}
	lst.Insert(d, v);
	string.Join(";", lst).Dump();
}
