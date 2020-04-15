using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.Comum.EF;
using TreinaWeb.Musicas.Dominio;

namespace TreinaWeb.Musicas.AcessoDados.EF.TypeConfiguration
{
    class AlbumTypeConfiguration : TreinaWebEFAbstractConfig<Album>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.ID)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("ALB_ID");
            
            Property(p => p.Nome)
                 .IsRequired()
                 .HasColumnName("ALB_NOME")
                 .HasMaxLength(100);

            Property(p => p.Ano)
                 .IsRequired()
                 .HasColumnName("ALB_ANO");

            Property(p => p.Observacoes)
                 .IsRequired()
                 .HasColumnName("ALB_OBSERVACOES")
                 .HasMaxLength(1000);

            Property(p => p.Email)
                 .IsRequired()
                 .HasColumnName("ALB_EMAIL")
                 .HasMaxLength(50);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.ID);
        }

        protected override void ConfigurarChavesEstrangeiras()
        {
            HasMany(p => p.Musicas)
                .WithRequired(p => p.Album)
                .HasForeignKey(fk => fk.IDAlbum);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("ALB_ALBUNS");
        }
    }
}
