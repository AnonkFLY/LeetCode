public class SolutionIQ2_05
{
    // 输入：(7 -> 1 -> 6) + (5 -> 9 -> 2)，即617 + 295
    // 输出：2 -> 1 -> 9，即912
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        //100%-86.7%
        var result = l1;
        int carry = 0;
        int value = 0;
        while (l2 != null || carry != 0)
        {
            value = l1.val + (l2 == null ? 0 : l2.val) + carry;
            l1.val = value % 10;
            carry = value / 10;
            l2 = l2 == null ? null : l2.next;
            if (l2 != null || carry != 0)
            {
                if (l1.next == null)
                    l1.next = new ListNode();
                l1 = l1.next;
            }
        }
        return result;
        // ListNode result = new ListNode();
        // var temp = result;
        // int carry = 0;
        // int value = 0;
        // while (carry != 0 || l1 != null || l2 != null)
        // {
        //     value = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
        //     temp.val = value % 10;

        //     carry = value / 10;
        //     l1 = l1 == null ? null : l1.next;
        //     l2 = l2 == null ? null : l2.next;
        //     if (carry != 0 || l1 != null || l2 != null)
        //     {
        //         temp.next = new ListNode();
        //         temp = temp.next;
        //     }
        // }
        // return result;
    }
}