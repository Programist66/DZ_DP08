using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP08
{
    public class OffStateOven : IStateOven
    {
        public IStateOven SetTimerOven(float minutes)
        {
            Console.WriteLine("Сначало включите духовку");
            return this;
        }

        public IStateOven TurnOffOven()
        {
            Console.WriteLine("Духовка уже выключена");
            return this;
        }

        public IStateOven TurnOnOven(int temperature)
        {
            Console.WriteLine($"Духовка включилась. \nЗаданная температура: {temperature}");
            return new OnStateOven(temperature);
        }

        public override string ToString() 
        {
            return "Духовка выключена";
        }
    }
}
