using System;
using static System.Console;

namespace exemplovalorreferencia
{
    public class Program
    {
        static int Adicionar20(int x)
        {
            return (x + 20);
        }

        static void TrocarNome(Pessoa p, string novoNome)
        {
            p.Nome = novoNome;
        }

        static StructPessoa TrocarNomeStruct(StructPessoa p, string novoNome)
        {
            p.Nome = novoNome;
            return p;
        }

        public static void Main()
        {
            int a = 2;
            a = Adicionar20(a);
            WriteLine($"teste {a}");

            Pessoa p2 = new Pessoa();
            Pessoa p1 = new Pessoa();
            p1.Nome = "Jonatas";
            p1.Idade = 20;
            p1.Documento = "abc1234";

            p2 = p1;

            WriteLine($"Nome anterior p1: {p1.Nome}");
            WriteLine($"Nome anterior p2: {p2.Nome}");
            WriteLine($"Idade p1: {p1.Idade}");
            WriteLine($"Idade p2: {p2.Idade}");
            TrocarNome(p1, "Jonatas Fred");
            p2.Idade = 30;
            WriteLine($"Nome posterior p1: {p1.Nome}");
            WriteLine($"Nome posterior p2: {p2.Nome}");
            WriteLine($"Idade p1: {p1.Idade}");
            WriteLine($"Idade p2: {p2.Idade}");

            Pessoa p3 = new Pessoa();
            // p3.Nome = p1.Nome;
            // p3.Idade = p1.Idade;
            // p3.Documento = p1.Documento;
            p3 = p1.Clone();

            WriteLine($"Nome anterior p1: {p1.Nome}");
            WriteLine($"Nome anterior p3: {p3.Nome}");
            WriteLine($"Idade p1: {p1.Idade}");
            WriteLine($"Idade p3: {p3.Idade}");
            TrocarNome(p1, "Jonatas Fred Rossetto");
            p3.Idade = 40;
            WriteLine($"Nome posterior p1: {p1.Nome}");
            WriteLine($"Nome posterior p3: {p3.Nome}");
            WriteLine($"Idade p1: {p1.Idade}");
            WriteLine($"Idade p3: {p3.Idade}");

            StructPessoa structP4 = new StructPessoa()
            {
                Nome = "Sheila",
                Idade = 20,
                Documento = "abcde1234"
            };

            StructPessoa structP5 = new StructPessoa();
            structP5 = structP4;
            // structP5.Nome = structP4.Nome;
            // structP5.Idade = structP4.Idade;
            // structP5.Documento = structP4.Documento;

            WriteLine($"Nome anterior structP4: {structP4.Nome}");
            WriteLine($"Nome anterior structP5: {structP5.Nome}");
            WriteLine($"Idade structP4: {structP4.Idade}");
            WriteLine($"Idade structP5: {structP5.Idade}");
            //structP4.Nome = "Sheila Cal";
            //structP4 = TrocarNomeStruct(structP4, "Sheila Cal");
            structP4.ChangeName("Sheila Cal");
            WriteLine($"Nome anterior structP4: {structP4.Nome}");
            WriteLine($"Nome anterior structP5: {structP5.Nome}");
            WriteLine($"Idade structP4: {structP4.Idade}");
            WriteLine($"Idade structP5: {structP5.Idade}");



        }
    }
}