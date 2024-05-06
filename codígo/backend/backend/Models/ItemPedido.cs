using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class ItemPedido
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Status")]
        [Display(Name = "Status")]
        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public StatusPedido Status { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Mesa")]
        [Display(Name = "Mesa")]
        public int MesaId { get; set; }

        [ForeignKey("MesaId")]
        public Mesa Mesa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Produto")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
    }
}
