using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace VeiculosAPI2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moto",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    UPDATED_AT = table.Column<DateTime>(nullable: false),
                    id = table.Column<long>(nullable: false),
                    COR = table.Column<string>(nullable: true),
                    MARCA = table.Column<string>(nullable: true),
                    MODELO = table.Column<string>(nullable: true),
                    placa = table.Column<string>(nullable: true),
                    NUMERO_QUEDAS = table.Column<int>(nullable: false),
                    CAPOTES_DO_GUSTAVAO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moto", x => x.ID);
                    table.UniqueConstraint("AK_Moto_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_CAMINHAO",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    UPDATED_AT = table.Column<DateTime>(nullable: false),
                    id = table.Column<long>(nullable: false),
                    COR = table.Column<string>(nullable: true),
                    MARCA = table.Column<string>(nullable: true),
                    MODELO = table.Column<string>(nullable: true),
                    placa = table.Column<string>(nullable: true),
                    NUMERO_EIXOS = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CAMINHAO", x => x.ID);
                    table.UniqueConstraint("AK_T_CAMINHAO_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_CARRO",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    UPDATED_AT = table.Column<DateTime>(nullable: false),
                    id = table.Column<long>(nullable: false),
                    COR = table.Column<string>(nullable: true),
                    MARCA = table.Column<string>(nullable: true),
                    MODELO = table.Column<string>(nullable: true),
                    placa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CARRO", x => x.ID);
                    table.UniqueConstraint("AK_T_CARRO_id", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moto");

            migrationBuilder.DropTable(
                name: "T_CAMINHAO");

            migrationBuilder.DropTable(
                name: "T_CARRO");
        }
    }
}
