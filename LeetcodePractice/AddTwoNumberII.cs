// problem: https://leetcode.com/problems/add-two-numbers-ii/description/?envType=study-plan-v2&envId=programming-skills

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
    // Approach: sum the numbers in reversed order (~ sum the digits of orginal numbers from right to left) 
    // In each place, append the each calculated digit to the head of the result linked list
    // every add operation must have 2 things: digit = totalSum % <number base>, carry = totalSum / <number base>
    private ListNode Reverse(ListNode l) {
        ListNode prev = null;
        ListNode p = l;
        while (p != null) {
            ListNode temp = p.next;
            p.next = prev;
            prev = p;
            p = temp; 
        }
        return prev;
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        l1 = Reverse(l1);
        l2 = Reverse(l2);
        int totalSum = 0, carry = 0; // totalSum is the sum of 2 digit at that place
        ListNode ans = new ListNode();
        while (l1 != null || l2 != null) {
            if (l1 != null) {
                totalSum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null) {
                totalSum += l2.val;
                l2 = l2.next;
            }
            ans.val = totalSum % 10; // the digit = total sum digit % 10
            carry = totalSum / 10; // carry = total sum digit / 10
            ListNode head = new ListNode(carry); // append new digit to the head of the linked list
            head.next = ans;
            ans = head;
            totalSum = carry; // gan totalSum
        }

        return carry == 0 ? ans.next: ans; // return ans.next if carry = 0 (head = 0)
    }
}