using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP08
{
    public class Oven
    {
        public int Temperature { get; private set; }
        public float Minutes { get; private set; }

        public IStateOven CurrentState {  get; set; }

        public Oven() 
        {
            CurrentState = new OffStateOven();
        }

        public void TurnOn(int temperature) 
        {
            Temperature = temperature;
            CurrentState = CurrentState.TurnOnOven(temperature);
        }

        public void TurnOff() 
        {
            CurrentState = CurrentState.TurnOffOven();
        }

        public void SetTimer(float minutes) 
        {
            CurrentState = CurrentState.SetTimerOven(minutes);
            if (CurrentState is TimerStateOven) 
            {
                Thread.Sleep((int)(minutes * 60000));
                TurnOff();
            }
        }

        public override string ToString()
        {
            return CurrentState.ToString();
        }
    }
}
