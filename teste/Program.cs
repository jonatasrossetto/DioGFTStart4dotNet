using System;


class Program
{
    static void Main(string[] args)
    {
        bool end = false;
        do
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                end = true;
            }
            else if ((x % 2) == 0)
            {
                //Console.WriteLine("x é par!!!");
                int soma = 0;
                for (int i = 0; i < 5; i++)
                {
                    soma = soma + x + i * 2;
                }
                Console.WriteLine(soma);
            }
            else if ((x % 2) != 0)
            {
                //Console.WriteLine("x é ímpar!!!");
                int soma = 0;
                x = x + 1;
                for (int i = 0; i < 5; i++)
                {
                    soma = soma + x + i * 2;
                }
                Console.WriteLine(soma);
            }

        }
        while (end == false);
        //Console.WriteLine("Fim")
    }
}

