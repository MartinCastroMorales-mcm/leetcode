namespace _853CarFleet;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            if (position.Length == 0)
            {
                return 0;
            }
            float tAnterior = (target - position[0]) / speed[0];
            int flotas = 1;
            float tActual;
            for (int i = 1; i < position.Length; i++)
            {
                tActual = (target - position[i]) / speed[i];
                if (tAnterior > tActual)
                {
                    flotas++;
                }
                tAnterior = tActual;
            }
        }
    }
}
