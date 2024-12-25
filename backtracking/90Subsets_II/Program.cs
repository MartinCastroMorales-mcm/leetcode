using System;
using System.Collections.Generic;

namespace _90Subsets_II;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        List<IList<int>> list = new List<IList<int>>(sol.SubsetsWithDup([1, 2, 2]));
        foreach(List<int> l in list) {
            Console.Write("[");
            foreach(int n in l) {
                Console.Write(n + ",");
            }
            Console.WriteLine("]");
        }
    }

    public class Solution
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<IList<int>> superLista = new();
            List<int> list = new();
            Dictionary<int, int> map = new(); //int -> repetitions
            Dictionary<int, int> mapList = new();
            foreach (int n in nums)
            {
                if (!map.TryAdd(n, 1))
                {
                    map[n] = map[n] + 1;
                }
                mapList[n] = 0;
            }
            backtracking(superLista, list, nums, map, mapList);
            return superLista;
        }

        public void backtracking(
            List<IList<int>> superLista,
            List<int> lista,
            int[] nums,
            Dictionary<int, int> map, //nums.int -> repetitions
            Dictionary<int, int> mapList //list.int -> repetitions
        )
        {
            //accept
            superLista.Add(lista);

            //make leafs

            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                if(i != 0) {
                    while(nums[i] == nums[i-1]) {
                        i++;
                    }
                    if(i >= nums.Length) {
                        break;
                    }
                    n = nums[i];
                }
                int value;
                if(!mapList.TryGetValue(n, out value)) {

                    mapList[n] = 0;
                }
            if (mapList[n] < map[n])
                {
                    List<int> nuevaLista = new();
                    Dictionary<int, int> nuevoMapa = new();
                    foreach (int nLista in lista)
                    {
                        nuevaLista.Add(nLista);
                        nuevoMapa[nLista] = mapList[nLista];
                    }
                    nuevaLista.Add(n);
                    if (!nuevoMapa.TryAdd(n, 1))
                    {
                        nuevoMapa[n] = nuevoMapa[n] + 1;
                    }
                    backtracking(superLista, nuevaLista, nums, map, nuevoMapa);
                }
            }
        }
    }
}
