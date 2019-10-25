using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations.Workout
{
    public partial class ChangeExerciseUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Exercises",
                newName: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Exercises",
                newName: "UserId");
        }
    }
}
