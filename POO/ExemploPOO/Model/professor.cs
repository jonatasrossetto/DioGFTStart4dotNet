namespace ExemploPOO.Model
{
    public class professor : Pessoa
    {
        public int salario { get; set; }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Professor: {this.nome} ** idade: {this.idade} ** salário: {this.salario}");

        }
    }
}