using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace DefiningClasses
{

public class StartUp
{
    public static void Main(string[] args)
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();

        DateModifier dateModifier = new DateModifier();

        Console.WriteLine(dateModifier.ReturnDateDifference(firstDate, secondDate));
    }
}



}