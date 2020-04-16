namespace TreinaWeb.Entity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TreinaWeb.Entity.TreinamentoEntity>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TreinaWeb.Entity.TreinamentoEntity";
        }

        protected override void Seed(TreinaWeb.Entity.TreinamentoEntity context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
