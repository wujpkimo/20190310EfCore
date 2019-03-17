using Microsoft.EntityFrameworkCore.Migrations;

namespace EfcoreConsoleApp.Migrations
{
    public partial class OneToManyRelationPokemonWeakness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonWeaknesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PokemonId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonWeaknesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonWeaknesses_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonWeaknesses_PokemonId",
                table: "PokemonWeaknesses",
                column: "PokemonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonWeaknesses");
        }
    }
}
