using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    [Table("ItemPedido")]
    public class ItemPedido
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Produto")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Pedido")]
        [Display(Name = "Pedido")]
        public int PedidoId { get; set; }

        [ForeignKey("PedidoId")]
        public Pedido Pedido { get; set; }
    }
}