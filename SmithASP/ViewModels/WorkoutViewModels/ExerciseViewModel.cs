using SmithASP.Models.Workout;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.ViewModels.WorkoutViewModels
{
    public class ExerciseViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public List<MuscleGroup> MuscleGroups { get; set; }
    }
}
