using System.Data.Entity.ModelConfiguration;

namespace TreinaWeb.FluentAPI
{
    class HospedagemConfiguration : EntityTypeConfiguration<Hospedagem>
    {
        public HospedagemConfiguration()
        {
            ToTable("Hospedagem");
            Property(l => l.Nome).IsRequired().HasMaxLength(200);
            Property(l => l.Dono).IsRequired();
            Property(l => l.Dono).HasMaxLength(200);
            HasRequired(l => l.Destino).WithMany(d => d.Hospedagens).Map(map => map.MapKey("DestinoId")).WillCascadeOnDelete(false);
        }
    }
}
