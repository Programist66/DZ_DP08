using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP08
{
    public interface IStateOven
    {
        IStateOven TurnOnOven(int temperature);
        IStateOven TurnOffOven();
        IStateOven SetTimerOven(float minutes);
    }
}
