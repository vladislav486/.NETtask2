using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatesTask
{
    internal class Drone : FlyingInstance
    {
        public Drone(Coordinates currentLocation, Coordinates newLocation) : base(currentLocation, newLocation)
        {
            this.Name = "Drone";
        }
        double SpeedKmH = 80;

        public override double GetFlyTime()
        {
            // Drone's max distance is 1000 Km so if the distance is more than 1000 the drone will break.
            if (base.GetFlyDistance() > 1000)
            {
                double timeInHours = 1000 / SpeedKmH;
                // Since drone stops once per 10 minutes for a minute, it will need 10% of time more to aproach the needed location.
                timeInHours = Math.Round(timeInHours * 1.1, 2);
                Console.WriteLine($"The Drone was {timeInHours} hours in the air until it broke (the distance is more than 1000 Km).");
                return timeInHours;
            }
            else
            {
                return base.GetFlyTime() * 1.1;
            }
        }
    }
}
