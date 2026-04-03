public class HasCycleSolution {
   // MLinked List Cycle Detection
public class ListNode {
     public int val;
     public ListNode? next;
     public ListNode(int val=0, ListNode? next=null) {
         this.val = val;
         this.next = next;
     }
}
    public bool HasCycle(ListNode head) {
        if (head == null) return false;
        var slow = head;
        var fast = slow.next;
        while(fast != null && fast.next != null)
        {
            if (fast == slow) return true;
            slow = slow!.next;
            fast = fast.next.next;
        }
        return false;        
    }

    public bool HasCycleUsingHashSet(ListNode head) {
        var lst = new HashSet<ListNode>();

        var curr = head;
        while (curr != null)
        {
            if (lst.Contains(curr)) return true;
            lst.Add(curr);
            curr = curr.next;
        }


        return false;
        
    }
}
