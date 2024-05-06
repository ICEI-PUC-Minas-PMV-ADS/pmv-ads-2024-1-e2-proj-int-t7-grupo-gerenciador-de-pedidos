using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class StatusPedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public ICollection<StatusPedido> StatusPedidos { get; set; }
    }
}
