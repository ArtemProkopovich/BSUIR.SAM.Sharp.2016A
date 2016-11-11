using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Utilities
{
    public static class Distributor
    {
        public static bool IsNextTrue(double propability)
        {
            return RandomGenerator.GetNext() > propability;
        }
    }
}
