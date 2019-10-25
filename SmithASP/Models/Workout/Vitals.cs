using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Workout
{
    public class Vitals
    {
        [Key]
        public int Id { get; set; }
        public string AspNetUserId { get; set; }
        public int BP { get; set; }
        public int HR { get; set; }
        public DateTime Time { get; set; }

    }
}
