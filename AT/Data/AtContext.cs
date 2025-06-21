using AT.Models;
using Microsoft.EntityFrameworkCore;

namespace AT.Data
{
    public class AtContext : DbContext
    {
        public AtContext(DbContextOptions<AtContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<PacoteTuristico> PacotesTuristicos { get; set; } // Corrigido
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<PacoteTuristicoDestino> PacoteTuristicoDestinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PacoteTuristicoDestino>()
                .HasKey(ptd => new { ptd.PacoteTuristicoId, ptd.DestinoId });

            modelBuilder.Entity<PacoteTuristicoDestino>()
                .HasOne(ptd => ptd.PacoteTuristico)
                .WithMany(pt => pt.PacoteTuristicoDestinos)
                .HasForeignKey(ptd => ptd.PacoteTuristicoId);

            modelBuilder.Entity<PacoteTuristicoDestino>()
                .HasOne(ptd => ptd.Destino)
                .WithMany(d => d.PacoteTuristicoDestinos)
                .HasForeignKey(ptd => ptd.DestinoId);
        }
    }
}
