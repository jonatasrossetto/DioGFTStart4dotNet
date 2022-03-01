using System;
using static System.Console;

namespace teste_ref_struct
{
    class Program
    {
        static void Main()
        {
            Clear();
            WriteLine("teste");
            Pessoa p1 = new Pessoa();
            p1.nome = "jonatas";
            p1.idade = 30;
            p1.documento = "abc1234";
            p1.enderecoPessoa = new Endereco()
            {
                rua = "rua teste",
                numero = "100",
                cidade = "salvador",
                cep = "sdssdadsa",
            };
            WriteLine(p1);
            WriteLine(p1.nome);
            WriteLine(p1.enderecoPessoa);
            WriteLine(p1.enderecoPessoa.rua);
        }


    }
}
