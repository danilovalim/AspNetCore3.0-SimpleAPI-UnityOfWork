namespace RepoApp.Models
{
    public class Product : Base
    {
        public string Nome { get; set; }

        public int CategoriaId { get; set; }

        public Category Categoria { get; set; }
    }
}
