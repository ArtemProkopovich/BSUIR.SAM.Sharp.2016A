using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Generator.Interface;

namespace Lab2.SequenceModel
{
    public class Sequence
    {
        public double[] Values { get; }
        public double ExpectedValue { get; }
        public double Dispersion { get; }
        public double StandartDeviation { get; }

        public Sequence(IGenerator<double> generator, int sequenceLength)
        {
            Values = new double[sequenceLength];
            for (int i = 0; i < sequenceLength; i++)
            {
                Values[i] = generator.GetNext();
            }
            ExpectedValue = Values.Average();
            Dispersion = 1.0/(sequenceLength - 1)*Values.Sum(e => Math.Pow(e - ExpectedValue, 2));
            StandartDeviation = Math.Sqrt(Dispersion);
        }
    }
}
