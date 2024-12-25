using System.Collections.Generic;

namespace _739;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] resultado = new int[temperatures.Length];
            Stack<int> pila = new();
            pila.Push(0);
            int i = 1;
            while (i < temperatures.Length)
            {
                if (pila.Count != 0)
                {
                    if (temperatures[pila.Peek()] < temperatures[i])
                    {
                        resultado[pila.Peek()] = i - pila.Peek();
                        pila.Pop();
                    }
                    else
                    {
                        pila.Push(i);
                        i++;
                    }
                }
                else
                {
                    pila.Push(i);
                    i++;
                }
            }
            return resultado;
        }
    }
}
