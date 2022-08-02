using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine.Maksim.Kulebyakin.Test.Task
{
    public class CargoCar : Auto
    {
        public int MaxCargo { get; }

        public int Cargo { get; }

        public CargoCar(int maxCargo, int cargo, double averageFuelConsumption, double fuelTankVolume, double speed, double currentFuel) 
            : base(averageFuelConsumption, fuelTankVolume, speed, currentFuel)
        {
            if (cargo > maxCargo)
            {
                throw new ArgumentException("Not enough space for this cargo");
            }

            MaxCargo = maxCargo;

            Cargo = cargo;

            NameOfType = GetType().Name;
        }

        protected override double GetKilometers(double fuel)
        {
            if (Cargo / 200 < 1)
            {
                return fuel / AverageFuelConsumptionInHour;
            }

            int extraPercentage = 4 * Cargo / 200;

            return fuel / (AverageFuelConsumptionInHour + (AverageFuelConsumptionInHour * extraPercentage / 100));
        }

        public override void DisplayCurrentFuelRange()
        {
            Console.WriteLine($"Current power reserve is {GetKilometers(CurrentFuel)} km");
        }
    }
}
