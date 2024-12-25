using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace _128LongestConsecutiveSequence;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public class Secuencia {
            public int miembros = 0;
        }
        public int LongestConsecutive(int[] nums)
        {
            Dictionary<int, Secuencia> map = new();
            int repeticionesMax = 0;
            int repeticioensLoc = 0;
            
            foreach (int n in nums)
            {
                Secuencia secuencia = null;
                if (!map.TryGetValue(n, out secuencia))
                {
                    //sucesor
                    if (map.TryGetValue(n + 1, out secuencia))
                    {
                        Console.WriteLine("n: " + n + "secuencia: " + secuencia.miembros);
                        secuencia.miembros = secuencia.miembros + 1;
                        Console.WriteLine("n: " + n + "secuencia: " + secuencia.miembros);
                        map[n] = secuencia;
                        repeticioensLoc = secuencia.miembros;
                        //antecesor
                    }
                    if(map.TryGetValue(n - 1, out Secuencia secuencia1)){
                        //Console.WriteLine("n: " + n);
                        if(secuencia != null) {
                            Console.WriteLine("n: " + n + "secuencia: " + secuencia.miembros + 
                            " secuencia1: " + secuencia1.miembros);
                            secuencia.miembros = secuencia.miembros + secuencia1.miembros;
                            secuencia1.miembros = secuencia.miembros;
                            repeticioensLoc = secuencia.miembros;

                            
                        }else {
                            secuencia1.miembros = secuencia1.miembros + 1;
                            map[n] = secuencia1;
                            repeticioensLoc = secuencia1.miembros;
                        }
                    }else {
                        secuencia = new Secuencia();
                        secuencia.miembros = 1;
                        map[n] = secuencia;
                        repeticioensLoc = 1;
                    }
                    if (repeticioensLoc > repeticionesMax)
                    {
                        repeticionesMax = repeticioensLoc;
                    }
                }
            }
            return repeticionesMax;
        }
        
    }
}
