namespace _19RemoveNthNodeFromEndOfList;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n) { 
            if(head.next == null && n >= 1) {
                return null;
            }
            ListNode ptr1 = head;
            ListNode ptr2 = head;
            ListNode aux = head;
            for(int i = 0; i < n; i++) {
                ptr2 = ptr2.next;
                //Console.WriteLine(ptr2.val);
            }
            if(ptr2 != null) {
                while(ptr2.next != null) {
                ptr2 = ptr2.next;
                ptr1 = ptr1.next;
            }
            }else {
                return ptr1.next;
            }
            
            ListNode tmp = ptr1;
            ptr1 = ptr1.next;
            if(ptr1 != null) {
                ptr1 = ptr1.next;
            }
            tmp.next = ptr1; 
            //Console.WriteLine("end");
            return head;
        }
    }
}
