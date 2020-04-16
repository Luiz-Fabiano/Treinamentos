using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TreinaWeb.Entity
{
    class BancoContext : DbContext
    {
        public DbSet<CategoriaProduto> Categorias { get; set; }
        public DbSet<SubCategoriaProduto> Subcategorias { get; set; }
        public BancoContext()
            : base(@"Data Source=NOTE-FABIANO\SQLDEVELOPER;Initial Catalog=AdventureWorks;Integrated Security=SSPI")
        {
            Database.SetInitializer<BancoContext>(null);
        }
    }
}
