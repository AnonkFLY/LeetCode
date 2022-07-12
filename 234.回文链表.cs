
using System;
/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int val=0, ListNode next=null) {
*         this.val = val;
*         this.next = next;
*     }
* }
*/
public class Solution234
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode fast, slow;
        fast = slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        if (fast != null)
        {
            slow = slow.next;
        }
        slow = ReverseList(slow);
        while (slow != null)
        {
            if (slow.val != fast.val)
                return false;
            slow = slow.next;
            fast = fast.next;
        }
        return true;
    }

    // md lj题解的有问题，不如我自己写的！(划掉)
    private ListNode ReverseList(ListNode head)
    {
        if (head == null)
            return head;
        ListNode tail = null;
        while (head.next != null)
        {
            var temp = tail;
            tail = head;
            head = head.next;
            tail.next = temp;
        }
        head.next = tail;
        return head;
    }
}