void Main()
{
	new Calc().Add();
}



class Calc{
	class ListNode{
		public int data;
		public ListNode next;
		public ListNode(int v){
			this.data = v;
		}
	}	
	
	ListNode Add(ListNode a, ListNode b){
		ListNode r = new ListNode(0);
		ListNode t = r;
		int m = 0;
		while(a != null || b != null){					
			int v = 0;
			if (a != null) v += a.data;
			if (b != null) v += b.data;
			
			int q = (v+m) % 10;
			var n = new ListNode(q);
			t.next = n;
			t = n;
			if (v > 9) m = 1;
		
			if (a != null) a = a.next;
			if (b != null) b = b.next;
		}
		if (m > 0) {
			t.next = new ListNode(m);
		}
		
		return r.next;
	}
	
	ListNode BuildNode(int[] xs){
		ListNode h = null;
		ListNode w = null;
		for(int i = xs.Length - 1; i >= 0; i--) {
			var x = xs[i];
			var n = new ListNode(x);
			if (h == null) {
				h = n;
				w = n;
			}
			else {
				w.next = n;
				w = n;
			}
		}
		return h;
	}
	
	public void Add(){
		var a = BuildNode(new int[]{9, 4, 7});
		var b = BuildNode(new int[]{6, 5});
		var r = Add(a, b); //ListNode result !
	}
}