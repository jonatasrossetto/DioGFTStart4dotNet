namespace Construtores.Models
{
    public class calculadora
    {
        public delegate void DelegateCalculadora();
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                System.Console.WriteLine($"soma: {x + y}");
                EventoCalculadora();
            }
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"subtração: {x - y}");
        }
    }
}