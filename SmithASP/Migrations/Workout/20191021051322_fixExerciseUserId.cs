using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations.Workout
{
    public partial class fixExerciseUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Exercises",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Exercises",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
