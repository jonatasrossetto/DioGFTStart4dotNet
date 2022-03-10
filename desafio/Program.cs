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
            //**********************************************************************
            // double a, b, c;
            // // a = 6;
            // // b = 4;
            // // c = 2.1234;
            // //string[] valor = Console.ReadLine().Replace(".", ",").Split();
            // string[] valor = Console.ReadLine().Split();
            // a = Convert.ToDouble(valor[0]);
            // b = Convert.ToDouble(valor[1]);
            // c = Convert.ToDouble(valor[2]);
            // List<double> abc = new List<double> { a, b, c };
            // abc.Sort();
            // // Console.WriteLine(abc[0]);
            // // Console.WriteLine(abc[1]);
            // // Console.WriteLine(abc[2]);
            // double perimetro = abc.Sum();
            // double area = (a + b) * c / 2;

            // string saida = "";
            // if (abc[0] + abc[1] > abc[2])
            // {
            //     // Console.WriteLine("triangulo");
            //     saida = "Perimetro = " + perimetro.ToString("0.0");

            // }
            // else
            // {
            //     // Console.WriteLine("trapezio");
            //     saida = "Area = " + area.ToString("0.0");//string.Format("{0:0.#}", area);
            // }

            // //            Console.WriteLine(area.ToString("0.0"));
            // Console.WriteLine(saida);
            //**********************************************************************
            Console.Clear();
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            //int totalDeCasosDeTeste = 2;
            string[] listas = new string[totalDeCasosDeTeste];
            //string lista = "carne laranja suco picles laranja picles";
            //listas[0] = "carne laranja suco picles laranja picles";
            //listas[1] = "laranja pera laranja pera pera";
            // entrada das listas
            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                listas[i] = Console.ReadLine();
            }
            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                string[] listaVetor = listas[i].ToLower().Split(" ");

                listaVetor = listaVetor.ToList().Distinct().ToArray();
                Array.Sort(listaVetor);
                string listaTratada = string.Join(" ", listaVetor);
                Console.WriteLine(listaTratada);
            }


            // string[] listaVetor = lista.ToLower().Split(" ");
            // foreach (var item in listaVetor)
            //     {
            //         Console.WriteLine(item);
            //     }
            // Console.WriteLine("**************");
            // listaVetor = listaVetor.ToList().Distinct().ToArray();
            // foreach (var item in listaVetor)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("**************");
            // string listaTratada = string.Join(" ", listaVetor);
            // Console.WriteLine(listaTratada);


        }
    }
}