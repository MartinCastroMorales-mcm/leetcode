using System.Collections.Generic;

namespace _46Permutations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> superLista = new();
            int[] usados = new int[nums.Length];
            List<int> lista = new();
            backtracking(nums, usados, superLista, lista);
            return superLista;
        }

        public void backtracking(
            int[] nums,
            int[] usados,
            List<IList<int>> superLista,
            List<int> lista
        )
        {
            if (lista.Count == nums.Length)
            {
                superLista.Add(lista);
                return;
            }
            
            for(int i = 0; i < nums.Length; i++) {
                if(usados[i] != 1) {
                    int[] nuevoUsado = new int[usados.Length];
                    List<int> nuevaLista = new List<int>();
                    for(int j = 0; j < nums.Length; j++) {
                        nuevoUsado[j] = usados[j];
                        if(j < lista.Count) {
                            nuevaLista.Add(lista[j]);
                        }

                    }
                    nuevoUsado[i] = 1;
                    nuevaLista.Add(nums[i]);
                    backtracking(nums, nuevoUsado, superLista, nuevaLista);
                }
            }
        }
    }
}
