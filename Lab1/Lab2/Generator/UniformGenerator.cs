using System;
using Lab1.Generator;
using Lab1.Generator.Interface;

namespace Lab2.Generator
{
    public class UniformGenerator : IGenerator<double>
    {
        private readonly IGenerator<double> generator;
        private readonly double A;
        private readonly double B;
        public UniformGenerator(IGenerator<double> generator, double A, double B)
        {
            this.generator = generator;
            this.A = A;
            this.B = B;
        }

        public double GetNext()
        {
            return A + (B - A)*generator.GetNext();
        }
    }
}
