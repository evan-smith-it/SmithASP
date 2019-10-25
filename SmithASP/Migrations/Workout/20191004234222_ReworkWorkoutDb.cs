using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations.Workout
{
    public partial class ReworkWorkoutDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "WorkoutExercises");

            migrationBuilder.DropColumn(
                name: "FormScore",
                table: "WorkoutExercises");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "WorkoutExercises");

            migrationBuilder.AlterColumn<string>(
                name: "TargetDuration",
                table: "Workouts",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MuscleGroups",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TargetDuration",
                table: "Workouts",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Workouts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Workouts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "WorkoutExercises",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FormScore",
                table: "WorkoutExercises",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "WorkoutExercises",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MuscleGroups",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
