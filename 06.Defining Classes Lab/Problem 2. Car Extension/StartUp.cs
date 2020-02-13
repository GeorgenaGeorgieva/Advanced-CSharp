namespace CarManufacturer
{
    using System;
    using Problem_2._Car_Extension;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
