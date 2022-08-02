public class SolutionIQ2_02
{
    public int KthToLast(ListNode head, int k)
    {
        var fast = head;
        var slow = head;
        while (k-- > 0)
            fast = fast.next;
        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }
        return slow.val;
    }
}