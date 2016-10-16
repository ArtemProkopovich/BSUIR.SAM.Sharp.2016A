using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Generator.Interface;

namespace Lab2.Generator
{
    public class ExponentialGenerator : IGenerator<double>
    {
        private readonly IGenerator<double> generator;
        private readonly double L;
        public ExponentialGenerator(IGenerator<double> generator, double L)
        {
            this.generator = generator;
            this.L = L;
        }
        public double GetNext()
        {
            return -1/L*Math.Log(generator.GetNext());
        }
    }
}
