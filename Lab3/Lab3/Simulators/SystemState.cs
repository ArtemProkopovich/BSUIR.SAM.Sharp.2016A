using Lab3.Simulators.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Simulators
{
    public class SystemState: ISystemState
    {
        public int Index { get; set; }
        public int OrderState { get; set; }
        public int FirstControllerState { get; set; }
        public int BufferState { get; set; }
        public int SecondControllerState { get; set; }
        public JumpCondition[] JumpConditionArray { get; set; }
        IJumpCondition[] ISystemState.JumpConditionArray { get { return JumpConditionArray; } set {JumpConditionArray = value as JumpCondition[];} }

        public override string ToString()
        {
            return $"State {Index}: {OrderState}-{FirstControllerState}-{BufferState}-{SecondControllerState}";
        }
    }
}
