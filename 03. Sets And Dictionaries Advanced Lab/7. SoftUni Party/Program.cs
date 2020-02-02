namespace SoftUniParty
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.RegularExpressions;
    
    class Program
    {
        static void Main(string[] args)
        {
            var vip = new HashSet<string>();
            var regularGuests = new HashSet<string>();

            while (true)
            {
                var inputline = Console.ReadLine();

                if (inputline == "END")
                {
                    break;
                }
                else if (inputline == "PARTY")
                {
                    while (true)
                    {
                        var currentGuests = Console.ReadLine();

                        if (IsMatched(currentGuests))
                        {
                            vip.Remove(currentGuests);
                        }
                        else
                        {
                            regularGuests.Remove(currentGuests);
                        }

                        if (currentGuests == "END")
                        {
                            break;
                        }
                    }
                    
                    break;
                }
                else
                {
                    if (IsMatched(inputline))
                    {
                        vip.Add(inputline);
                    }
                    else
                    {
                        regularGuests.Add(inputline);
                    }
                }
            }
            
            PrintingGuestLists(vip, regularGuests);
        }

        static bool IsMatched(string inputline)
        {
            string pattern = @"(?<VIP>^\d)";
            Regex regex = new Regex(pattern);
            MatchCollection matchedInput = regex.Matches(inputline);

            if (!matchedInput.Any())
            {
                return false;
            }
            
            return true;
        }

        static void PrintingGuestLists(HashSet<string> vip, HashSet<string> regularGuests)
        {
            int countOfMissingGuests = vip.Count + regularGuests.Count;

            Console.WriteLine(countOfMissingGuests);

            foreach (var vipGuests in vip)
            {
                Console.WriteLine(vipGuests);
            }

            foreach (var regular in regularGuests)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
