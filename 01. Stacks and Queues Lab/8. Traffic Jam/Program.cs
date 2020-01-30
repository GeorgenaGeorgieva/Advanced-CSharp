

namespace TrafficJam
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            
            int numbersOfCarsPassed = int.Parse(Console.ReadLine());
            int totalPassedCars = 0;
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                if (comand == "green")
                {
                    int carToPass = Math.Min(numbersOfCarsPassed, cars.Count);

                    for (int i = 1; i <= carToPass; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        totalPassedCars++;
                    }
                }
                else
                {
                    string currentCar = comand;
                    cars.Enqueue(currentCar);
                }
                
                comand = Console.ReadLine();
            }
            
            Console.WriteLine($"{totalPassedCars} cars passed the crossroads.");
        }
    }
}
