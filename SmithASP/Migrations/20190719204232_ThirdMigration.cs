using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CryptogramEncryptionMethods");

            migrationBuilder.EnsureSchema(
                name: "Cryptography");

            migrationBuilder.RenameTable(
                name: "EncryptionMethods",
                newName: "EncryptionMethods",
                newSchema: "Cryptography");

            migrationBuilder.RenameTable(
                name: "Cryptograms",
                newName: "Cryptograms",
                newSchema: "Cryptography");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Cryptography",
                table: "EncryptionMethods",
                type: "varchar(350)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CryptogramEncryptionMethod",
                schema: "Cryptography",
                columns: table => new
                {
                    CryptogramId = table.Column<int>(nullable: false),
                    EncryptionMethodId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CryptogramEncryptionMethod", x => new { x.CryptogramId, x.EncryptionMethodId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CryptogramEncryptionMethod",
                schema: "Cryptography");

            migrationBuilder.RenameTable(
                name: "EncryptionMethods",
                schema: "Cryptography",
                newName: "EncryptionMethods");

            migrationBuilder.RenameTable(
                name: "Cryptograms",
                schema: "Cryptography",
                newName: "Cryptograms");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "EncryptionMethods",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(350)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CryptogramEncryptionMethods",
                columns: table => new
                {
                    CryptogramId = table.Column<int>(nullable: false),
                    EncryptionMethodId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CryptogramEncryptionMethods", x => new { x.CryptogramId, x.EncryptionMethodId });
                });
        }
    }
}
