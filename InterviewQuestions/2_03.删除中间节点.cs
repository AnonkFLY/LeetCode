public class SolutionIQ2_03
{
    // Kill mr B
    public void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}