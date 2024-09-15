using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP08
{
    public class OnStateOven : IStateOven
    {
        private int temperature;

        public OnStateOven(int temperature)
        {
            this.temperature = temperature;
        }

        public IStateOven SetTimerOven(float minutes)
        {
            Console.WriteLine($"Таймер установлен на {minutes} минут");
            return new TimerStateOven(minutes, temperature);
        }

        public IStateOven TurnOffOven()
        {
            Console.WriteLine("Духовка выключилась");
            return new OffStateOven();
        }

        public IStateOven TurnOnOven(int temperature)
        {
            Console.WriteLine($"Духовка включена на температуру {temperature}");
            return this;
        }

        public override string ToString() 
        {
            return $"Духовка включена на температуру: {temperature}";
        }
    }
}
