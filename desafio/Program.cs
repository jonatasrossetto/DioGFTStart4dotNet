using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n, nota, quociente, resto;
            // int[] notas = new int[7] { 100, 50, 20, 10, 5, 2, 1 };

            // n = int.Parse(Console.ReadLine());
            // Console.WriteLine(n);

            // resto = n;

            // foreach (var item in notas)
            // {
            //     nota = item;
            //     quociente = resto / nota;
            //     Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            //     resto = resto % nota;
            //     //Console.WriteLine($"{resto}");
            // }

            //Continue com a sua lógica aqui

            double a, b, c;
            string[] valor = Console.ReadLine().Replace(".", ",").Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            List<double> abc = new List<double> { a, b, c };
            abc.Sort();
            // Console.WriteLine(abc[0]);
            // Console.WriteLine(abc[1]);
            // Console.WriteLine(abc[2]);
            if (abc[0] + abc[1] > abc[2])
            {
                // Console.WriteLine("triangulo");
                Console.WriteLine("Perimetro = " + abc.Sum());

            }
            else
            {
                // Console.WriteLine("trapezio");
                Console.WriteLine("Area = " + ((a + b) * c / 2));
            }



        }
    }
}