namespace TreinaWeb.WebApi.AcessoDados.EF.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CriacaoTabelaAlunos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    Endereco = c.String(),
                    Mensalidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.ID);

        }

        public override void Down()
        {
            DropTable("dbo.Alunoes");
        }
    }
}
