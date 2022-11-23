using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIndasoft
{
    internal class Calculation
    {
        private const int Accuracy = 6;
        public static double Dencity(Measurement measurement)
        {
            var dencityTempMeas = Math.Round((measurement.WeightEmptyPick - measurement.WeightEmptyPick) / measurement.WaterNumber, Accuracy);
            var dencity = Math.Round(dencityTempMeas * measurement.WaterDensity + measurement.CorrectionAirPressure,Accuracy);
            return dencity; 
        }
    }
}
