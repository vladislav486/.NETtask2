using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatesTask
{
    internal class CreateInstance
    {
        List<FlyingInstance> instancesUnderSupervision;
        public void GetInstancesReady() 
        {
            Coordinates currentLocation1 = new Coordinates(156.8, 561.5, 12.1);
            Coordinates currentLocation2 = new Coordinates(14.7, 61.2, 152);
            Coordinates currentLocation3 = new Coordinates(78.2, 374.9, 127.1);
            Coordinates newLocation1 = new Coordinates(1556.8, 5061.5, 1225.1);
            Coordinates newLocation2 = new Coordinates(600.8, 451.5, 5685.1);
            Coordinates newLocation3 = new Coordinates(954.8, 126.5, 1562.1);

            instancesUnderSupervision = new List<FlyingInstance>()
            {
                new Plane(currentLocation1, newLocation1),
                new Bird(currentLocation2, newLocation2),
                new Drone(currentLocation3, newLocation3)
            };
        }

        public void GetDistanceOfInstance()
        {
            foreach (var instance in instancesUnderSupervision) 
            {
                instance.GetFlyTime();
            }
        }
        

    }
}
