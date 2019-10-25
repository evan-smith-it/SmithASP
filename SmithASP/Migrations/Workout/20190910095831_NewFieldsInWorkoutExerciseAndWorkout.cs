using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations.Workout
{
    public partial class NewFieldsInWorkoutExerciseAndWorkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Workouts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "WorkoutExercises",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "WorkoutExercises",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "WorkoutExercises");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "WorkoutExercises");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Workouts",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
