using System.Data.Entity.ModelConfiguration;

namespace TreinaWeb.FluentAPI
{
    class DestinoConfiguration : EntityTypeConfiguration<Destino>
    {
        public DestinoConfiguration()
        {
            ToTable("Destino");
            Property(d => d.Nome).HasMaxLength(200).IsRequired();
            Property(d => d.Descricao).HasMaxLength(500);
            HasMany(d => d.Hospedagens).WithRequired().Map(m => m.MapKey("DestinoId")).WillCascadeOnDelete(true);
        }
    }
}
