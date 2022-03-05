using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Model;
using static System.Console;

class Program
{
    static void Main()
    {
        Clear();
        Pessoa p1 = new Pessoa();
        p1.nome = "Joe";
        p1.idade = 20;
        p1.Apresentar();
        WriteLine("************** \n\n");

        retangulo r = new retangulo();
        r.definirMedidas(5, 5);
        WriteLine($"A área do retangulo é: {r.calcularArea()}");

        r.definirMedidas(-5, 5);
        WriteLine($"A área do retangulo é: {r.calcularArea()}");
        WriteLine("************** \n\n");

        Aluno aluno = new Aluno();
        aluno.nome = "bob";
        aluno.idade = 21;
        aluno.nota = 8;
        aluno.Apresentar();

        professor prof = new professor();
        prof.nome = "junior";
        prof.idade = 30;
        prof.salario = 2000;
        prof.Apresentar();
        WriteLine("************** \n\n");

        Calculadora calc = new Calculadora();
        WriteLine(calc.Somar(1, 2));
        WriteLine(calc.Somar(1, 2, 10));
        WriteLine("************** \n\n");

        Corrente c = new Corrente();
        c.Creditar(100);
        c.ExibirSaldo();
        WriteLine("************** \n\n");

        Computador comp = new Computador();
        WriteLine(comp.ToString());
        WriteLine("************** \n\n");

        ICalculadora calc1 = new Calculadora();
        WriteLine(calc1.Subtrair(10, 11));



    }
}
