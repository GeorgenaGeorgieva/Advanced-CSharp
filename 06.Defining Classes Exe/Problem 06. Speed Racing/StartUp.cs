namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var carsCollection = new Dictionary<string, Car>();
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var carInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var model = carInformation[0];
                var fielAmount = double.Parse(carInformation[1]);
                var fuelConsumptionForKm = double.Parse(carInformation[2]);

                if (!carsCollection.ContainsKey(model))
                {
                    Car currentCar = new Car(model, fielAmount, fuelConsumptionForKm);
                    carsCollection.Add(model, currentCar);
                }
            }

            while (true)
            {
                var commands = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commands[0] == "End")
                {
                    break;
                }
                else if (commands[0] == "Drive")
                {
                    var carModel = commands[1];
                    var distanceTraveled = int.Parse(commands[2]);

                    Car car = carsCollection[carModel];

                    bool IsEnoughFuelToDrive = car.Drive(distanceTraveled);

                    if (!IsEnoughFuelToDrive)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }                    
                }
            }

            foreach (var kvp in carsCollection)
            {
                Console.WriteLine($"{kvp.Value.Model} {kvp.Value.FuelAmount:F2} {kvp.Value.TravelledDistance}");
            }
        }
    }
}
