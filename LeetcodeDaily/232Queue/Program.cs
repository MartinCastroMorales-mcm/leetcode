namespace _232Queue;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class MyQueue
    {
        public class Nodo
        {
            public int val;
            public Nodo siguiente;
            public Nodo anterior;

            public Nodo(int val)
            {
                this.val = val;
            }
        }

        Nodo primero;
        Nodo ultimo;

        public MyQueue() { }

        public void Push(int x)
        {
            Nodo nodo = new Nodo(x);
            if (primero == null)
            {
                this.primero = nodo;
                this.ultimo = nodo;
            }
            this.ultimo.anterior = nodo;
            nodo.siguiente = this.ultimo;
            this.ultimo = nodo;
        }

        public int Pop()
        {
            int val = this.primero.val;
            if (this.primero.anterior != null)
            {
                this.primero = this.primero.anterior;
                this.primero.siguiente = null;
            }
            else
            {
                this.primero = null;
                this.ultimo = null;
            }

            return val;
        }

        public int Peek()
        {
            return this.primero.val;
        }

        public bool Empty()
        {
            if (this.primero == null)
            {
                return true;
            }
            return false;
        }
    }
}
