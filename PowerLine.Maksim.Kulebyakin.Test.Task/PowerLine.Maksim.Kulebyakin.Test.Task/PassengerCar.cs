using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine.Maksim.Kulebyakin.Test.Task
{
    public class PassengerCar : Auto
    {
        public int CountOfPassenger { get; }

        public int MaxPassenger { get; }

        public PassengerCar(int maxPassenger, int countOfPassenger, double averageFuelConsumption, double fuelTankVolume, double speed, double currentFuel) 
            : base(averageFuelConsumption, fuelTankVolume, speed, currentFuel)
        {
            if (countOfPassenger > maxPassenger)
            {
                throw new ArgumentException("Count of passenger cannot be bigger than max passenger");
            }

            MaxPassenger = maxPassenger;
                        
            CountOfPassenger = countOfPassenger;

            NameOfType = GetType().Name;
        }

        protected override double GetKilometers(double fuel)
        {
            if (CountOfPassenger == 0)
            {
               return fuel / AverageFuelConsumptionInHour;
            }

            int extraPercentage = 6 * CountOfPassenger;

            return fuel / (AverageFuelConsumptionInHour + (AverageFuelConsumptionInHour * extraPercentage / 100));
        }

        public override void DisplayCurrentFuelRange()
        {
            Console.WriteLine($"Current power reserve is {GetKilometers(CurrentFuel)} km");
        }
    }
}
