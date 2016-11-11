using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Simulators.Interface
{
    public interface ISystemState
    {
        int Index { get; set; }
        IJumpCondition[] JumpConditionArray { get; set; }
    }
}
