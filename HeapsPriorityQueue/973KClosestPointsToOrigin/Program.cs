using System;
using System.Collections.Generic;

namespace _973KClosestPointsToOrigin;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int[][] KClosest(int[][] points, int k)
        {
            double dOrigen;
            PriorityQueue<int[], double> minHeap = new();
            foreach (int[] point in points)
            {
                //Punto punto = new Punto(point[0], point[1]);
                dOrigen = Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
                minHeap.Enqueue(point, dOrigen);
            }
            int[][] result = new int[k][];
            for (int i = 0; i < k; i++)
            {
                result[i] = minHeap.Dequeue();
            }
            return result;
        }
    }
}
/*
public class Punto {
        public int x;
        public int y;
        public float dOrigen;

        public Punto(int x, int y) {
            this.x = x;
            this.y = y;
            this.dOrigen = Math.Sqrt(Math.Pow(x, 2), Math.Pow(y, 2));
        }
    }
*/
