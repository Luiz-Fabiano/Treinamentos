using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.FluentAPI
{
    class BancoCodeFirst : DbContext
    {
        public BancoCodeFirst()
            : base(@"Data Source=NOTE-FABIANO\SQLDEVELOPER;Initial Catalog=BancoCodeFirst;Integrated Security=SSPI")
            //: base("ConnectionSqlServerCompact")
        {
            Database.SetInitializer<BancoCodeFirst>(new DatabaseConfiguration());
        }

        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Hospedagem> Hospedagens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //// Configurando Destinos
            //modelBuilder.Entity<Destino>().ToTable("Destino");
            //modelBuilder.Entity<Destino>().Property(d => d.Nome).HasMaxLength(200).IsRequired();
            //modelBuilder.Entity<Destino>().Property(d => d.Descricao).HasMaxLength(500);
            //modelBuilder.Entity<Destino>().HasMany(d => d.Hospedagens).WithRequired().Map(m => m.MapKey("DestinoId")).WillCascadeOnDelete(true);

            //// Configurando Hospedagens
            //modelBuilder.Entity<Hospedagem>().ToTable("Hospedagem");
            //modelBuilder.Entity<Hospedagem>().Property(l => l.Nome).IsRequired().HasMaxLength(200);
            //modelBuilder.Entity<Hospedagem>().Property(l => l.Dono).IsRequired();
            //modelBuilder.Entity<Hospedagem>().Property(l => l.Dono).HasMaxLength(200);
            //modelBuilder.Entity<Hospedagem>().HasRequired(l => l.Destino).WithMany(d => d.Hospedagens).Map(map => map.MapKey("DestinoId")).WillCascadeOnDelete(false);

            modelBuilder.Configurations.Add(new DestinoConfiguration());
            modelBuilder.Configurations.Add(new HospedagemConfiguration());
        }
    }
}