using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Generator.Interface;

namespace Lab2.Generator
{
    public class SimpsonGenerator : IGenerator<double>
    {
        private readonly IGenerator<double> generator;
        private readonly double A;
        private readonly double B;
        public SimpsonGenerator(IGenerator<double> generator, double A, double B)
        {
            this.generator = new UniformGenerator(generator, A/2, B/2);
            this.A = A;
            this.B = B;
        }
        public double GetNext()
        {
            return generator.GetNext() + generator.GetNext();
        }
    }
}
