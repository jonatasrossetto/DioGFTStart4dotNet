using System;
using System.IO;
using static System.Console;

namespace Demo_System_Io
{
    class Program
    {
        static void CriarArquivo(string path)
        {
            try
            {
                using (var sw = File.CreateText(path))
                {
                    sw.WriteLine("Linha 1");
                    sw.WriteLine("Linha 2");
                    sw.WriteLine("Linha 3");
                }
            }
            catch (System.Exception)
            {
                WriteLine("O nome do arquivo está errado");
            }
        }

        static string LimparNome(string texto)
        {
            foreach (var caracter in Path.GetInvalidFileNameChars())
            {
                texto = texto.Replace(caracter, '-');
            }
            return texto;
        }
        static void Main()
        {
            // WriteLine("digite o nome do arquivo: ");
            // var nomeArquivo = ReadLine();
            // nomeArquivo = LimparNome(nomeArquivo);
            //var path = Path.Combine(Environment.CurrentDirectory, $"{nomeArquivo}.txt");
            var path = Environment.CurrentDirectory;
            // CriarArquivo(path);
            Console.Clear();
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);
            DirectoryInfo di1 = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "teste_dir"));

            WriteLine(di.Root);
            WriteLine(di.Parent);
            WriteLine(di.FullName);
            WriteLine("------------");
            foreach (FileInfo fi in di.GetFiles())
            {
                WriteLine(fi.Name);
                WriteLine(fi.Length);
                WriteLine(fi.LastAccessTime);
                WriteLine("------------");

            }

            using var fsw = new FileSystemWatcher(path);
            fsw.Created += OnCreated;
            fsw.Deleted += OnDeleted;

            fsw.EnableRaisingEvents = true;
            fsw.IncludeSubdirectories = true;



            di.CreateSubdirectory("teste_dir");
            WriteLine("digite enter para continuar");
            ReadLine();
            di1.Delete();
            WriteLine("digite enter para finalizar");
            ReadLine();



        }

        static void OnCreated(object sender, FileSystemEventArgs e)
        {
            WriteLine($"alguma coisa foi criada!!! {e.Name}");
        }

        static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            WriteLine($"alguma coisa foi apagada!!! {e.Name}");
        }

    }
}
