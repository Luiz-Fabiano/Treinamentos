namespace TreinaWeb.WebApi.AcessoDados.EF.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TreinaWeb.WebApi.AcessoDados.EF.Context.WebApiDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TreinaWeb.WebApi.AcessoDados.EF.Context.WebApiDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
