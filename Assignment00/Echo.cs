// See https://aka.ms/new-console-template for more information
namespace Echo;

internal class Echo
{
    private static void Main(String[] args)
    {
        foreach (String s in args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(s);
            }
        }
    }
}