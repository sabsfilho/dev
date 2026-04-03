public class MergeTwoListsSolution {
   // Merge Two Sorted Linked Lists
public class ListNode {
     public int val;
     public ListNode? next;
     public ListNode(int val=0, ListNode? next=null) {
         this.val = val;
         this.next = next;
     }
}
    public ListNode? MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode? head = null;
        ListNode? curr = null;
        ListNode c1 = list1;
        ListNode c2 = list2;
        while (c1 != null || c2 != null)
        {
            ListNode? c = null;
            if (c2 == null || (c1 != null && c2 != null && c1.val < c2.val))
            {
                c = new ListNode(c1!.val);
                c1 = c1.next!;
            }
            else if (c2 != null)
            {
                c = new ListNode(c2.val);
                c2 = c2.next!;
            }
            if (head == null) 
            {
                head = c;
            }
            else
            {
                curr!.next = c;
            }
            curr = c;
        }
        

        return head;
        
    }
}