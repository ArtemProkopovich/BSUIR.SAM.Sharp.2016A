using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Simulators;

namespace Lab3.Testers
{
    public class TestStateResult
    {
        public JumpCondition Condition { get; set; }
        public SystemState State { get; set; }
    }
}
