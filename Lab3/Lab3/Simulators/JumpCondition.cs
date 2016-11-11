using Lab3.Simulators.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Simulators
{
    public class JumpCondition : IJumpCondition, IEquatable<JumpCondition>
    {
        public bool? IsFirstAvailable { get; set; }
        public bool? IsSecondAvailable { get; set; }
        public ISystemState JumpState { get; set; }

        public bool Equals(JumpCondition other)
        {
            return (other.IsFirstAvailable == this.IsFirstAvailable || this.IsFirstAvailable == null) &&
                   (other.IsSecondAvailable == this.IsSecondAvailable || this.IsSecondAvailable == null);
        }

        public bool Equals(IJumpCondition other)
        {
            if (other != null && this.GetType() == other.GetType())
            {
                return Equals((JumpCondition)other);
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == this.GetType())
                return Equals((JumpCondition)obj);
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (IsFirstAvailable.GetHashCode()*397) ^ IsSecondAvailable.GetHashCode();
            }
        }

        public override string ToString()
        {
            return $"{IsFirstAvailable}-{IsSecondAvailable}-{JumpState.Index}";
        }
    }
}
