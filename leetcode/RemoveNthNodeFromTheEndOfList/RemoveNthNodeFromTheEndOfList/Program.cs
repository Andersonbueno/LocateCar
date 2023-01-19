/**
 * Definition for singly-linked list.
 */

public class ListNode {
  public int val;
  public ListNode? next;
  public ListNode( int val = 0, ListNode next = null) {
    this.val = val;
    this.next = next;
  }
 }

public class Solution {

    public static int size(ListNode head) {

        ListNode current = head;
        int count = 0;

        while (current != null) {
            count++;
            current = current.next;
        }

        return count;
    }

    public static ListNode RemoveNthFromEnd(ListNode head, int n) {

        ListNode current = head.next; // inicialização
        int position = 0, length = size(head);


        while (current != null) { // verificação

            if (position + 1 == length - n) { // 1 2 3 4 5
                if (n == 1) { // caso remova o ultimo
                    current.next = null; // o prox do penult é null        
                } else {
                    current.next = current.next.next;
                }
                break;
            }

            position++;
            current = current.next; // atualização
        }

        return head.next;
    }

    public static void PrintList(ListNode head) {
        ListNode current = head;
        while(current != null) {
            Console.WriteLine(current.val);
            current = current.next;
        }
    }

    public static void Main(string[] args) {
        ListNode head = new ListNode();
        ListNode iterator = head;

        iterator.next = new ListNode(1);
        iterator = iterator.next;

        iterator.next = new ListNode(2);
        iterator = iterator.next;
        
        iterator.next = new ListNode(3);
        iterator = iterator.next;

        iterator.next = new ListNode(4);
        iterator = iterator.next;

        iterator.next = new ListNode(5);

        PrintList(RemoveNthFromEnd(head, 1));

    }
}