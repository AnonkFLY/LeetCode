using System.Collections.Generic;

public class SolutionIQ2_01
{
    public ListNode RemoveDuplicateNodes(ListNode head)
    {
        if (head == null)
            return head;
        HashSet<int> table = new HashSet<int>();
        var temp = head;
        table.Add(head.val);
        while (temp.next != null)
        {
            if (table.Add(temp.next.val))
                temp = temp.next;
            else
                temp.next = temp.next.next;
        }
        return head;
    }
}