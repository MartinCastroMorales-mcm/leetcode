using System.Collections.Generic;

namespace _279PerfectSquares;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        sol.NumSquares(0);
    }

    public class Solution
    {
        public int NumSquares(int n)
        {
            int count = 0;
            List<int> perfectSquares = new();
            int result = 0;
            int factor = 1;
            while (result <= 10000)
            {
                result = factor * factor;
                Console.WriteLine(result);
                factor++;
                perfectSquares.Add(result);
            }

            int left = 0;
            int right = 100;

            while (left <= right)
            {
                m = left + (right - left) / 2;
                if (perfectSquares[m] <= n && perfectSquares[m + 1] > n)
                {
                    right = m-1;
                    left = 0;
                    //No se puede 12: 9 + 1 + 1 + 1 cuando deberia ser 4 + 4 + 4. se deberia resolver con programacion dinamica.
                    n -= perfectSquares[m];
                    count++;
                    if (n == 0)
                    {
                        return count;
                    }
                }
                else if (perfectSquares[m] < n)
                {
                    left = m + 1;
                }
                else if (perfectSquares[m] > n)
                {
                    right = m - 1;
                }
            }
            return count;
        }
    }
}
