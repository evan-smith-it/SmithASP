using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Electronics
{
    public class Current
    {
        private int currentId;
        private double amps;

        public Current()
        {
            Amps = 1;
        }

        public double Amps { get => amps; set => amps = value; }
        [Key]
        public int CurrentId { get => currentId; set => currentId = value; }
    }
}
