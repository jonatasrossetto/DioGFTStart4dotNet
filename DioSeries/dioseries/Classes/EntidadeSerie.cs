using dioseries.Enum;

namespace dioseries.Classes
{
    public class Serie : entidadeBase
    {
        private Genero Genero { get; set; }
        private String Titulo { get; set; }
        private String Descricao { get; set; }
        public int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.Ano = ano;
            this.Descricao = descricao;
            this.Titulo = titulo;
            this.Genero = genero;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero:" + this.Genero + Environment.NewLine;
            retorno += "Título:" + this.Titulo + Environment.NewLine;
            retorno += "Descrição:" + this.Descricao + Environment.NewLine;
            retorno += "Ano:" + this.Ano + Environment.NewLine;
            retorno += "Excluído:" + this.Excluido;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}