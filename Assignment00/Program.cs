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
            if (year < 1582)
            {
                throw new InvalidYearException("Year less than 1582");
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
        catch (ArgumentNullException)
        {
            Console.WriteLine("Please input a number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please input only a number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Please input a year between 1582 and {0}", Int32.MaxValue);
        }
        catch (InvalidYearException)
        {
            Console.WriteLine("Please input a year after 1582");
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

[Serializable]
class InvalidYearException : Exception
{
    public InvalidYearException() {  }

    public InvalidYearException(string input)
        : base(String.Format("Invalid year input: {0}", input))
    {

    }
}