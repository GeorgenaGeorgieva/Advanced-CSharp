namespace TruckTour
{
     using System;
     using System.Linq;
     using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> difference = new Queue<int>();
            
            int petrolPumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < petrolPumps; i++)
            {
                int[] pumpInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                int givesPetrol = pumpInfo[0];
                int necessaryPetrol = pumpInfo[1];
                
                difference.Enqueue(givesPetrol - necessaryPetrol);
            }

            int index = 0;

            while (true)
            {
                Queue<int> copyDifference = new Queue<int>(difference);
                
                int fuel = -1;
               
                while (copyDifference.Any())
                {
                    if (copyDifference.Peek() > 0 && fuel == -1)
                    {
                        fuel = copyDifference.Dequeue();
                        difference.Enqueue(difference.Dequeue());
                    }
                    else if (copyDifference.Peek() < 0 && fuel == -1)
                    {
                        copyDifference.Enqueue(copyDifference.Dequeue());
                        difference.Enqueue(difference.Dequeue());
                        index++;
                    }
                    else
                    {
                        fuel += copyDifference.Dequeue();
                        
                        if (fuel < 0)
                        {
                            break;
                        }
                    }
                }

                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
                
                index++;
            }
        }
    }
}
