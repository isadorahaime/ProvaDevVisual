using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Veiculo
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Cor { get; set; }
    }
}
