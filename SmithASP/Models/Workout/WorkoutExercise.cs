using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Workout
{
    public class WorkoutExercise
    {
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public float Weight { get; set; }
        //Type could vary depending on how an exercise is being performed. Generally this is not the case but I think it is better off
        //Stored here so that certain exercises can be more flexible in their type
        public string Type { get; set; }
        //Running won't require rest time, lifting time should have pre determined rest times between each set
        //Advanced or scaling rest times can be added once a high mastery of regular exercises is reached
        public DateTime RestTime { get; set; }
        //The next three fields are used for post workout record keeping
        //Including timings will benefit advanced users who are aiming to achieve reps/time results

    }
}
