using Microsoft.EntityFrameworkCore;
using TreinaWeb.ASPNetCore.Models;

namespace TreinaWeb.ASPNetCore.Context
{
    public class TreinaWebASPNetCoreDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public TreinaWebASPNetCoreDbContext(DbContextOptions<TreinaWebASPNetCoreDbContext> options)
            : base(options)
        {
            
        }

        protected  override void OnModelCreating(ModelBuilder modelBuider)
        {
            modelBuider.Entity<Pessoa>((buider) => 
            {
                buider.ToTable("PES_PESSOAS");
                buider.Property(p => p.ID).HasColumnName("PES_ID");
                buider.HasKey(p => p.ID);
                buider.Property(p => p.Nome).HasColumnName("PES_NOME").HasMaxLength(50).IsRequired();
                buider.Property(p => p.Idade).HasColumnName("PES_IDADE").IsRequired();
                buider.Property(p => p.Observacoes).HasColumnName("PES_OBSERVACOES").HasMaxLength(200).IsRequired(false);
            });
        }
    }
}