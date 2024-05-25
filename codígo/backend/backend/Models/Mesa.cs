using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    [Table("Mesas")]
    public class Mesa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o número da mesa")]
        [Display(Name = "Número da Mesa")]
        public int NumeroMesa { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

    }
}