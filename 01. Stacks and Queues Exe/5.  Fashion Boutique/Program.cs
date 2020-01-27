namespace FashionBoutique
{
     using System;
     using System.Linq;
     using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine()
                .Split(new[] { ' ' }.StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            Stack<int> clothes = new Stack<int>(clothesInBox);
            
            int capacityOfRack = int.Parse(Console.ReadLine());

            bool isBoxCapacity = clothesInBox.Length <= 50;
            bool rackInRange = capacityOfRack >= 0 && capacityOfRack <= 20;
            bool isRackBiggerThanMaxValue = clothes.Max() <= capacityOfRack;

            int rack = 1;
            int sumValuesOfClothes = 0;

            if (isRackBiggerThanMaxValue && rackInRange && isBoxCapacity && clothes.Any())
            {
                while (clothes.Any())
                {
                    int currentClothes = clothes.Peek();
                    
                    if ((sumValuesOfClothes + currentClothes) > capacityOfRack)
                    {
                        rack++;
                        sumValuesOfClothes = 0;
                    }
                    else
                    {
                        sumValuesOfClothes += currentClothes;
                        clothes.Pop();
                    }
                }
                
               Console.WriteLine(rack);
            }
        }
    }
}
