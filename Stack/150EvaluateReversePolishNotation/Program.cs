using System;
using System.Collections.Generic;


namespace _150EvaluateReversePolishNotation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> numStack = new();
            int a;
            int b;
            int resultado;
            for (int i = 0; i < tokens.Length; i++)
            {
                char c;
                int result; 
                if(int.TryParse(tokens[i], out result)) {
                    numStack.Push(result);
                }else if(flag){
                    b = numStack.Pop();
                    c = tokens[i][0];
                    a = numStack.Pop();
                    Console.WriteLine(a + " " + c + " " + b);
                    resultado = DoOperation(a, b, c);
                    numStack.Push(resultado);
                }
                
            }
            return numStack.Pop();
        }

        public int DoOperation(int a, int b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
            }
            return -1;
        }
    }
}
