// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class LeapYear
{
    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}