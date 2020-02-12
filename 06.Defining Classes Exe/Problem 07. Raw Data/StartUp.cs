namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] carInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = carInformation[0];
                int speed = int.Parse(carInformation[1]);
                int power = int.Parse(carInformation[2]);
                int weight = int.Parse(carInformation[3]);
                string type = carInformation[4];

                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weight, type);
                List<Tire> tires = new List<Tire>();

                for (int k = 5; k < 9; k += 2)        //collection of exactly 4 tires
                {
                    double pressure = double.Parse(carInformation[k]);
                    int age = int.Parse(carInformation[k + 1]);

                    Tire currentTire = new Tire(pressure, age);
                    tires.Add(currentTire);
                }

                Car currentCar = new Car(model, engine, cargo, tires);
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            Car car = new Car();

            car.PrintingResult(command, cars);
        }
    }
}
