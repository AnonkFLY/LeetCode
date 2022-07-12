
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
    //2022年7月9日 尝试原地反转，原:使用栈
    public ListNode ReverseList(ListNode head)
    {
        // form beat solution  2022年7月11日补充: 这个方式是有问题的
        // if (head == null)
        //     return head;
        // ListNode tail = null;
        // while (head != null)
        // {
        //     var temp = head.next;
        //     head.next = tail;
        //     tail = head;
        //     head = temp;
        // }
        // return head;
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
        // use stakc...
        // Stack<ListNode> stack = new Stack<ListNode>();
        // if (head == null)
        //     return head;
        // while (head != null)
        // {
        //     stack.Push(head);
        //     head = head.next;
        // }
        // head = stack.Pop();
        // var last = head;
        // while (stack.Count > 0)
        // {
        //     var get = stack.Pop();
        //     last.next = get;
        //     last = last.next;
        // }
        // last.next = null;
        // return head;
    }
}