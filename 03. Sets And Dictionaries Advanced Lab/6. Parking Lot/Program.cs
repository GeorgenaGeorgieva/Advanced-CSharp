namespace ParkingLot
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLists = new HashSet<string>();

            while (true)
            {
                string[] inputLine = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (inputLine[0] == "END")
                {
                    break;
                }

                string direction = inputLine[0];
                string carNumber = inputLine[1];

                if (direction == "IN")
                {
                    parkingLists.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    if (parkingLists.Contains(carNumber))
                    {
                        parkingLists.Remove(carNumber);
                    }
                }
            }

            if (parkingLists.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, parkingLists));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
