namespace TreinaWeb.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.Funcionario", newName: "Funcionarios");
        }
        
        public override void Down()
        {
            //RenameTable(name: "dbo.Funcionarios", newName: "Funcionario");
        }
    }
}
