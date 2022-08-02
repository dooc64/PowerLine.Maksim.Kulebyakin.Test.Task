using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine.Maksim.Kulebyakin.Test.Task
{
    public class Auto
    {
        public string NameOfType { get; protected set; }

        public double AverageFuelConsumptionInHour { get; protected set; }

        public double FuelTankVolume { get; protected set; }

        public double Speed { get; protected set; }

        public double CurrentFuel { get; protected set; }

        public Auto(double averageFuelConsumption, double fuelTankVolume, double speed, double currentFuel)
        {
            NameOfType = GetType().Name;

            AverageFuelConsumptionInHour = averageFuelConsumption;

            FuelTankVolume = fuelTankVolume;

            Speed = speed;

            CurrentFuel = currentFuel;
        }

        protected virtual double GetKilometers(double fuel)
        {
            return fuel / AverageFuelConsumptionInHour;
        }

        /// <summary>
        /// Calculate kilometers with a current fuel tank
        /// </summary>
        /// <returns></returns>
        public double GetCurrentKilometers()
        {
            return GetKilometers(CurrentFuel);
        }

        /// <summary>
        /// Calculate kilometers with a full fuel tank
        /// </summary>
        /// <returns></returns>
        public double GetFullKilometers()
        {
            return GetKilometers(FuelTankVolume);
        }

        public virtual void DisplayCurrentFuelRange()
        {
            Console.WriteLine($"Current power reserve is {GetCurrentKilometers()} km");
        }

        public void GetDistance(double fuel, double distance)
        {
            Console.WriteLine(
                GetKilometers(fuel) < distance ? "Not enough fuel for this distance" : $"{distance / Speed} hour");
        }
    }
}
