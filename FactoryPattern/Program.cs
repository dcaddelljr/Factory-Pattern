namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you rather have a car or motorcycle?");
            string userCar = Console.ReadLine();
            Console.WriteLine();

            IVehicle car = VehicleFactory.GetVehicle(userCar);

            car.Drive();
        }
    }
}
