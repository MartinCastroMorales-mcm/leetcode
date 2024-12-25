namespace _138CopyListWithRanvdomPointer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Node n1 = new(1);
        Node n2 = new(2);
        Node n3 = new(3);
        n1.next = n2;
        n2.next = n3;
        n1.random = n3;
        n2.random = null;
        n3.random = n1;
        Solution sol =new();
        sol.CopyRandomList(n1);
    }

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }
            Dictionary<Node, Node> map = new(); //Lista1 -> Lista2
            Node head2 = new(head.val);
            Node aux1 = head;
            Node fromMap;
            Node randomAux1;
            Node randomAux2;
            Node aux2 = head2;
            map.TryAdd(head, head2);
            while (aux1 != null)
            {
                if(aux1.next == null) {
                    aux2.next = null;
                }else if (map.TryGetValue(aux1.next, out fromMap))
                {
                    aux2.next = fromMap;
                }
                else
                {
                    randomAux2 = new Node(aux1.next.val);
                    aux2.next = randomAux2;
                    map.TryAdd(aux1, randomAux2);
                }
                randomAux1 = aux1.random;
                if(randomAux1 == null) {
                    aux1.random = null;
                }else if(map.TryGetValue(randomAux1, out fromMap)) {
                    aux2.random = fromMap;
                }else {
                    randomAux2 = new Node(randomAux1.val);
                    aux2.random = randomAux2;
                    map[randomAux1] = randomAux2;
                }
                aux1 = aux1.next;
                aux2 = aux2.next;



            }
            return head2;
        }
    }
}
