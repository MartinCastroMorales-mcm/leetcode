using System;
using System.Collections.Generic;
using System.Globalization;

namespace _146LRUCache;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class LRUCache
    {
        public class Nodo
        {
            public Nodo(int key, int value)
            {
                this.key = key;
                this.value = value;
            }

            public int key;
            public int value;
            public Nodo? siguiente = null;
            public Nodo? anterior = null;
        }

        Dictionary<int, Nodo> elementos;
        Nodo primero;
        Nodo ultimo;
        int capacity = 0;
        int maxCapacity = 0;

        public LRUCache(int capacity)
        {
            this.maxCapacity = capacity;
            this.elementos = new();
        }

        public int Get(int key)
        {
            Console.WriteLine("GET " + key);
            this.ImprimirNodos(this.ultimo);
            Nodo nodo;
            if (this.elementos.TryGetValue(key, out nodo))
            {
                if(nodo == this.primero) {
                    if(this.primero.anterior != null) {
                        this.primero = this.primero.anterior;
                    }
                }
                int value = nodo.value;
                if(nodo.anterior != null && nodo != this.ultimo) {
                    nodo.anterior.siguiente = nodo.siguiente;
                    this.Add(nodo);
                }
                return value;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            Console.WriteLine("PUT " + "(" + key + "," + value + ")");
            this.ImprimirNodos(this.ultimo);
            Nodo nodo;
            if (this.elementos.TryGetValue(key, out nodo))
            {
                nodo.value = value;
                if(nodo == this.primero) {
                    if(this.primero.anterior != null) {
                        this.primero = this.primero.anterior;
                    }
                }
                if (nodo.anterior != null)
                {
                    Nodo nodoAux = nodo.anterior;
                    nodoAux.siguiente = nodo.siguiente;
                }
                this.Add(nodo);
                return;
            }
            if (this.capacity < this.maxCapacity)
            {
                this.capacity++;
                nodo = new Nodo(key, value);
                this.Add(nodo);
                this.elementos[key] = nodo;
                return;
            }
            //remove Least Used
            int Oldkey = this.primero.key;
            Console.Write(Oldkey);
            Nodo anterior = this.primero.anterior;
            if (anterior != null)
            {
                anterior.siguiente = null;
                this.primero = anterior;
            }
            this.elementos.Remove(Oldkey);
            //add newOne
            nodo = new Nodo(key, value);
            this.elementos[key] = nodo;
            this.Add(nodo);
            return;
        }

        private void Add(Nodo nodo)
        {
            if (this.capacity == 1)
            {
                this.ultimo = nodo;
                this.primero = nodo;
            }
            else 
            {
                nodo.siguiente = this.ultimo;
                this.ultimo.anterior = nodo;
                this.ultimo = nodo;
            }
        }
        public void ImprimirNodos(Nodo ultimo) {
            Nodo aux = ultimo;
            while(aux != null) {
                Console.Write("(" + aux.key + "," + aux.value + ") <->");
                aux = aux.siguiente;
            }
            Console.WriteLine(" -|");
        }
    }
    /*
        public class LRUCache
        {
            public class Fila {
                private Nodo primero;
                private Nodo ultimo;
                private class Nodo {
                    public int key;
                    public Nodo next;
                    public Nodo previus;
    
                    public Nodo(int key) {
                        this.key = key;
                    }
                }
                public void Add(int key) {
                    Nodo nodo = new Nodo(key);
                    if(this.ultimo == null) {
                        this.primero = nodo;
                        this.ultimo = nodo;
                        return;
                    }
                    nodo.next = this.ultimo;
                    this.ultimo.previus = nodo;
                    this.ultimo = nodo;
                }
                //returns key of removed node
                public int Remove() {
                    int returnKey = this.primero.key;
                    this.primero = this.primero.previus;
                    this.primero.next = null;
                    return returnKey;
                }
            }
            
            Dictionary<int, int> map = new();
            int usedCapacity = 0;
            int capacity;
            Fila fila;
            public LRUCache(int capacity)
            {
                if (capacity <= 0)
                {
                    throw new ArgumentException("capacity must be positive");
                }
                this.capacity = capacity;
                fila = new();
            }
    
            public int Get(int key) {
                int value;
                if(this.map.TryGetValue(key, out value)) {
                    return value;
                }
                return -1;
                
            }
    
            public void Put(int key, int value) {
                int getValue;
                if(this.map.TryGetValue(key, getValue)) {
                    this.map[key] = value;
                    return;
                }
                if(this.usedCapacity < capacity) {
                    this.fila.Add(key);
                    int removedKey = this.fila.Remove();
                    this.map.Remove(removedKey);
                    return;
                }
    
            }
        }
    
        /**
         * Your LRUCache object will be instantiated and called as such:
         * LRUCache obj = new LRUCache(capacity);
         * int param_1 = obj.Get(key);
         * obj.Put(key,value);
    
    
    
    
    
    
         public class ListNode
            {
                int val;
                ListNode next;
                private static int size = 0;
    
                public ListNode(int val)
                {
                    this.size++;
                    this.val = val;
                }
            }
         */
}
