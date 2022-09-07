// See https://aka.ms/new-console-template for more information

public class LeapYear
{
    public static void Main(string[] Args)
    {
        Console.Write("Please enter a year: ");

        var input = Console.ReadLine();

        int year = -1;

        try
        {
            year = Int32.Parse(input);
            //FIXME: Implement InvalidYearException instead of OverflowException
            if (year < 1580 || year > 3000)
            {
                throw new OverflowException("Year less than 1580 or larger than");
            }
            else
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine("yay");
                }
                else
                {
                    Console.WriteLine("nay");
                }
            }
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("Please input a number");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Please input only a number");
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Please input a year between 1580 and 3000");
        }
    }

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