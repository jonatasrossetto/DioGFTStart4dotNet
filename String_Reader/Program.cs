using System;
using static System.Console;
using System.Text;

namespace String_Reader
{
    class Program
    {
        static void demo()
        {
            var sb = new StringBuilder();
            sb.AppendLine("primeira linha de exemplo para leitura");
            sb.AppendLine("segunda linha de exemplo para leitura");
            sb.AppendLine("terceira linha de exemplo para leitura");
            sb.AppendLine("f i m");

            using var sr = new StringReader(sb.ToString());
            var buffer = new char[10];
            // var pos = sr.Read(buffer);
            // WriteLine(String.Join(",", buffer));
            // Console.ReadLine();
            // foreach (char item in buffer)
            // {
            //     WriteLine(item);
            // }
            Console.ReadLine();


            // var tamanho = 0;
            // do
            // {
            //     // Array.Clear(buffer);
            //     buffer = new char[20];
            //     tamanho = sr.Read(buffer);
            //     WriteLine(String.Join("", buffer));

            // } while (tamanho >= buffer.Length);

            do
            {
                WriteLine(sr.ReadLine());
            } while (sr.Peek() >= 0);

        }

        static void Main()
        {
            string textReaderText = "TextReader é a classe base abstrata " +
              "de StreamReader e StringReader, que lê caracteres " +
              "de streams e strings, respectivamente.\n\n" +

              "Crie uma instância de TextReader para abrir um arquivo de texto " +
              "para ler um intervalo especificado de caracteres " +
              "ou para criar um leitor baseado em um fluxo existente.\n\n" +

              "Você também pode usar uma instância de TextReader para ler " +
              "texto de um armazenamento de suporte personalizado usando as mesmas " +
              "APIs que você usaria para uma string ou um fluxo.\n\n";

            string linha, paragrafo = null;
            var sr = new StringReader(textReaderText);

            while (true)
            {
                linha = sr.ReadLine();
                if (linha != null)
                {
                    paragrafo = paragrafo + linha + " ";
                }
                else
                {
                    paragrafo = paragrafo + '\n';
                    break;
                }
            }

            Clear();
            WriteLine($"texto original: \n {textReaderText } \n\n ---------- \n\n");
            WriteLine($"texto convertido: {paragrafo} \n\n");
            WriteLine("digite enter ...");
            ReadLine();

            int caracterlido;
            char caracterconvertido;

            var sw = new StringWriter();
            sr = new StringReader(paragrafo);

            while (true)
            {

                caracterlido = sr.Read();
                // WriteLine(caracterlido);
                if (caracterlido == -1) break;
                caracterconvertido = Convert.ToChar(caracterlido);
                if (caracterlido == '.')
                {
                    sw.Write("****\n\n");
                    sr.Read();
                    sr.Read();
                }
                else
                {
                    sw.Write(caracterconvertido);
                }
     
            };

            WriteLine($"\n\n texto armazenado no stringwriter: \n\n {sw.ToString()}");




        }
    }
}
