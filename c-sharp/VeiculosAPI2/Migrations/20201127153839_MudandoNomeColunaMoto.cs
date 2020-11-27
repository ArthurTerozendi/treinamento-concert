using Microsoft.EntityFrameworkCore.Migrations;

namespace VeiculosAPI2.Migrations
{
    public partial class MudandoNomeColunaMoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NUMERO_QUEDAS",
                table: "T_MOTO",
                newName: "NUMEROQUEDAS");

            migrationBuilder.RenameColumn(
                name: "CAPOTES_DO_GUSTAVAO",
                table: "T_MOTO",
                newName: "CAPOTESDOGUSTAVAO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NUMEROQUEDAS",
                table: "T_MOTO",
                newName: "NUMERO_QUEDAS");

            migrationBuilder.RenameColumn(
                name: "CAPOTESDOGUSTAVAO",
                table: "T_MOTO",
                newName: "CAPOTES_DO_GUSTAVAO");
        }
    }
}
