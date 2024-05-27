using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

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

        public ICollection<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();
    }
}
