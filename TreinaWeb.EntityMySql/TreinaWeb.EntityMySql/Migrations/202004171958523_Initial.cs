namespace TreinaWeb.EntityMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autors",
                c => new
                    {
                        AutorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.AutorId);
            
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        LivroId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        ISBN = c.String(),
                    })
                .PrimaryKey(t => t.LivroId);
            
            CreateTable(
                "dbo.LivroAutors",
                c => new
                    {
                        Livro_LivroId = c.Int(nullable: false),
                        Autor_AutorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Livro_LivroId, t.Autor_AutorId })
                .ForeignKey("dbo.Livroes", t => t.Livro_LivroId, cascadeDelete: true)
                .ForeignKey("dbo.Autors", t => t.Autor_AutorId, cascadeDelete: true)
                .Index(t => t.Livro_LivroId)
                .Index(t => t.Autor_AutorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LivroAutors", "Autor_AutorId", "dbo.Autors");
            DropForeignKey("dbo.LivroAutors", "Livro_LivroId", "dbo.Livroes");
            DropIndex("dbo.LivroAutors", new[] { "Autor_AutorId" });
            DropIndex("dbo.LivroAutors", new[] { "Livro_LivroId" });
            DropTable("dbo.LivroAutors");
            DropTable("dbo.Livroes");
            DropTable("dbo.Autors");
        }
    }
}
