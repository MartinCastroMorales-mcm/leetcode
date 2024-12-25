using System.Collections.Generic;

namespace _22GenerateParentesis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        List<string> list = (List<string>)sol.GenerateParenthesis(3);
        foreach (string s in list)
        {
            Console.WriteLine("[" + s + "]");
        }
    }

    public class Solution
    {
        public IList<string> GenerateParenthesis(int n) {
            string combination = "";
            Stack<int> newStack = new();
            List<string> list = new();
            backtracking(combination, newStack, n, list, 0, 0); 
            return list;
         }

        public void backtracking(
            string combination,
            Stack<int> stack,
            int n,
            List<string> superList,
            int numClosedParen,
            int numLeftParen
        )
        {
            Console.WriteLine(combination);
            //accept
            if (numClosedParen == n)
            {
                superList.Add(combination);
                return;
            }
            if (numLeftParen < n)
            {
                Stack<int> newStack = new(stack);
                newStack.Push('(');
                backtracking(
                    combination + '(',
                    newStack,
                    n,
                    superList,
                    numClosedParen,
                    numLeftParen + 1
                );
            }

            if (stack.Count != 0)
            {
                Stack<int> newStack = new(stack);
                newStack.Pop();
                backtracking(
                    combination + ')',
                    newStack,
                    n,
                    superList,
                    numClosedParen + 1,
                    numLeftParen
                );
            }
        }
    }
}
