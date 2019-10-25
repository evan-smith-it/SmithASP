using Microsoft.AspNetCore.Mvc.Rendering;
using SmithASP.Models.Workout;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.ViewModels.WorkoutViewModels
{
    public class WorkoutCreationViewModel
    {
        [Required]
        [Display(Name = "Workout Name")]
        public string WorkoutName { get; set; }
        public DateTime Duration { get; set; }
        public string Description { get; set; }
        public WorkoutExercise[] WorkoutExercises {get; set;}
        public Exercise[] allExercises { get; set; }
        [Display(Name = "Save?")]
        public bool SaveWorkout { get; set; }

    }
}
