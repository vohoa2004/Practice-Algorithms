// problem: https://leetcode.com/problems/merge-two-sorted-lists/?envType=study-plan-v2&envId=programming-skills

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
    public ListNode MergeTwoLists(ListNode p1, ListNode p2) {
        if (p1 == null) return p2;
        if (p2 == null) return p1;
        ListNode head = new ListNode();
        ListNode p = head; // p la con tro chay, day la phep truyen tham chieu!
        
        /*
        head:
        Là nút giả (dummy node) dùng để dễ dàng xây dựng danh sách liên kết mới mà không cần xử lý đặc biệt cho trường hợp nút đầu tiên.
        Luôn giữ nguyên trỏ đến đầu danh sách liên kết mới.
        p:
        Là con trỏ dùng để "đi qua" danh sách mới trong quá trình hợp nhất hai danh sách p1 và p2.
        Từng bước nối các nút từ p1 và p2 vào danh sách mới bắt đầu từ head.
        Bai nay dung y tuong Merge trong Merge Sort
        */
            
        while (p1 != null && p2 != null) {
            if (p1.val < p2.val) {
                p.next = p1;
                p1 = p1.next;
                p = p.next;
            }
            else if (p1.val > p2.val){
                p.next = p2;
                p2 = p2.next;
                p = p.next;
            } else {
                // add ca 2
                p.next = p1;
                p1 = p1.next;
                p = p.next;
                
                p.next = p2;
                p2 = p2.next;
                p = p.next;
            }
        }
        if (p2 == null) {
            while (p1 != null) {
                p.next = p1;
                p1 = p1.next;
                p = p.next;
            }
        }
        if (p1 == null) {
            while (p2 != null) {
                p.next = p2;
                p2 = p2.next;
                p = p.next;
            }
        }
        return head.next; // vi node dau tien la dummy node
    }
}