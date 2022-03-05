namespace ExemploPOO.Model
{
    public class Aluno : Pessoa
    {
        public int nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Aluno: {this.nome} ** idade: {this.idade} ** nota: {this.nota}");
        }
    }



}