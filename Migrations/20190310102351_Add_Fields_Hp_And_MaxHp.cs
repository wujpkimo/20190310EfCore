using Microsoft.EntityFrameworkCore.Migrations;

namespace EfcoreConsoleApp.Migrations
{
    public partial class Add_Fields_Hp_And_MaxHp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Hp",
                table: "Pokemons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxHp",
                table: "Pokemons",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hp",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "MaxHp",
                table: "Pokemons");
        }
    }
}
