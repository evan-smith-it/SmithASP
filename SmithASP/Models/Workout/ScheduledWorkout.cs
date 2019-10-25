using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Workout
{
    public class ScheduledWorkout
    {
        public int Id { get; set; }
        public Workout Workout { get; set; }
        public int WorkoutId { get; set; }
        public string AspNetUserId { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
