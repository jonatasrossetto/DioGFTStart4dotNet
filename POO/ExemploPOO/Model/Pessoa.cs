namespace ExemploPOO.Model
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Nome: {this.nome} ** idade: {this.idade}");

        }

    }
}