namespace Construtores.Models
{
    public class Pessoas
    {

        private string nome;
        private string sobrenome;

        // public Pessoas()
        // {
        //     this.nome = string.Empty;
        //     this.sobrenome = string.Empty;
        // }

        public Pessoas(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe Pessoas");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }

    }
}