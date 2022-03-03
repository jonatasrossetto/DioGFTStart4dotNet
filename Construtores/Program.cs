using System;
using static System.Console;
using Construtores.Models;

class program
{
    public delegate void Operacao(int x, int y);
    static void Main()
    {

        Clear();
        WriteLine("exemplo construtores, propriedade, delegates e eventos");
        Pessoas p1 = new Pessoas("Jonatas", "Rossetto");
        p1.Apresentar();
        WriteLine("---------- \n\n\n");

        Log log1 = Log.GetInstance();
        log1.propriedadeLog = "teste instância 1";
        WriteLine(log1.propriedadeLog);
        Log log2 = Log.GetInstance();
        log2.propriedadeLog = "teste instância 2";
        WriteLine("log1: " + log1.propriedadeLog);
        WriteLine("log2: " + log2.propriedadeLog);
        WriteLine("---------- \n\n\n");

        Aluno aluno = new Aluno("Jonatas", "Rossetto", "Resistência dos Materiais 1");
        aluno.Apresentar();

        Mes mes = new Mes();
        mes.Set(14);
        mes.Apresenta();
        mes.Set(10);
        mes.Apresenta();

        WriteLine($"---------- \n\n\n");

        Operacao op = new Operacao(calculadora.Somar);
        op += calculadora.Subtrair;
        op.Invoke(10, 1);
        op(5, 7);

        WriteLine("---------- \n\n\n");


    }
}


