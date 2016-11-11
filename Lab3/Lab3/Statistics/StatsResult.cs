using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Statistics
{
    public class StatsResult
    {
        public List<double> FrequencyList { get; set; }
        public double FrequencySum { get; set; }
        public double RelativeBandwidth { get; set; }
        public double AbsoluteBandwidth { get; set; }
        public double AverageBufferLength { get; set; }
    }
}
