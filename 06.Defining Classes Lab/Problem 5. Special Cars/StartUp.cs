using System;
using System.Collections.Generic;
using System.Linq;
using CarManufacturer;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<int, List<double>> carTires = new Dictionary<int, List<double>>();  // years, pressure
            Dictionary<int, List<double>> carEngines = new Dictionary<int, List<double>>(); // hprsePower, cubicCapacity


            string inputLine = Console.ReadLine();
            string breakCommand = "No more tires";
            

            CollectingCarParts(inputLine, breakCommand, carTires);

            inputLine = Console.ReadLine();
            breakCommand = "Engines done";

            //Tire[] tires = new Tire[2];

            CollectingCarParts(inputLine, breakCommand, carEngines);

            inputLine = Console.ReadLine();

            while (inputLine != "Show special")
            {
                string[] specialCarsCriterion = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var currentMake = specialCarsCriterion[0];
                var currentModel = specialCarsCriterion[1];
                var currentYear = int.Parse(specialCarsCriterion[2]);
                var currentFuelQuantity = double.Parse(specialCarsCriterion[3]);
                var currentFuelConsumption = double.Parse(specialCarsCriterion[4]);
                var currentEngine = carEngines[int.Parse(specialCarsCriterion[5])];
                var currentTires = carTires[int.Parse(specialCarsCriterion[6])];

                Car car = new Car(currentMake, currentModel, currentYear, currentFuelQuantity, currentFuelConsumption,)
              //  { make}
                { model}
                { year}
                { fuelQuantity}
                { fuelConsumption}
                { engineIndex}
                { tiresIndex}
                inputLine = Console.ReadLine();
            }

        }

        private static Dictionary<int, List<double>> CollectingCarParts(string inputLine, string breakcommand, Dictionary<int, List<double>> autoParts)
        {
            while (inputLine != breakcommand)
            {
                string[] command = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int index = 0;

                for (int i = 0; i < command.Length; i += 2)
                {
                    int yearOrHorsePower = int.Parse(command[i]);
                    double pressureOrCubicCapacity = double.Parse(command[i + 1]);

                    if (!autoParts.ContainsKey(index))
                    {
                        autoParts.Add(index, new List<double>());
                        autoParts[index].Add(yearOrHorsePower);
                        autoParts[index].Add(pressureOrCubicCapacity);
                    }

                    index++;
                }

                inputLine = Console.ReadLine();
            }

            return autoParts;
        }
    }
}
