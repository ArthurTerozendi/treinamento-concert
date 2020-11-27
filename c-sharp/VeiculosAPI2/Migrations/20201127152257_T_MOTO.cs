using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace VeiculosAPI2.Migrations
{
    public partial class T_MOTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_CARRO",
                table: "T_CARRO");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_T_CARRO_id",
                table: "T_CARRO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_CAMINHAO",
                table: "T_CAMINHAO");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_T_CAMINHAO_id",
                table: "T_CAMINHAO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Moto",
                table: "Moto");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Moto_id",
                table: "Moto");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "T_CARRO");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "T_CAMINHAO");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Moto");

            migrationBuilder.RenameTable(
                name: "Moto",
                newName: "T_MOTO");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "T_CARRO",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "T_CAMINHAO",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "T_MOTO",
                newName: "ID");

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "T_CARRO",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "T_CAMINHAO",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "T_MOTO",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_CARRO",
                table: "T_CARRO",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_CAMINHAO",
                table: "T_CAMINHAO",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_MOTO",
                table: "T_MOTO",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_CARRO",
                table: "T_CARRO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_CAMINHAO",
                table: "T_CAMINHAO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_MOTO",
                table: "T_MOTO");

            migrationBuilder.RenameTable(
                name: "T_MOTO",
                newName: "Moto");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "T_CARRO",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "T_CAMINHAO",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Moto",
                newName: "id");

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "T_CARRO",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<long>(
                name: "ID",
                table: "T_CARRO",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "T_CAMINHAO",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<long>(
                name: "ID",
                table: "T_CAMINHAO",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "Moto",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<long>(
                name: "ID",
                table: "Moto",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_CARRO",
                table: "T_CARRO",
                column: "ID");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_T_CARRO_id",
                table: "T_CARRO",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_CAMINHAO",
                table: "T_CAMINHAO",
                column: "ID");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_T_CAMINHAO_id",
                table: "T_CAMINHAO",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moto",
                table: "Moto",
                column: "ID");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Moto_id",
                table: "Moto",
                column: "id");
        }
    }
}
