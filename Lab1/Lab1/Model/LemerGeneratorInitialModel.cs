using Lab1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public class LemerGeneratorInitialModel
    {
        private const long RecomendKoef = 10000000;
        public long? ParamA { get; set; }
        public long? ParamM { get; set; }
        public long? ParamR0 { get; set; }

        public ErrorState ParamAState { get; private set; } = new ErrorState();
        public ErrorState ParamMState { get; private set; } = new ErrorState();
        public ErrorState ParamR0State { get; private set; } = new ErrorState();

        public bool IsValid
        {
            get
            {
                var result = true;
                if (!ParamA.HasValue)
                {
                    result = false;
                    ParamAState.SetError("Значение должно быть числом");
                }
                else if(ParamA.Value<1)
                {
                    result = false;
                    ParamAState.SetError("Значение не может быть меньше 1");
                }
                if (!ParamM.HasValue)
                {
                    result = false;
                    ParamMState.SetError("Значение должно быть числом");
                }
                else if (ParamM.Value < 1)
                {
                    result = false;
                    ParamMState.SetError("Значение не может быть меньше 1");
                }
                if (!ParamR0.HasValue)
                {
                    result = false;
                    ParamR0State.SetError("Значение должно быть числом");
                }
                else if (ParamR0.Value < 1)
                {
                    result = false;
                    ParamR0State.SetError("Значение не может быть меньше 1");
                }
                return result;
            }
        }

        public bool IsRecomended
        {
            get
            {
                if (this.IsValid)
                {
                    bool result = true;
                    if (ParamA < 100000000 - RecomendKoef)
                    {
                        result = false;
                        ParamAState.SetWarning("Рекомендуемое значение А от 10^6 до 10^8");
                    }
                    else
                    {
                        ParamAState.SetProper("Good A value");
                    }
                    if (ParamM < 100000000 - RecomendKoef)
                    {
                        result = false;
                        ParamMState.SetWarning("Рекомендуемое значение M от 10^6 до 10^9");
                    }
                    else
                    {
                        ParamMState.SetProper("Good M value");
                    }
                    if (ParamR0 < 100000000 - RecomendKoef || ParamR0.HasValue == false || !IsPrime(ParamR0.Value))
                    {
                        result = false;
                        ParamR0State.SetWarning("Рекомендуемое значение R0 простое число от 10^6 до 10^8");
                    }
                    else
                    {
                        ParamR0State.SetProper("Good R0 label");
                    }
                    return result;
                }
                return false;
            }
        }

        private bool IsPrime(long n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
