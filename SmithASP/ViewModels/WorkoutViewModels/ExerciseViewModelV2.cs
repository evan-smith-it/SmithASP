using SmithASP.Models.Workout;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.ViewModels.WorkoutViewModels
{
    public class ExerciseViewModelV2
    {

        public ExerciseViewModelV2()
        {
            MuscleGroups = new List<MuscleGroup>();
        }

        [Required]
        public Exercise Exercise { get; set; }
        [Required]
        public List<MuscleGroup> MuscleGroups { get; set; }
    }
}