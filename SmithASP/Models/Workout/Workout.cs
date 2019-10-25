using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Workout
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string AspNetUserId { get; set; }
        [Required]
        public String TargetDuration { get; set; }
        public String Description { get; set; }
    }
}
