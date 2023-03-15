using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatesTask
{
    internal class Plane : FlyingInstance
    {
        public Plane(Coordinates currentLocation, Coordinates newLocation) : base(currentLocation, newLocation)
        {
            this.Name = "Plane";
            // Since plane's speed changes up to 10 km/h every 10 minutes, we can take the distance
            // the plane passed as an approx speed it gained and find the max speed to be able to 
            // find the avg speed of the plane.
            SpeedKmH = GetPlaneAvgSpeed();
        }
        double startSpeedKmH = 200;
        double avgPlaneSpeedKmH;

        //Our plane's max average speed is 350KmH (min 200 and max 500) so we need to consider that fact.
        private double GetPlaneAvgSpeed() 
        {
            if ((startSpeedKmH + (this.GetFlyDistance() + startSpeedKmH)) / 2 > 350) 
            {
                avgPlaneSpeedKmH = 350;
                return avgPlaneSpeedKmH;
            } else 
            {
                avgPlaneSpeedKmH = startSpeedKmH + (this.GetFlyDistance() + startSpeedKmH) / 2;
                return avgPlaneSpeedKmH;
            }
        }


    }
}
