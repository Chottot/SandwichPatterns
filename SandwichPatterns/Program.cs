using System.Text;

namespace SandwichPatterns;

public static class SandwichPatterns
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var sandwichesWithPrices = Sandwich.DefaultSandwichesWithPrices();
        var commandParser = new CommandParser(new List<Sandwich>(sandwichesWithPrices.Keys));
        var commandInvoice = new CommandInvoice(sandwichesWithPrices);
        while (true)
        {
            Console.WriteLine("Enter a sandwich pattern:");
            var commandWanted = Console.ReadLine() ?? throw new InvalidOperationException();
            if (commandWanted == "")
            {
                break;
            }
            var command = commandParser.Parse(commandWanted.Split());
            commandInvoice.Display(command);
        }
    }   
}