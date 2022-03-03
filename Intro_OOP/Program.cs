using System;
using Intro_OOP.Entities;
using static System.Console;

class Program
{
    static void Main()
    {
        Clear();
        Knight arus = new Knight("Arus", 2, "knight");
        Wizard wizard = new Wizard("Jenica", 5, "wizard");
        WriteLine(arus.ToString());
        WriteLine(wizard.Attack());
        WriteLine(wizard.ToString());
        WriteLine(wizard.Attack(11));
        WriteLine(wizard.Attack(2));
    }
}

