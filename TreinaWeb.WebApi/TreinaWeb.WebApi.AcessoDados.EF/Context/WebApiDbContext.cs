using System.Data.Entity;
using TreinaWeb.WebApi.Dominio;

namespace TreinaWeb.WebApi.AcessoDados.EF.Context
{
    public class WebApiDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public WebApiDbContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
