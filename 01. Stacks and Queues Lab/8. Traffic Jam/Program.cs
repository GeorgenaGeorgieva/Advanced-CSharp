using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCarsPassed = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int totalPassedCars = 0;
            var comand = Console.ReadLine();

            while (comand != "end")
            {
                if (comand == "green")
                {
                    var carToPass = Math.Min(numbersOfCarsPassed, cars.Count);

                    for (int i = 1; i <= carToPass; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        totalPassedCars++;
                    }
                }
                else
                {
                    var currentCar = comand;
                    cars.Enqueue(currentCar);
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine($"{totalPassedCars} cars passed the crossroads.");
        }
    }
}
