using System.Text;

namespace SandwichPatterns;

public static class SandwichPatterns
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var sandwichesWithPrices = SandwichRepository.getDefault();
        var commandParser = new CommandParser(sandwichesWithPrices);
        var commandInvoice = new CommandInvoice(sandwichesWithPrices);

        while (true)
        {
            Console.WriteLine("Enter a sandwich pattern:");
            var commandWanted = Console.ReadLine() ?? throw new InvalidOperationException();
            if (commandWanted == "")
            {
                break;
            }

            try
            {
                var command = commandParser.Parse(commandWanted);
                commandInvoice.Display(command);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}