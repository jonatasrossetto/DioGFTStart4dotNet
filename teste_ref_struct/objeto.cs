namespace teste_ref_struct
{
    public class Pessoa
    {
        public String nome { get; set; }
        public int idade { get; set; }

        public String documento { get; set; }

        public Endereco enderecoPessoa;

    }

    public struct Endereco
    {
        public string rua;
        public string numero;
        public string cep;
        public string cidade;
    }
}