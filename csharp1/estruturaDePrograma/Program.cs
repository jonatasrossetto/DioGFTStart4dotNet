// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace EstruturaDePrograma // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Pilha();
            /*
            stack.Empilha(1);
            stack.Empilha(10);
            stack.Empilha(100);
            stack.Empilha(1000);
            Console.WriteLine(stack.Desempilha());
            Console.WriteLine(stack.Desempilha());
            Console.WriteLine(stack.Desempilha());
            Console.WriteLine(stack.Desempilha());
            */
            stack.Empilha("a");
            stack.Empilha("b");
            stack.Empilha("c");
            stack.Empilha("d");
            Console.WriteLine(stack.Desempilha());
            Console.WriteLine(stack.Desempilha());
            Console.WriteLine(stack.Desempilha());
            Console.WriteLine(stack.Desempilha());
            Console.WriteLine(stack.Desempilha());
        }
    }
}

