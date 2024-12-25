using System;
using System.Collections;
using System.Collections.Generic;

namespace _2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public class Solution {
        //Diccionario numaro, numero de veces que se repite
        Dictionary<int,int> numeroRepeticion; 
        //Diccionarios dado un numero x da lista de numeros Potecia de 
        Dictionary<int, List<int>> map; 
        List<int> buscando = new();
        Dictionary<int, List<int>> posiblesListas = new();
    public int MaximumLength(int[] nums) {
        Array.Sort(nums);
        List<int> list;
        foreach(int n in nums) {
            if(!posiblesListas.TryGetValue(n, out list)) {
                list = new List<int>();
                list.Add(n);
                posiblesListas.Add(n, list);
                buscando.Add(n*n);
            }else {
                if(buscando.Contains(n)) {
                    //posiblesListas[n].Add(n)
                }
            }




            float sqrtN = Math.Sqrt(n);
            if(numeroRepeticion.ContainsKey(sqrtN)) {
                
            }
            if(numeroRepeticion.TryAdd(n, 1)) {

            }else {
                numeroRepeticion[n] = numeroRepeticion[n] + 1;
            }
        }
    }
}
}
