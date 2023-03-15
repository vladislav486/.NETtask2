namespace CoordinatesTask
{
    abstract class FlyingInstance : IFlyable
    {
        protected FlyingInstance(Coordinates currentLocation, Coordinates newLocation)
        {
            CurrentLocation = currentLocation;
            NewLocation = newLocation;
        }

        public string Name { get; protected set; }
        public Coordinates CurrentLocation { get; set; }
        public Coordinates NewLocation { get; set; }
        public virtual double SpeedKmH { get; protected set; }

        public virtual double GetFlyDistance()
        {
            return Math.Sqrt(Math.Pow(NewLocation.X - CurrentLocation.X, 2) + Math.Pow(NewLocation.Y - CurrentLocation.Y, 2) + Math.Pow(NewLocation.Z - CurrentLocation.Z, 2));
        }

        public virtual double  GetFlyTime()
        {
            double timeInHours = GetFlyDistance() / SpeedKmH;
            timeInHours = Math.Round(timeInHours, 2);
            Console.WriteLine($"The {Name} was {timeInHours} hours in the air on the way to a needed location.");
            return timeInHours;
        }

        public void FlyTo()
        {
            CurrentLocation = NewLocation;
            Console.WriteLine($"Object has arrived to a new location. Current location: {CurrentLocation}");
        }
    }
}
