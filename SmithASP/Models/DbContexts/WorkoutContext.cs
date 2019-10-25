using Microsoft.EntityFrameworkCore;
using SmithASP.Models.Workout;
using SmithASP.ViewModels.WorkoutViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.DbContexts
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext(DbContextOptions<WorkoutContext> options) : base(options) { }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }
        public DbSet<Workout.Workout> Workouts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Vitals> Vitals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciseMuscleGroup>().HasKey(x => new { x.ExerciseId, x.MuscleGroupId });
            modelBuilder.Entity<WorkoutExercise>().HasKey(x => new { x.WorkoutId, x.ExerciseId });
        }

        public int HighestExerciseId()
        {
            if (this.Exercises.Any())
                return this.Exercises.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            else
                return 1;
        }

        public List<ExerciseViewModelV2> GetExercisesForUser(string Username)
        {
            var exercises = from e in Exercises
                                       where e.UserName == Username || Username == "Universal_Exercise"
                                       select e;

            int counter = 0;
            List<ExerciseViewModelV2> exerciseList = new List<ExerciseViewModelV2>();
            foreach (Exercise e in exercises.Take<Exercise>(5).ToList())
            {
                ExerciseViewModelV2 EVM = new ExerciseViewModelV2();
                EVM.Exercise = e;
                var EMGQuery = from EMG in ExerciseMuscleGroups
                               join MG in MuscleGroups
                               on new { EMG.MuscleGroupId }
                               equals new { MG.MuscleGroupId }
                               select MG;
                foreach(MuscleGroup MG in EMGQuery)
                {
                    EVM.MuscleGroups.Add(MG);
                }
                exerciseList.Add(EVM);
                counter++;
            }

            if (exerciseList.Count != 0)
            {
                return exerciseList;
            }
            else return null;
        }
    }
}
