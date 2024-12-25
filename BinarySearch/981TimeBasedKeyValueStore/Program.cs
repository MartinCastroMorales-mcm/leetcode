using System.Collections.Generic;
namespace _981TimeBasedKeyValueStore;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TimeMap timeMap = new();
        SortedSet<Nodo> sortedSet = new();
        Nodo nodo = new();
        nodo.value = "test";
        nodo.time = 0;
        sortedSet.Add(nodo);
        timeMap.BSTime(sortedSet);
    }

    public class Nodo
        {
            public int time;
            public string value;

            public int CompareTo(Nodo nodo)
            {
                if (this.time < nodo.time)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }

    public class TimeMap
    {
        

        Dictionary<string, SortedSet<Nodo>> map = new();

        public TimeMap() { }

        public void Set(string key, string value, int timestamp)
        {
            SortedSet<Nodo> sortedSet;
            Nodo nodo;
            nodo = new Nodo();
            nodo.value = value;
            nodo.time = timestamp;
            if (map.TryGetValue(key, out sortedSet))
            {
                sortedSet.Add(nodo);
            }
            else
            {
                sortedSet = new SortedSet<Nodo>();
                sortedSet.Add(nodo);
                map[key] = sortedSet;
            }
        }

        public string Get(string key, int timestamp) { 
            SortedSet<Nodo> sortedSet;
            if(map.TryGetValue(key, out sortedSet)) {
                return BSTime(sortedSet);
            }else {
                return "";
            }
        }

        public string BSTime(SortedSet<Nodo> list) {
            Console.WriteLine(list[0]);
        }
    }
}
