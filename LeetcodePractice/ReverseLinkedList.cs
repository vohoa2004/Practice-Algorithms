// problem: https://leetcode.com/problems/reverse-linked-list/?envType=study-plan-v2&envId=programming-skills

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
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null) return head;
        ListNode p = head; // current pointer to traverse the linked list
        ListNode prev = null; // previous node of current node, to swap with p.next later
        ListNode temp; // hold the old p.next to move on ahead after changing direction
        while(p != null) {
            temp = p.next;
            p.next = prev;
            prev = p; // ~ move prev forward but not access prev.next because at the beginning prev = null
            p = temp; // ~ p = p.next_old (move p forward)
        }
        return prev;
    }
}