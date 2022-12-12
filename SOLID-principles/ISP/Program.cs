namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "Toyota";
            car.Model = "Prius";
            car.Fuel = 10;
            car.CurrentFuel = 5;

            car.AddFuel();
            car.Drive();

            Bicycle bicycle = new Bicycle();
            bicycle.Name = "Abc";
            bicycle.Model = "Test";
            bicycle.Drive();
        }
    }
}