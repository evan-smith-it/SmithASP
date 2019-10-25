using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations.Workout
{
    public partial class AddTargetDurationToWorkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TargetDuration",
                table: "Workouts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TargetDuration",
                table: "Workouts");
        }
    }
}
