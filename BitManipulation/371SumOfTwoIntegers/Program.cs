namespace _371SumOfTwoIntegers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int GetSum(int a, int b)
        {
            int c = 0;
            int acc = 0;
            int cBit = 0;
            int aBit = 0;
            int bBit = 0;

            for (int i = 0; i < 32; i++)
            {
                aBit = a & 1;
                bBit = b & 1;
                a = a << 1;
                b = b << 1;

                //acc = 0
                if (acc == 0)
                {
                    cBit = aBit ^ bBit;
                    acc = aBit & bBit;
                }
                else
                {
                    cBit = aBit & bBit;
                    acc = aBit ^ bBit;
                }
                c += cBit << i;
            }
            return c;
        }
    }
}
