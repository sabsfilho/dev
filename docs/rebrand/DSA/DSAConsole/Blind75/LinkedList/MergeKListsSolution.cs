public class MergeKListsSolution {    
    //Merge K Sorted Linked Lists
public class ListNode {
     public int val;
     public ListNode? next;
     public ListNode(int val=0, ListNode? next=null) {
         this.val = val;
         this.next = next;
     }
}
    public ListNode? MergeKLists(ListNode[] lists) {
        /*
        loop each list, take the lower add to node

        */
        if (lists == null || lists.Length == 0) return null;

        ListNode? head = null;
        ListNode? curr = null;
        while(true)
        {
            int m = 0;
            ListNode? min = null;
            for(int i=0; i<lists.Length; i++)
            {
                var v = lists[i];
                if (v == null) continue;
                if (min == null || v.val < min.val)
                {
                    min = v;
                    m = i;
                }
            }
            if (head == null)
                head = min;
            else
                curr!.next = min;
            if (min == null) break;
            lists[m] = min.next!;
            curr = min;
        }

        return head;        
    }
}
