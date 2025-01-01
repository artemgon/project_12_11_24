using System;
using System.Collections.Generic;

namespace project_12_11_24
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter day: ");
                int day = getDay();
                Console.Write("Enter month: ");
                int month = getMonth();
                Console.Write("Enter year: ");
                int year = getYear();
                validateDate(day, month, year);
                int originalMonth = month;  
                if (month == 1 || month == 2)
                {
                    month += 12; 
                    year -= 1; 
                }
                int dayOfWeek = (day + (13 * (month + 1)) / 5 + year + year / 4 - year / 100 + year / 400) % 7;
                Dictionary<int, string> daysOfWeek = new Dictionary<int, string>
                {
                    {0, "Saturday"},
                    {1, "Sunday"},
                    {2, "Monday"},
                    {3, "Tuesday"},
                    {4, "Wednesday"},
                    {5, "Thursday"},
                    {6, "Friday"}
                };
                string season = getSeason(originalMonth);
                Console.WriteLine($"Season: {season}");
                Console.WriteLine($"Day of the week: {daysOfWeek[dayOfWeek]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static int getDay()
        {
            int day = int.Parse(Console.ReadLine() ?? "");
            if (day < 1 || day > 31)
            {
                throw new Exception("Invalid day (must be between 1 and 31)");
            }
            return day;
        }

        static int getMonth()
        {
            int month = int.Parse(Console.ReadLine() ?? "");
            if (month < 1 || month > 12)
            {
                throw new Exception("Invalid month (must be between 1 and 12)");
            }
            return month;
        }

        static int getYear()
        {
            int year = int.Parse(Console.ReadLine() ?? "");
            if (year < 1)
            {
                throw new Exception("Invalid year (must be greater than 0)");
            }
            return year;
        }

        static string getSeason(int month)
        {
            if (month == 12 || month == 1 || month == 2)
            {
                return "Winter";
            }
            else if (month == 3 || month == 4 || month == 5)
            {
                return "Spring";
            }
            else if (month == 6 || month == 7 || month == 8)
            {
                return "Summer";
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                return "Autumn";
            }
            else
            {
                return "Unknown";
            } 
        }
        static void validateDate(int day, int month, int year)
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);
            if (day < 1 || day > daysInMonth)
            {
                throw new Exception($"Invalid day for the given month. This month has only {daysInMonth} days.");
            }
        }
    }
}
