using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Workout
{

    public class Exercise
    {
        public Exercise(int id, string name, string userName)
        {
            Id = id;
            Name = name;
            UserName = userName;
        }

        public Exercise()
        {
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
