using System.ComponentModel.DataAnnotations;

namespace SindicoPronto.Models
{
    public class Sindico
    {
        [Key]
        public int Id { get; private set; }
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(60,ErrorMessage ="O campo {0} precisa estar entre {2} e {1} caracterers.",MinimumLength =5)]
        public string Nome { get; set; }
        public int QtdCondominios { get; set; }

       

    }
}
