using System.Data.Entity;

namespace TreinaWeb.EntityMySql
{
    public class EntitiesMySQLContext : DbContext
    {
        public EntitiesMySQLContext()
            : base(@"Server=localhost;Database=entity;Uid=root;Pwd=123456") { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
    }
}
