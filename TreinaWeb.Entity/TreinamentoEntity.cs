using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Entity
{
    class TreinamentoEntity : DbContext
    { 
        public TreinamentoEntity() : base(@"Data Source=NOTE-FABIANO\SQLDEVELOPER;Initial Catalog=TreinamentoEntity;Integrated Security=SSPI") 
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TreinamentoEntity>());
        }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
    }
}
