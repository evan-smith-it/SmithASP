using Microsoft.EntityFrameworkCore.Migrations;

namespace SmithASP.Migrations.Workout
{
    public partial class ExerciseMuscleGroupUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMuscleGroups_MuscleGroupId",
                table: "ExerciseMuscleGroups",
                column: "MuscleGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscleGroups_Exercises_ExerciseId",
                table: "ExerciseMuscleGroups",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscleGroups_MuscleGroups_MuscleGroupId",
                table: "ExerciseMuscleGroups",
                column: "MuscleGroupId",
                principalTable: "MuscleGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscleGroups_Exercises_ExerciseId",
                table: "ExerciseMuscleGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscleGroups_MuscleGroups_MuscleGroupId",
                table: "ExerciseMuscleGroups");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseMuscleGroups_MuscleGroupId",
                table: "ExerciseMuscleGroups");
        }
    }
}
