using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace _621TackScheduler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        int x = sol.LeastInterval(['A','A','A','B','B','B'], 2);
        Console.WriteLine("test " + x);
    }

    public class Solution
    {
        public class Task
    {
        public char letter;
        public int workRemaining = 1;
        public int timeLastWork = -1000; //prioridad = 100*work

        public Task()
        {
            this.workRemaining = 1;
        }
    }
        public int LeastInterval(char[] tasks, int n)
        {
            Dictionary<char, Task> map = new();
            List<Task> list = new();
            Task tk;

            foreach (char c in tasks)
            {
                if (map.TryGetValue(c, out tk))
                {
                    tk.workRemaining = tk.workRemaining + 1;
                }
                else
                {
                    tk = new Task();
                    tk.letter = c;
                    list.Add(tk);
                    map[c] = tk;
                }
            }
            PriorityQueue<Task, int> heap = new();
            foreach (Task tak in list)
            {
                heap.Enqueue(tak, tak.workRemaining * -100);
            }
            int time = 0;
            while (heap.Count != 0)
            {
                Console.Write("Time: " + time + " " + heap.Count + " HeapPeek " + heap.Peek().letter);
                if(heap.Peek().workRemaining == 0) {
                    heap.Dequeue();
                }else if (time - heap.Peek().timeLastWork > n)
                {
                    Task tak = heap.Dequeue();
                    
                    tak.workRemaining--;
                    tak.timeLastWork = time;
                    Console.WriteLine(tak.letter + " [work: " + tak.workRemaining 
                    + " time: " + tak.timeLastWork + "]");
                    if (tak.workRemaining != 0)
                    {
                        heap.Enqueue(tak, tak.workRemaining * -100 + 10);
                    }
                }else {
                    Task tak = GetNextUsable(list, n, time);
                    if(tak != null) {
                        tak.workRemaining--;
                    }else {
                        Console.WriteLine("idle ");
                    }
                    
                    
                }
                time++;
            }

            return time;
        }
        public Task GetNextUsable(List<Task> list, int n, int time) {
            foreach(Task task in list) {
                if(time - task.timeLastWork > n) {
                    return task;
                }
            }
            return null;
        }
    }
}
