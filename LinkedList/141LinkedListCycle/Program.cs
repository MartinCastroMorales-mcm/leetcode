using System.Collections.Generic;

namespace _141LinkedListCycle;

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

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if(head == null) {
                return false;
            }
            Dictionary<ListNode, bool> map = new();
            ListNode aux = head;
            while (aux.next != null)
            {
                if (map.TryAdd(aux, true))
                {
                    aux = aux.next;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
