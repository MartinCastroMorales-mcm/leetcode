using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public long FlowerGame(int n, int m)
        {
            
            Dictionary<int, int>
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((n & 1) == 1 ^ (m & 1) == 1)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
