using System;
using static System.Console;

namespace test_ref
{
    class Program
    {
        static void Adiciona20(int x)
        {
            x = x + 20;
        }

        static void Adiciona20ref(ref int a)
        {
            a = a + 20;
        }

        static void Demo1()
        {
            // mostra o funcionamento da palavra chave ref
            int x = 2;
            WriteLine(x);
            Adiciona20(x);
            WriteLine(x);
            WriteLine("-------------");
            WriteLine(x);
            Adiciona20ref(ref x);
            WriteLine(x);
        }

        static void Demo2()
        {
            var nomes = new string[] { "jonatas", "sheila", "olivia", "jessica" };

            WriteLine($"{string.Join(" , \n", nomes)}");

            WriteLine("-------------");

            foreach (var item in nomes)
            {
                WriteLine($"{item}");
            }
            AlterarNome(nomes, "jonatas", "fred");
            WriteLine("---------------");
            foreach (var item in nomes)
            {
                WriteLine($"{item}");
            }
            WriteLine("\n ------------- \n");
            AlterarNome(nomes, "jessica", "rossetto");

            WriteLine($"{string.Join(" , \n", nomes)}");

            WriteLine("-------------");

        }

        static int LocalizaNome(string[] nomes, string nome)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    return i;
                }
            }
            return -1;
        }

        static void TrocaNome(string[] nomes, int indice, string nomeNovo)
        {
            nomes[indice] = nomeNovo;
        }

        static void AlterarNome(string[] nomes, string nome, string nomeNovo)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;
                }
            }
        }

        static void Main()
        {
            var nomes = new string[] { "jonatas", "sheila", "olivia", "jessica" };

            WriteLine($"{string.Join(" , \n", nomes)}");

            var indice = LocalizaNome(nomes, "olivia");
            //WriteLine($"indice {indice}");
            WriteLine($"indice {indice}");
            TrocaNome(nomes, indice, "matsuoka");

            WriteLine($"{string.Join(" , \n", nomes)}");


        }
    }

}