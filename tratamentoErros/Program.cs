using System;
using tratamentoErros;
using static System.Console;

class Program
{
    static void Main()
    {
        //System.Console.Clear(); ;
        WriteLine("Tratamento de erros");
        int na = 100;
        int nb = 0;
        double resultado = 0;
        try
        {
            resultado = Dividir(na, nb);
            WriteLine($"{na} dividido por {nb} é igual a: {resultado}");
        }
        catch (DivideByZeroException ex)
        {
            WriteLine("executando o primeiro catch");
            WriteLine($"na:{na} nb:{nb}");
            WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            WriteLine("executando o segundo catch");
            WriteLine($"na:{na} nb:{nb}");
            WriteLine(ex.Message);
            throw;
        }
        finally
        {
            WriteLine("ufa, finalizamos a divisão!");
        }


        static double Dividir(int n1, int n2)
        {
            if (n2 == 0)
            {
                WriteLine("executando o throw");
                //throw new DivideByZeroException();
                //throw new ArithmeticException();
                throw new MyClassExceptions("Minha mensagem customizada de erro");
            }
            return (n1 / n2);
        }

    }
}