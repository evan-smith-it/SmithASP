using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Electronics
{
    public class Voltage
    {
        private int voltageId;
        private double volts;

        public Voltage()
        {
            Volts = 1.5;
        }

        public Voltage(double volts)
        {
            Volts = volts;
        }

        public double Volts { get => volts; set => volts = value; }
        public int VoltageId { get => voltageId; set => voltageId = value; }
    }
}
