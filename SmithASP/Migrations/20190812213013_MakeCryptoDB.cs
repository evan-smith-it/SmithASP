using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations
{
    public partial class MakeCryptoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Cryptography",
                table: "EncryptionMethods",
                type: "varchar(550)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(350)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Cryptography",
                table: "EncryptionMethods",
                type: "varchar(350)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(550)",
                oldNullable: true);
        }
    }
}
