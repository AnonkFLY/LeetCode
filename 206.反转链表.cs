
using System;
using System.Collections.Generic;
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
public class Solution206
{
    public ListNode ReverseList(ListNode head)
    {
        Stack<ListNode> stack = new Stack<ListNode>();
        if (head == null)
            return head;
        while (head != null)
        {
            stack.Push(head);
            head = head.next;
        }
        head = stack.Pop();
        var last = head;
        while (stack.Count > 0)
        {
            var get = stack.Pop();
            last.next = get;
            last = last.next;
        }
        last.next = null;
        return head;
    }
}