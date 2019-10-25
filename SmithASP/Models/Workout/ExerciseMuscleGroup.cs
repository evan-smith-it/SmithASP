using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Workout
{
    public class ExerciseMuscleGroup
    {
        public ExerciseMuscleGroup()
        {

        }
        public ExerciseMuscleGroup(int exerciseId, int muscleGroupId)
        {
            ExerciseId = exerciseId;
            MuscleGroupId = muscleGroupId;
        }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int MuscleGroupId { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}
