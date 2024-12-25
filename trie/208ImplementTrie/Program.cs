namespace _208ImplementTrie;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Trie
    {
        public class Nodo
        {
            public char val;
            public Dictionary<char, Nodo> map;
            public bool isEndOfWord = false;

            public Nodo(char val)
            {
                this.val = val;
                map = new();
            }
        }

        Nodo cabeza = new Nodo('.');

        public Trie() { }

        public void Insert(string word)
        {
            Nodo aux = this.cabeza;
            Nodo value;
            Console.WriteLine("insert");
            foreach (char c in word)
            {
                Console.WriteLine("(" + c + ")");
                if (aux.map.TryGetValue(c, out value))
                {
                    aux = value;
                }
                else
                {
                    value = new(c);
                    aux.map.TryAdd(c, value);
                }
            }
            aux.isEndOfWord = true;
        }

        public bool Search(string word)
        {
            Nodo aux = this.cabeza;
            Nodo value;
            Console.WriteLine("search");
            foreach (char c in word)
            {
                Console.WriteLine("(" + c + ")");
                if (aux.map.TryGetValue(c, out value))
                {
                    aux = value;
                }
                else
                {
                    return false;
                }
            }
            if (aux.isEndOfWord)
            {
                return true;
            }
            return false;
        }

        public bool StartsWith(string prefix)
        {
            Nodo aux = this.cabeza;
            Nodo value;
            foreach (char c in prefix) 
            {   
                if(aux.map.TryGetValue(c, out value)) {
                    aux = value;
                }else {
                    return false;
                }
            }
            if(aux.map.Count != 0 || aux.isEndOfWord){
                return true;
            }
            return false;
        }
    }
}
