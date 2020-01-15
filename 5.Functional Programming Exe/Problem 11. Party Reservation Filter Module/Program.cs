using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_11._Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> partyGuests = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            List<string> filters = new List<string>();

            string command = Console.ReadLine();

            while (command != "Print")
            {
                string[] commandInfo = command.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandInfo[0];
                string criterion = commandInfo[1];
                string parameter = commandInfo[2];

                if (currentCommand == "Add filter")
                {
                    filters.Add($"{criterion},{parameter}");
                }
                else if (currentCommand == "Remove filter")
                {
                    filters.Remove($"{criterion},{parameter}");
                }

                command = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                string[] specifications = filter.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                string currentCriterion = specifications[0];
                string currentParameter = specifications[1];

                if (currentCriterion == "Starts with")
                {
                    partyGuests = partyGuests.Where(g => !g.StartsWith(currentParameter)).ToList();
                }
                else if (currentCriterion == "Ends with")
                {
                    partyGuests = partyGuests.Where(g => !g.EndsWith(currentParameter)).ToList();
                }
                else if (currentCriterion == "Length")
                {
                    int length = int.Parse(currentParameter);
                    partyGuests = partyGuests.Where(g => g.Length != length).ToList();
                }
                else if (currentCriterion == "Contains")
                {
                    partyGuests = partyGuests.Where(g => !g.Contains(currentParameter)).ToList();
                }
            }

            if (partyGuests.Count > 0)
            {
                Console.WriteLine(string.Join(" ", partyGuests));
            }
        }
    }
}
