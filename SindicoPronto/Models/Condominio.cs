using System.ComponentModel.DataAnnotations;

namespace SindicoPronto.Models
{
    public class Condominio
    {
        [Key]
        public int Id { get; private set; }
        public string CnpjCondominio { get; private set; }
        public string Nome { get; set; }
        public int QtdApartamento { get; private set; }
    }
}
