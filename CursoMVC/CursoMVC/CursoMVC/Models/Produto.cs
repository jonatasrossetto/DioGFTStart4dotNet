namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
