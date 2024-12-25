

using System;
using System.Runtime.InteropServices;

namespace _190ReverseBits;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        uint n = sol.reverseBits(0b11111111111111111111111111111101);
        Console.WriteLine("n: " + Convert.ToString(n,2));
    }

    public class Solution
    {
        public uint reverseBits(uint n) { 
            uint result = 0;
            

            for(int i = 0; i < 32; i++) {
                uint sumando = n & (uint)(1 << i);
                sumando = sumando >> i;
                //Console.WriteLine("sumando" + Convert.ToString(sumando,2) + " sumando " + sumando);
                uint sumandoInvertido = (sumando << 31 - i);
                //Console.WriteLine("sumandoInvertido" + Convert.ToString(sumandoInvertido,2) + " sumandoInvertido " + sumandoInvertido);
                result = result + sumandoInvertido;
                //Console.WriteLine("result: " + Convert.ToString(result,2) + " result " + result);
            }
            return result;
        }
    }
}
