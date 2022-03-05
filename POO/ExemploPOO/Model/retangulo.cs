namespace ExemploPOO.Model
{
    public class retangulo
    {
        private double comprimento;
        private double largura;

        private bool valido;
        public void definirMedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores invalidos na definição de objeto da classe retangulo");
                valido = false;
            }
        }

        public double calcularArea()
        {
            if (valido)
            {
                return this.comprimento * this.largura;
            }
            else
            {
                System.Console.WriteLine("calcularArea: Valores invalidos na definição de objeto da classe retangulo");
                return 0;
            }
        }
    }
}