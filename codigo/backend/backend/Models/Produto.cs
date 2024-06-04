using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar um nome!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar uma descrição!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar um valor!")]
        [Display(Name = "Preço")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar uma categoria!")]
        [Display(Name = "Categoria")]
        public Categorias Categoria { get; set; }

        private string _imagem;

        [Display(Name = "Imagem")]
        public string Imagem { get; set; }

        [NotMapped]
        public List<string> Imagens { get; set; } = new List<string>();

        public ICollection<ItemPedido> ItemPedidos { get; set; }
    }
    public enum Categorias
    {
        Lanches,
        Bebidas,
        Sobremesas,
        Outros
    }
}
