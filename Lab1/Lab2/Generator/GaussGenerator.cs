using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Generator.Interface;

namespace Lab2.Generator
{
    public class GaussGenerator : IGenerator<double>
    {
        private readonly IGenerator<double> generator;
        private readonly double M;
        private readonly double Q;
        private const int GaussSequenceConst = 6;
        public GaussGenerator(IGenerator<double> generator, double M, double Q)
        {
            this.generator = generator;
            this.M = M;
            this.Q = Q;
        }
        public double GetNext()
        {
            double[] tempArr = new double[GaussSequenceConst];
            for (int i = 0; i < 6; i++)
            {
                tempArr[i] = generator.GetNext();
            }
            return M + Q*Math.Sqrt(2)*(tempArr.Sum() - GaussSequenceConst/2.0);
        }
    }
}
