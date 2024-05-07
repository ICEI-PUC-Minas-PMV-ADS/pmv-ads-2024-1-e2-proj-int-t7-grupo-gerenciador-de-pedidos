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
        public string Categoria { get; set; }

        
        [Display(Name = "Imagem")]
        public  string Imagem { get; set; }

        public ICollection<ItemPedido> ItemPedidos { get; set; }
    }
}
