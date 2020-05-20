using Microsoft.EntityFrameworkCore.Migrations;

namespace TreinaWeb.ASPNetCore.Migrations
{
    public partial class AlteracaoTabelaPessoas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "PES_PESSOAS");

            migrationBuilder.RenameColumn(
                name: "Observacoes",
                table: "PES_PESSOAS",
                newName: "PES_OBSERVACOES");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "PES_PESSOAS",
                newName: "PES_NOME");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "PES_PESSOAS",
                newName: "PES_IDADE");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PES_PESSOAS",
                newName: "PES_ID");

            migrationBuilder.AlterColumn<string>(
                name: "PES_OBSERVACOES",
                table: "PES_PESSOAS",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PES_NOME",
                table: "PES_PESSOAS",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PES_PESSOAS",
                table: "PES_PESSOAS",
                column: "PES_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PES_PESSOAS",
                table: "PES_PESSOAS");

            migrationBuilder.RenameTable(
                name: "PES_PESSOAS",
                newName: "Pessoas");

            migrationBuilder.RenameColumn(
                name: "PES_OBSERVACOES",
                table: "Pessoas",
                newName: "Observacoes");

            migrationBuilder.RenameColumn(
                name: "PES_NOME",
                table: "Pessoas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "PES_IDADE",
                table: "Pessoas",
                newName: "Idade");

            migrationBuilder.RenameColumn(
                name: "PES_ID",
                table: "Pessoas",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Observacoes",
                table: "Pessoas",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoas",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "ID");
        }
    }
}
