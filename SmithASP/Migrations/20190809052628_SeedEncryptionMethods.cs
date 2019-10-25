using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations
{
    public partial class SeedEncryptionMethods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Cryptography",
                table: "EncryptionMethods",
                columns: new[] { "EncryptionMethodId", "Description", "Name" },
                values: new object[] { 1, "Caesar ciphers use a list of symbols, such as the alphabet, and an encryption key. Each letter in the message is identified on the list of symbols and shifted a number times down the list based on the key.", "Caesar" });

            migrationBuilder.InsertData(
                schema: "Cryptography",
                table: "EncryptionMethods",
                columns: new[] { "EncryptionMethodId", "Description", "Name" },
                values: new object[] { 2, "This type of cipher involves changing the positions of the letters in the message.", "Transposition" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Cryptography",
                table: "EncryptionMethods",
                keyColumn: "EncryptionMethodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Cryptography",
                table: "EncryptionMethods",
                keyColumn: "EncryptionMethodId",
                keyValue: 2);
        }
    }
}
