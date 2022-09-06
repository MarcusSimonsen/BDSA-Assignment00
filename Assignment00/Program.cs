// See https://aka.ms/new-console-template for more information
Console.Write("Please enter a year: ");

public class LeapYear
{
    /**
    A year is a leap year iff:
    * it is divisible by 4 and,
    * not exactly divisible by 100, unless exactly divisible by 400.
    */
    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}