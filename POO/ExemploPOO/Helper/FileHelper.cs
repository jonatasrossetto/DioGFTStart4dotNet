using System.IO;
using System.Collections;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorio(string caminho)
        {
            System.Console.WriteLine($"Listando o conteúdo do diretório: {caminho}");
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
            foreach (var item in retornoCaminho)
            {
                System.Console.WriteLine(item);
            }
        }

        public void ListarArquivos(string caminho)
        {
            System.Console.WriteLine($"Listando os arquivos do diretório: {caminho}");
            var retornoCaminho = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories);
            foreach (var item in retornoCaminho)
            {
                System.Console.WriteLine(item);
            }
        }
        public void CriarDiretorio(string caminho)
        {
            var retornoCaminho = Directory.CreateDirectory(caminho);
        }

        public void CriarArquivoTexto(string caminho, string texto)
        {
            if (File.Exists(caminho))
            {
                File.WriteAllText(caminho, texto);
            }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> texto)
        {
            using var stream = File.CreateText(caminho);
            foreach (var item in texto)
            {
                stream.WriteLine(item);
            }

        }

        public void AdicionarTexto(string caminho, string texto)
        {
            File.AppendAllText(caminho, texto);
        }

        public void AdicionarTextoStream(string caminho, List<string> texto)
        {
            using var stream = File.AppendText(caminho);
            foreach (var item in texto)
            {
                stream.WriteLine(item);
            }

        }

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            foreach (var item in conteudo)
            {
                System.Console.WriteLine(item);
            }
        }

    }
}