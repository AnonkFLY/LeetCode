using System;

public class SolutionIQ2_06
{
    // 做过的题-复健
    public bool IsPalindrome(ListNode head)
    {
        if (head == null)
            return true;
        var mid = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            mid = mid.next;
            fast = fast.next.next;
        }
        if (fast != null)
            mid = mid.next;
        if (mid == null)
            return true;
        //反转
        fast = null;
        while (mid.next != null)
        {
            var temp = fast;
            fast = mid;
            mid = mid.next;
            fast.next = temp;
        }
        mid.next = fast;
        while (mid != null)
        {
            if (mid.val != head.val)
                return false;
            head = head.next;
            mid = mid.next;
        }
        return true;
    }
}