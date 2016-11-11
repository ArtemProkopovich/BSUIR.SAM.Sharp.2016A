using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Utilities
{
    public static class RandomGenerator
    {
        private static long A { get; set; } = 111111113;
        private static long M { get; set; } = 1111111115;
        private static long R { get; set; } = 11111113333;

        private static long MathExp { get; set; } = 1000000;
        private static long StdDev { get; set; } = 1000000;

        static RandomGenerator()
        {
        }
        public static double GetNext()
        {
            R = (A * R) % M;
            return 1.0 * R / M;
        }
    }
}
