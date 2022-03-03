namespace Construtores.Models
{
    public class Aluno : Pessoas
    {
        public string disciplina;
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            this.disciplina = disciplina;
            System.Console.WriteLine("Construtor classe aluno");
        }
    }
}