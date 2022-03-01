using System;
using static System.Console;

class program
{
    static void Main()
    {
        var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios_exportacao.csv");
        using var sr = new StreamReader(path);
        var cabecalho = sr.ReadLine()?.Split(',');

        // foreach (string item in cabecalho) WriteLine(item);

        while (true)
        {
            var registro = sr.ReadLine()?.Split(',');
            if (registro == null) break;
            for (int i = 0; i < registro.Length; i++)
            {
                WriteLine($"{cabecalho[i]}: {registro[i]}");
            }
            WriteLine("-------------------");
        }


        WriteLine("console");
    }

}
