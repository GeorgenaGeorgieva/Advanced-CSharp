namespace RepairAndService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            Queue<string> queueCars = new Queue<string>(cars);
            Stack<string> servedCars = new Stack<string>();
            
            while (true)
            {
                string[] comands = Console.ReadLine()
                    .Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                
                string currentComand = comands[0];

                if (currentComand == "End")
                {
                    break;
                }
                else if (currentComand == "Service")
                {
                    string served = queueCars.Peek();
                    servedCars.Push(served);
                    
                    Console.WriteLine($"Vehicle {served} got served.");
                    queueCars.Dequeue();
                }
                else if (currentComand == "History")
                {
                    Console.WriteLine(string.Join(",", servedCars));
                }
                else
                {
                    string[] carInfo = currentComand
                        .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    string comand = carInfo[0];
                    string modelName = carInfo[1];

                    if (queueCars.Contains(modelName) && comand == "CarInfo")
                    {
                        Console.WriteLine($"Still waiting for service.");
                    }
                    
                    if (servedCars.Contains(modelName) && comand == "CarInfo")
                    {
                        Console.WriteLine($"Served.");
                    }
                }
            }
            
            if (queueCars.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(",", queueCars)}");
            }
            
            if (servedCars.Any())
            {
                Console.WriteLine($"Served vehicles: {string.Join(",", servedCars)}");
            }
        }
    }
}
