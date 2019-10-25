using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations.Workout
{
    public partial class LinkWorkoutDBToUserDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Workouts");

            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "Workouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "Vitals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "Vitals");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Workouts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
