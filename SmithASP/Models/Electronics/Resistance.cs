using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Electronics
{
    public class Resistance
    {
        private int resistanceId;
        private double ohms;
        public Resistance()
        {
            Ohms = 0;
        }

        public Resistance(double ohms)
        {
            Ohms = ohms;
        }

        public Resistance(Current amps, Voltage volts)
        {
            Ohms = volts.Volts / amps.Amps;
        }

        public double Ohms { get => ohms; set => ohms = value; }
        public int ResistanceId { get => resistanceId; set => resistanceId = value; }
    }
}
