using System;
using System.Linq;
using Lab3.Simulators.Interface;
using Lab3.Utilities;

namespace Lab3.Simulators
{
    public class Simulator : ISimulator<SystemState>
    {
        public double FirstPropability { get; set; }
        public double SecondPropability { get; set; }
        public int CurrentTact { get; set; }
        public SystemState[] StateArray { get; set; }
        public SystemState CurrentState { get; set; }

        public Simulator(double firstPropability, double secondPropability, SystemState[] stateArray, SystemState initState)
        {
            this.FirstPropability = firstPropability;
            this.SecondPropability = secondPropability;
            this.CurrentState = initState;
            this.StateArray = stateArray;
        }

        public JumpCondition JumpNextState()
        {
            JumpCondition jumpCondition = new JumpCondition()
            {
                IsFirstAvailable = Distributor.IsNextTrue(FirstPropability),
                IsSecondAvailable = Distributor.IsNextTrue(SecondPropability)
            };
            var foundCondition = CurrentState.JumpConditionArray.First(e => e.Equals(jumpCondition));
            CurrentState = (SystemState)foundCondition.JumpState;
            return foundCondition;
        }

        IJumpCondition ISimulator<SystemState>.JumpNextState()
        {
            return JumpNextState();
        }
    }
}
