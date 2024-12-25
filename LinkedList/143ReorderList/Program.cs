namespace _143ReorderList;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        ListNode node = new(4, null);
        node = new(3, node);
        node = new(2, node);
        ListNode head = new(1, node);
        sol.ReorderList(head);
        sol.PrintLinkedList(head);
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
        public void ReorderList(ListNode head)
        {
            if (head == null)
            {
                return;
            }
            ListNode auxLento = head;
            ListNode auxRapido = head;

            while (auxRapido.next != null)
            {
                auxLento = auxLento.next;
                auxRapido = auxRapido.next;
                if (auxRapido.next != null)
                {
                    auxRapido = auxRapido.next;
                }
            }

            auxRapido = auxLento.next;
            ListNode previo = null;
            auxLento.next = null;
            ListNode tmp = null;
            auxLento.next = null;
            while (auxRapido.next != null)
            {
                tmp = auxRapido.next;
                auxRapido.next = previo;
                previo = auxRapido;
                auxRapido = tmp;
            }

            auxLento = head;
            ListNode tmp2;
            while (auxLento.next != null)
            {
                
                tmp = auxLento.next;
                auxLento.next = auxRapido;
                if (auxRapido != null)
                {
                    //Console.Write("aux: (" + auxLento.val + ") -> (" + auxRapido.val + ")");
                    tmp2 = auxRapido.next;
                    auxRapido.next = tmp;
                    auxLento = tmp;
                    auxRapido = tmp2;
                }else {
                    //Console.Write("aux: (" + auxLento.val + ") -> (" + tmp.val + ")");
                    auxLento.next = tmp;
                    auxLento = tmp;
                }
            }
        }

        public void PrintLinkedList(ListNode head) {
            ListNode aux = head;
            while(aux != null) {
                Console.Write("(" + aux.val + ") ->");
                aux = aux.next;
            }
            Console.WriteLine("null");
        }
    }
}
