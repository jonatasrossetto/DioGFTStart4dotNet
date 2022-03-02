using System;
//using System.Math;
using static System.Console;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

// static void LerCsvDynamic()
// {
//     var pathnovo = Path.Combine(Environment.CurrentDirectory, "dados.csv");
//     var config = new CsvConfiguration(CultureInfo.InvariantCulture);
//     //config.HasHeaderRecord = false;
//     config.Delimiter = ";";

//     using var reader = new StreamReader(pathnovo);
//     using var csv = new CsvReader(reader, config);
//     var registros = csv.GetRecords<dynamic>();
//     foreach (var reg in registros)
//     {
//         WriteLine(reg.tempo);
//         WriteLine(reg.funcao);
//     }
// }

class program
{
    static void Main()
    {
        // var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios_exportacao.csv");
        // using var sr = new StreamReader(path);
        // var cabecalho = sr.ReadLine()?.Split(',');

        // // foreach (string item in cabecalho) WriteLine(item);

        // while (true)
        // {
        //     var registro = sr.ReadLine()?.Split(',');
        //     if (registro == null) break;
        //     for (int i = 0; i < registro.Length; i++)
        //     {
        //         WriteLine($"{cabecalho[i]}: {registro[i]}");
        //     }
        //     WriteLine("-------------------");
        // }


        WriteLine("console");

        // var pathnovo = Path.Combine(Environment.CurrentDirectory, "dados.csv");
        // using var sw = new StreamWriter(pathnovo);
        // sw.WriteLine("tempo;funcao");
        // Double tempo, funcao;
        // for (Double i = 0; i <= 1000; i++)
        // {
        //     tempo = i / 1000;
        //     funcao = Math.Sin(2 * Math.PI * 10 * tempo);
        //     sw.WriteLine($"{tempo};{funcao}");
        // }
        var pathnovo = Path.Combine(Environment.CurrentDirectory, "dados.csv");
        var config = new CsvConfiguration(CultureInfo.InvariantCulture);
        //config.HasHeaderRecord = false;
        config.Delimiter = ";";

        using var reader = new StreamReader(pathnovo);
        using var csv = new CsvReader(reader, config);
        var registros = csv.GetRecords<Dados>();
        foreach (var reg in registros)
        {
            WriteLine(reg.tempo);
            WriteLine(reg.funcao);
        }

        WriteLine("digite enter para finalizar");
        ReadLine();
        //Fim do Main
    }

    public class Dados
    {
        public Double tempo { get; set; }
        public Double funcao { get; set; }

    }

    // Fim do namespace
}
