namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("bmw","320",2021,34251);
            car.setTransmission("manuel");
            car.setColor("Black");
            car.showVehicle();
        }
    }
}
