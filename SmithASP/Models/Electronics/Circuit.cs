using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.Electronics
{
    public class Circuit
    {
        private int circuitId;
        private Current current;
        private Voltage sourceVolts;
        private Coulomb coulomb;
        private Electron electron;
        private int componentCount;
        private Resistance totalResistance;
        private double electronsPerSecond;
        private double runTime;
        private double joulesPerSecond;
        private List<Resistance> resistorsList = new List<Resistance>();

        public Circuit()
        {

        }

        public Circuit(Current current, Voltage volts, Resistance resistance)
        {
            Current = current;
            SourceVolts = volts;
            TotalResistance = resistance;
            ElectronsPerSecond = coulomb.ElectronDensity * Current.Amps;
            JoulesPerSecond = CalculatePotentialDifference(ElectronsPerSecond, SourceVolts.Volts);
        }

        [Key]
        public int CircuitId { get => circuitId; set => circuitId = value; }
        public Current Current { get => current; set => current = value; }
        public Voltage SourceVolts { get => sourceVolts; set => sourceVolts = value; }
        public Resistance TotalResistance { get => totalResistance; set => totalResistance = value; }
        public double ElectronsPerSecond { get => electronsPerSecond; set => electronsPerSecond = value; }
        public double RunTime { get => runTime; set => runTime = value; }
        public double JoulesPerSecond { get => joulesPerSecond; set => joulesPerSecond = value; }
        public List<Resistance> ResistorsList { get => resistorsList; set => resistorsList = value; }
        public int ComponentCount { get => componentCount; set => componentCount = value; }


        public double CalculatePotentialDifference(double electrons, double volts)
        {
            double unitPotentialDifference = this.electron.Charge * volts;
            double potentialDifference = unitPotentialDifference * electrons;
            return potentialDifference;
        }

        public double ParallelResistorsValue(double resistorOne, double resistorTwo)
        {
            double inverseTotal = (1 / resistorOne) + (1/resistorTwo);
            double totalResistance = 1 / inverseTotal;
            return totalResistance;
        }

        public double ParallelResistorsValue(List<double> resistors)
        {
            double inverseTotal = 0;
            foreach(double r in resistors)
            {
                inverseTotal += 1 / r;
            }
            return 1 / inverseTotal;
        }
    }
}
