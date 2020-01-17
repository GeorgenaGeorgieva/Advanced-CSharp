
namespace DefiningClasses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int countEngine = int.Parse(Console.ReadLine());

            for (int i = 0; i < countEngine; i++)
            {
                string[] engineInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = engineInformation[0];
                int power = int.Parse(engineInformation[1]);
                int displacement = default(int);
                string efficiency = default(string);

                Engine currentEngine = null;

                if (engineInformation.Length == 2)
                {
                    currentEngine = new Engine(model, power);
                }
                else if (engineInformation.Length == 3)
                {
                    if (engineInformation[2].All(Char.IsDigit))
                    {
                        displacement = int.Parse(engineInformation[2]);
                        currentEngine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        efficiency = engineInformation[2];
                        currentEngine = new Engine(model, power, efficiency);
                    }
                }
                else if (engineInformation.Length == 4)
                {
                    displacement = int.Parse(engineInformation[2]);
                    efficiency = engineInformation[3];
                    currentEngine = new Engine(model, power, displacement, efficiency);
                }

                engines.Add(currentEngine);
            }

            int countCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCar; i++)
            {
                string[] carInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = carInformation[0];
                Engine engine = engines.First(e => e.Model == carInformation[1]);
                int weight = default(int);
                string color = default(string);

                Car currentCar = null;

                if (carInformation.Length == 2)
                {
                    currentCar = new Car(model, engine);
                }
                else if (carInformation.Length == 3)
                {
                    if (carInformation[2].All(Char.IsDigit))
                    {
                        weight = int.Parse(carInformation[2]);
                        currentCar = new Car(model, engine, weight);
                    }
                    else
                    {
                        color = carInformation[2];
                        currentCar = new Car(model, engine, color);
                    }
                }
                else if (carInformation.Length == 4)
                {
                    weight = int.Parse(carInformation[2]);
                    color = carInformation[3];
                    currentCar = new Car(model, engine, weight, color);
                }

                cars.Add(currentCar);
            }

            cars.ForEach(Console.WriteLine);
        }
    }
}
