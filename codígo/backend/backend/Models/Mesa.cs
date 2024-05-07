using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    [Table("Mesas")]
    public class Mesa
    {
        [Key]
        public int Id { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

    }
}