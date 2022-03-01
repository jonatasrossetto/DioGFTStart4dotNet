namespace MyApp
{
    public class vetor
    {
        public double x, y;

        public void Set (double a, double b)
        {
            this.x = a;
            this.y = b;
        }
        public double Comprimento ()
        {
            return Math.Pow((Math.Pow(this.x,2)+Math.Pow(this.y,2) ),0.5);
        }


    }
}