namespace backend.Models
{
    public class ProdutoViewModel
    {
        public Produto Produto { get; set; }
        public IEnumerable<string> Imagens { get; set; }
    }
}
