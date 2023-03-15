using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatesTask
{
    internal class Bird : FlyingInstance
    {
        Random random = new Random();
        int range = 20;
        

        public Bird(Coordinates currentLocation, Coordinates newLocation) : base (currentLocation, newLocation)
        {
            this.Name = "Bird";
            SpeedKmH = random.NextDouble() * range;
        }

        // Assuming max bird fly distance is 100 Km, we have to take it into account.
        public override double GetFlyTime() 
        {
            if (base.GetFlyDistance() > 100) 
            {
                double birdTimeFlying = Math.Round(100 / SpeedKmH, 2);

                Console.WriteLine($"The distance happened to be too much for a bird. It got tired after {birdTimeFlying} hours of flying.");
                return birdTimeFlying;
            } 
            else 
            {
                return base.GetFlyTime();
            }
        }
        
        
    }
}
