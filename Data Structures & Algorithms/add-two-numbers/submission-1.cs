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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        int resto = 0;
        while (l1 != null || l2 != null || resto != 0)
        {
            int l1val = 0;
            int l2val = 0;
            int valor = 0;
            if (l1 != null)
            {
                l1val = l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2val = l2.val;
                l2 = l2.next;
            }
            
            valor = l1val + l2val + resto;
            resto = 0;

            if (valor >= 10)
            {
                resto = 1;
                valor = valor%10;
            }
            
            current.next = new ListNode(valor);
            current = current.next;
        }

        return dummyHead.next;
    }
}
