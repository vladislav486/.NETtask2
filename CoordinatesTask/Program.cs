namespace CoordinatesTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance = new CreateInstance();
            instance.GetInstancesReady();
            instance.GetDistanceOfInstance();
            
        }
    }
}