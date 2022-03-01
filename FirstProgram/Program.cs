// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
// using vetor;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            vetor v = new vetor();
            v.Set(6,4);
            Console.WriteLine(v.Comprimento());


            // int numeroDeVezes = 5;
            // Console.WriteLine("Hello World!");
            // for (int i=0;i<numeroDeVezes;i++){
            //     Console.WriteLine(i);
            // }

            // int a=5;
            // const int b=6;
            // Console.WriteLine(a+b);
            
            // string texto;

            // texto = "teste de texto de string";
            // Console.WriteLine(texto);
            // Console.WriteLine(texto.Length);

            // if (texto.Length == 1)
            // {
            //     Console.WriteLine("um caracter");
            // } else
            // {
            //     Console.WriteLine($"o texto possui {texto.Length} caracteres");
            // }
            // for (int i=0; i<texto.Length; i++)
            // {
            //     Console.WriteLine($"o caracter #{i} é ${texto[i]}");
            // }

            // using(System.IO.TextWriter w=System.IO.File.CreateText("exemplo.txt"))
            // {
            //     w.WriteLine("linha 1");
            //     w.WriteLine("linha 2");
            //     w.WriteLine("linha 3");
            //     w.WriteLine("linha 4");
            // }
            // // Console.WriteLine(w);

            // int[] numbers = {1,2,3,4,5}; // vetor estático

            // for (int i=0;i<numbers.Length;i++)
            // {
            //     Console.WriteLine($"teste[{i}]={numbers[i]}");
            // }
            
            // Array.Resize(ref numbers, 10);

            // for (int i=0;i<numbers.Length;i++)
            // {
            //     Console.WriteLine($"teste[{i}]={numbers[i]}");
            // }

            // // int[] numbersDinamico = new int[] {1,2,3,4,5};

            // // for (int i=0;i<numbersDinamico.Length;i++)
            // // {
            // //     Console.WriteLine($"teste[{i}]={numbersDinamico[i]}");
            // // }
            // // // numbersDinamico.Append(100);
            // // // numbersDinamico.Append(100);
            // // // numbersDinamico.Add(1000);
            // // numbersDinamico[5]=10;

            // // for (int i=0;i<numbersDinamico.Length;i++)
            // // {
            // //     Console.WriteLine($"teste[{i}]={numbersDinamico[i]}");
            // // }



            // // Console.WriteLine(numbers[5]);
        }
    }
}