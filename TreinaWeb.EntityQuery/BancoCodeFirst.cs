using System.Data.Entity;

namespace TreinaWeb.EntityQuery
{
    class BancoCodeFirst : DbContext
    {
        public BancoCodeFirst() : base(@"Data Source=NOTE-FABIANO\SQLDEVELOPER;Initial Catalog=BancoCodeFirst;Integrated Security=SSPI")
        {
            //Database.SetInitializer<BancoCodeFirst>(new ConfigDatabase());
            Database.SetInitializer<BancoCodeFirst>(new CreateDatabaseIfNotExists<BancoCodeFirst>());
        }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
    }
}
