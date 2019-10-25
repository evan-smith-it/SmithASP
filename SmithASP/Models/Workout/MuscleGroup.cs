using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Workout
{
    public class MuscleGroup
    {
        [Key]
        public int MuscleGroupId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
