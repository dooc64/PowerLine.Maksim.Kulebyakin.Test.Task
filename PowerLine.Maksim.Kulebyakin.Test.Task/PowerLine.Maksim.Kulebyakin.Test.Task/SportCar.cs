using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine.Maksim.Kulebyakin.Test.Task
{
    public class SportCar : Auto
    {
        public SportCar(double averageFuelConsumption, double fuelTankVolume, double speed, double currentFuel) 
            : base(averageFuelConsumption, fuelTankVolume, speed, currentFuel)
        {
            NameOfType = GetType().Name;
        }
    }
}
