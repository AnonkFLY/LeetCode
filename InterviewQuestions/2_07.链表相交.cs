public class SolutionIQ2_07
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null)
            return null;
        var pa = headA; var pb = headB;
        while (pa != null && pb != null)
        {
            pa = pa == null ? headB : pa.next;
            pb = pb == null ? headA : pb.next;
        }
        return pa;
    }
}