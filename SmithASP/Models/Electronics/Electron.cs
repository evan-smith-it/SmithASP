using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Electronics
{
    public class Electron
    {
        private const double charge = 0.0000000000000000001602;
        public Electron(){ }

        public double Charge { get => charge; }
    }
}
