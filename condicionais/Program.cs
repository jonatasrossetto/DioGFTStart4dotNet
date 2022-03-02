using System;
using static System.Console;

namespace condicionais
{

    class Program
    {
        public static string NomeDoMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    {
                        return "Janeiro";
                    }
                case 2:
                    {
                        return "Fevereiro";
                    }
                case 3:
                    {
                        return "Março";
                    }
                case 4:
                    {
                        return "Abril";
                    }
                case 5:
                    {
                        return "Maio";
                    }
                case 6:
                    {
                        return "Junho";
                    }
                case 7:
                    {
                        return "Julho";
                    }
                case 8:
                    {
                        return "Agosto";

                    }
                case 9:
                    {
                        return "Setembro";

                    }
                case 10:
                    {
                        return "Outubro";

                    }
                case 11:
                    {
                        return "Novembro";

                    }
                case 12:
                    {
                        return "Dezembro";

                    }
            }

            return ("O valor digitado não corresponde a um mês");

        }


        static void Main()
        {
            // Double a;
            // Double b;
            // WriteLine("Entre com o numero A: ");
            // a = Double.Parse(ReadLine());
            // WriteLine("Entre com o numero B: ");
            // b = Double.Parse(ReadLine());
            // WriteLine($"{a} + {b} = {a + b}");
            int idade;
            WriteLine("Digite a sua idade: ");
            idade = int.Parse(ReadLine());
            if (idade >= 18)
            {
                WriteLine("Você tem mais de 18 anos");
            }
            else
            {
                WriteLine("Você tem menos de 18anos");
            }

            // int mes;
            // WriteLine("Digite o numero do mes: ");
            // mes = int.Parse(ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                WriteLine(NomeDoMes(i));
            }

            List<string> produtos = new List<string>();
            produtos.Add("Detergente para lavar roupas");
            produtos.Add("Amaciante de roupas");
            produtos.Add("Água Sanitária");
            produtos.Add("Desinfetante");
            produtos.Add("Sabão em barra");
            produtos.ind
            foreach (var item in produtos)
            {
                WriteLine(item);
            }


        }




    }

}