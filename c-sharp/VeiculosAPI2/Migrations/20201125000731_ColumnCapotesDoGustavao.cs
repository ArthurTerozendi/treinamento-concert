using Microsoft.EntityFrameworkCore.Migrations;

namespace VeiculosAPI2.Migrations
{
    public partial class ColumnCapotesDoGustavao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CapotesDoGustavao",
                table: "Moto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numeroQuedas",
                table: "Moto",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CapotesDoGustavao",
                table: "Moto");

            migrationBuilder.DropColumn(
                name: "numeroQuedas",
                table: "Moto");
        }
    }
}
