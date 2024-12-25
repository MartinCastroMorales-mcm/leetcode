namespace _2AddTwoNumbers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    } 
 //Definition for singly-linked list.
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }
 
    public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        //manageOffset
        ListNode aux1 = l1;
        ListNode prev1 = l1;
        ListNode aux2 = l2;
        ListNode prev2 = l2;
        ListNode tail = null;
        while(aux1.next != null && aux2.next != null) {
            prev1 = aux1;
            prev2 = aux2;
            aux1 = aux1.next;
            aux2 = aux2.next;
        }
        if(aux1.next == null) {
            prev2.next = null;
            tail = aux2;
        }
        if(aux2.next == null) {
            prev1.next = null;
            tail = aux1;
        }
        //Do sums
        aux1 = l1;
        aux2 = l2;
        while(aux1.next != null) {
            //why tail?????????????????? what am i thinking
        }
    }
}
}
