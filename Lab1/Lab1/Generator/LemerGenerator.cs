using Lab1.Generator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Generator
{
    public class LemerGenerator : IGenerator<double>
    {
        public long A { get; }
        public long M { get; }
        public long R { get; private set; }

        public LemerGenerator(long A, long M, long R0)
        {
            this.A = A;
            this.M = M;
            this.R = R0;
        }
        public double GetNext()
        {
            R = (A * R) % M;
            return (double)R / M;
        }

        public long GetNextLong()
        {
            R = (A * R) % M;
            return R;
        }
    }
}
