namespace AT.Models
{
    public class PacoteTuristico
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public int CapacidadeMaxima { get; set; }
        public decimal Preco { get; set; }
        public List<PacoteTuristicoDestino> PacoteTuristicoDestinos { get; set; } = new();
        public List<Reserva> Reservas { get; set; }

        public event Action<string> CapacityReached;

        public void Reservar(Reserva reserva)
        {
            if(Reservas.Count >= CapacidadeMaxima)
            {
                CapacityReached?.Invoke("Capicadade maxima atingida.");
            }
        }
    }
}
