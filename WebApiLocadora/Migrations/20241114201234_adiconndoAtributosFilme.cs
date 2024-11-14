using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiLocadora.Migrations
{
    /// <inheritdoc />
    public partial class adiconndoAtributosFilme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locacoes_Filmes_FilmeId",
                table: "Locacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filmes",
                table: "Filmes");

            migrationBuilder.RenameTable(
                name: "Filmes",
                newName: "filmes");

            migrationBuilder.AddColumn<bool>(
                name: "Disponivel",
                table: "filmes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "filmes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_filmes",
                table: "filmes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locacoes_filmes_FilmeId",
                table: "Locacoes",
                column: "FilmeId",
                principalTable: "filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locacoes_filmes_FilmeId",
                table: "Locacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_filmes",
                table: "filmes");

            migrationBuilder.DropColumn(
                name: "Disponivel",
                table: "filmes");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "filmes");

            migrationBuilder.RenameTable(
                name: "filmes",
                newName: "Filmes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filmes",
                table: "Filmes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locacoes_Filmes_FilmeId",
                table: "Locacoes",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
