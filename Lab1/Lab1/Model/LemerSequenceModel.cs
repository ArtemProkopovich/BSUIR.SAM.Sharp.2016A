using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Generator;
using Lab1.Generator.Interface;

namespace Lab1.Model
{
    public class LemerSequenceModel
    {
        public LemerSequenceModel(LemerGenerator generator, int sequenceLength)
        {
            Array = new double[sequenceLength];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = generator.GetNext();
            }
            ExpectedValue = Array.Average();
            Dispersion = 1.0/(sequenceLength - 1)*Array.Sum(e => Math.Pow(e - ExpectedValue, 2));
            StandardDeviation = Math.Sqrt(Dispersion);

            var tempArray = new List<long>(sequenceLength);
            for (int i = 0; i < sequenceLength; i++)
            {
                tempArray.Add(generator.GetNextLong());
            }
            var tempGen = new LemerGenerator(generator.A, generator.M, tempArray[100]);
            var tempArray2 = new List<long>(sequenceLength);
            for (int i = 0; i < sequenceLength; i++)
            {
                tempArray2.Add(tempGen.GetNextLong());
            }
            AperiodicLength = tempArray2.FindIndex(1, e => e == tempArray[0]);
            AperiodicLength = AperiodicLength < 0 ? sequenceLength : AperiodicLength;


            var tempIndex = tempArray.FindIndex(e => e == tempArray[sequenceLength - 1]);
            PeriodLength = tempArray.FindIndex(tempIndex + 1, e => e == tempArray[sequenceLength - 1]) - tempIndex;
            PeriodLength = PeriodLength < 0 ? sequenceLength : PeriodLength;
        }

        public double[] Array { get; }
        public double ExpectedValue { get; }
        public double Dispersion { get; }
        public double StandardDeviation { get; }
        public int AperiodicLength { get; }
        public int PeriodLength { get;}
    }
}
