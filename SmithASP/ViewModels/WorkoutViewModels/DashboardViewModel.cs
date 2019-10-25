using SmithASP.Models.Workout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.ViewModels.WorkoutViewModels
{
    public class DashboardViewModel
    {

        public DashboardViewModel()
        {
            ExerciseViewModel = new ExerciseViewModel();
            ScheduledWorkouts = new ScheduledWorkoutViewModel();
        }

        public ExerciseViewModel ExerciseViewModel { get; set; }

        public ScheduledWorkoutViewModel ScheduledWorkouts { get; set; }

        public List<ExerciseViewModelV2> Exercises { get; set; }
    }
}
