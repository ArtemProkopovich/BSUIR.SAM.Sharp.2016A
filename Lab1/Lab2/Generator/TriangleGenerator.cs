using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Generator.Interface;

namespace Lab2.Generator
{
    public class TriangleGenerator : IGenerator<double>
    {
        private readonly IGenerator<double> generator;
        private readonly double A;
        private readonly double B;
        private readonly bool Min;
        public TriangleGenerator(IGenerator<double> generator, double A, double B, bool min)
        {
            this.generator = generator;
            this.A = A;
            this.B = B;
            this.Min = min;
        }
        public double GetNext()
        {          
            return Min
                ? A + (B - A)*Math.Min(generator.GetNext(), generator.GetNext())
                : A + (B - A)*Math.Max(generator.GetNext(), generator.GetNext());
        }
    }
}
