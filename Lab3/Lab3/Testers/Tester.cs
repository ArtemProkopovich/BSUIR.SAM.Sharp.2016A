using Lab3.Simulators.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Simulators;

namespace Lab3.Testers
{
    public class Tester
    {
        public ISimulator<SystemState> Simulator { get; set; }
        public int TactCount { get; set; }

        public Tester(ISimulator<SystemState> simulator, int tactCount)
        {
            this.Simulator = simulator;
            this.TactCount = tactCount;
        }

        public TestStateResult[] RunTest()
        {
            var result = new TestStateResult[TactCount];
            for (int i = 0; i < TactCount; i++)
            {
                result[i] = new TestStateResult
                {
                    Condition = (JumpCondition) Simulator.JumpNextState(),
                    State = Simulator.CurrentState
                };
            }
            return result;
        }
    }
}
