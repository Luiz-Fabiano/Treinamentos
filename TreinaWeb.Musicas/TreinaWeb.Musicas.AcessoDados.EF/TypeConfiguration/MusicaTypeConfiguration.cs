using TreinaWeb.Comum.EF;
using TreinaWeb.Musicas.Dominio;

namespace TreinaWeb.Musicas.AcessoDados.EF.TypeConfiguration
{
    class MusicaTypeConfiguration : TreinaWebEFAbstractConfig<Musica>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.ID)
                .HasColumnName("MUS_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(p => p.Nome)
                .HasColumnName("MUS_NOME")
                .HasMaxLength(50)
                .IsRequired();
            Property(p => p.IDAlbum)
                .HasColumnName("ALB_ID")
                .IsRequired();
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.ID);
        }

        protected override void ConfigurarChavesEstrangeiras()
        {
            //HasRequired(p => p.Album)
            //    .WithMany(p => p.Musicas)
            //    .HasForeignKey(fk => fk.IDAlbum);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("MUS_MUSICAS");
        }
    }
}
