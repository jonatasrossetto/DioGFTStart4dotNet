namespace tratamentoErros
{
    public class MyClassExceptions : Exception
    {
        public MyClassExceptions()
        {
        }

        public MyClassExceptions(string? message) : base(message)
        {
        }

        public string? MyProperty { get; set; }



    }
}