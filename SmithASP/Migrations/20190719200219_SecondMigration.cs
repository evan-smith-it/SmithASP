using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "Cryptograms");

            migrationBuilder.AlterColumn<string>(
                name: "result",
                table: "Cryptograms",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "message",
                table: "Cryptograms",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "key",
                table: "Cryptograms",
                nullable: false,
                oldClrType: typeof(string),
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

            migrationBuilder.CreateTable(
                name: "EncryptionMethods",
                columns: table => new
                {
                    EncryptionMethodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncryptionMethods", x => x.EncryptionMethodId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CryptogramEncryptionMethods");

            migrationBuilder.DropTable(
                name: "EncryptionMethods");

            migrationBuilder.AlterColumn<string>(
                name: "result",
                table: "Cryptograms",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "message",
                table: "Cryptograms",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "key",
                table: "Cryptograms",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Cryptograms",
                nullable: true);
        }
    }
}
