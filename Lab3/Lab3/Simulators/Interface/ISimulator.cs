using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Simulators.Interface
{
    public interface ISimulator<T> where T : ISystemState
    {
        int CurrentTact { get; set; }
        T[] StateArray { get; set; }
        T CurrentState { get; set; }
        IJumpCondition JumpNextState();
    }
}
