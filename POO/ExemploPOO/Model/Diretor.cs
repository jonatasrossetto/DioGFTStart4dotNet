namespace ExemploPOO.Model
{
    public class Diretor : professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Diretor: {this.nome} ** idade: {this.idade} ** salário: {this.salario}");

        }
    }
}