﻿using System;
using System.Globalization;
class HolidaysBetweenTwoDates
{
    static void Main()
    {
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(),"d/M/yyyy", CultureInfo.InvariantCulture);

        int holidaysCount = 0;

        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }


                Console.WriteLine(holidaysCount);
        }
    }
}
