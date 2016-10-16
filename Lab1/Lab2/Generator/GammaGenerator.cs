using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Generator.Interface;

namespace Lab2.Generator
{
    public class GammaGenerator : IGenerator<double>
    {
        private readonly IGenerator<double> generator;
        private readonly double L;
        private readonly int Mu;
        public GammaGenerator(IGenerator<double> generator, double L, int Mu)
        {
            this.generator = generator;
            this.L = L;
            this.Mu = Mu;
        }
        public double GetNext()
        {
            double temp = 1;
            for (int i = 0; i < Mu; i++)
            {
                temp *= generator.GetNext();
            }
            return -1 / L * Math.Log(temp);
        }
    }
}
