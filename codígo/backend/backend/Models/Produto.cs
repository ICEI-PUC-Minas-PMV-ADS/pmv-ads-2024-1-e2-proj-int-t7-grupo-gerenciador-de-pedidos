using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar um nome!")]
        public string nome { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar uma descrição!")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar um valor!")]
        public double valor { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar uma quantidade!")]
        public int quantidade { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar uma categoria!")]
        public string categoria { get; set; }

    }
}
