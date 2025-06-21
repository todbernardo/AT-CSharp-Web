using System.ComponentModel.DataAnnotations;

namespace AT.Models
{
    public class Destino
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string Pais { get; set; }
        public List<PacoteTuristicoDestino> PacoteTuristicoDestinos { get; set; } = new();
        public bool IsDeleted { get; set; } = false;

    }
}
