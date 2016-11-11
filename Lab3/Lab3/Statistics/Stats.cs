using Lab3.Simulators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Testers;

namespace Lab3.Statistics
{
    public class Stats
    {
        SystemState[] States { get; set; }
        TestStateResult[] ResultStates { get; set; }
        public Stats(SystemState[] states, TestStateResult[] resultStates)
        {
            this.States = states;
            this.ResultStates = resultStates;
        }

        public StatsResult GetFrequencyStats()
        {
            var resultStates = ResultStates.Select(e => e.State).ToArray();
            var result = new List<double>();
            double sum = 0;
            foreach (var state in States)
            {
                double frequency = 1.0 * resultStates.Count(e => e.Index == state.Index) / ResultStates.Length;
                sum += frequency;
                result.Add(frequency);
            }
            return new StatsResult()
            {
                FrequencyList = result,
                FrequencySum = sum,
                RelativeBandwidth = GetRelativeBandwidth(),
                AbsoluteBandwidth = GetAbsoluteBandwidth(),
                AverageBufferLength = GetAverageBufferLength()
            };
        }

        private double GetRelativeBandwidth()
        {
            return 1.0*ResultStates.Select(e => e.Condition).Count(e => e.IsSecondAvailable == true)/
                   ResultStates.Count();
        }

        private double GetAbsoluteBandwidth()
        {
            return GetRelativeBandwidth()/2;
        }

        private double GetAverageBufferLength()
        {
            return 1.0*ResultStates.Select(e => e.State).Count(e => e.BufferState == 2)*2/ResultStates.Count() +
                   1.0*ResultStates.Select(e => e.State).Count(e => e.BufferState == 1)/ResultStates.Count();
        }
    }
}
