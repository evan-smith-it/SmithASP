using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Electronics
{
    public class Coulomb
    {
        private double electronDensity;

        public Coulomb()
        {
            ElectronDensity = 6242197253433208489.3882646691635;
        }

        public double ElectronDensity { get => electronDensity; set => electronDensity = value; }
    }
}
