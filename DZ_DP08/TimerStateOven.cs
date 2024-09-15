using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP08
{
    public class TimerStateOven : IStateOven
    {
        private float minutes;
        private int temperature;

        public TimerStateOven(float minutes, int temperature)
        {
            this.minutes = minutes;
            this.temperature = temperature;
        }

        public IStateOven SetTimerOven(float minutes)
        {
            Console.WriteLine("Таймер уже установлен");
            return this;
        }

        public IStateOven TurnOffOven()
        {
            Console.WriteLine("Духовка выключилась");
            return new OffStateOven();
        }

        public IStateOven TurnOnOven(int temperature)
        {
            Console.WriteLine("Дховка уже включена");
            return this;
        }

        public override string ToString() 
        {
            return $"Духовка включена\nЗаданная температура: {temperature}\nТаймер установлен на {minutes} минут ";
        }
    }
}
