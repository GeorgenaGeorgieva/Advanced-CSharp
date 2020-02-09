namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

  public class DateModifier
  {
     public int ReturnDateDifference(string firstDate, string secondDate)
     {
        var firstDateArray = firstDate
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var firstYear = firstDateArray[0];
        var firstMonth = firstDateArray[1];
        var firstDay = firstDateArray[2];

        DateTime firstDateTime = new DateTime(firstYear, firstMonth, firstDay);

        var secondDateArray = secondDate
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var secondYear = secondDateArray[0];
        var secondMonth = secondDateArray[1];
        var secontDay = secondDateArray[2];

        DateTime secondDateTime = new DateTime(secondYear, secondMonth, secontDay);

        var result = Math.Abs((firstDateTime - secondDateTime).Days);

        return result;
      }
   }
}
