namespace Construtores.Models
{
    public class Mes
    {
        private int mes;
        private Boolean mesValido = false;



        public int Get()
        {
            return this.mes;
        }

        public void Set(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }
        public void Apresenta()
        {
            if (mesValido)
            {
                System.Console.WriteLine("mês: " + mes);
            }
            else
            {
                System.Console.WriteLine("mês inválido");
            }
        }
    }
}