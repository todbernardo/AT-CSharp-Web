using System.ComponentModel.DataAnnotations;

namespace AT.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Reserva> Reservas { get; set; } = new();
    }
}
