namespace _206ReverseLinkedList;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

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
        public ListNode ReverseList(ListNode head) { 
            if(head == null) {
                return head;
            }
            if(head.next == null) {
                return head;
            }
            ListNode aux1 = head.next;
            if(aux1.next == null){
                aux1.next = head;
                head.next = null;
                return aux1;
            }
            ListNode aux2 = aux1.next;
            aux1.next = head;
            head.next = null;
            
            while(aux2.next != null) {
                head = aux1;
                aux1 = aux2;
                aux2 = aux2.next;
                aux1.next = head;
            }
            aux2.next = aux1;
            return aux2;
        }
    }
}
