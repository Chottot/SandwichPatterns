namespace SandwichPatterns;

public class CommandInvoice
{
    private readonly SandwichRepository _sandwichPrices;

    public CommandInvoice(SandwichRepository sandwichPrices)
    {
        _sandwichPrices = sandwichPrices;
    }

    public void Display(Order command)
    {
        double sum = 0;

        foreach (var sandwich in command.Sandwich)
        {
            sum += _sandwichPrices.GetSandwichPrice(sandwich.Key.Name).Value * sandwich.Value;

            Console.WriteLine(sandwich.Value + " " + sandwich.Key.Name);

            foreach (var ingredient in sandwich.Key.Ingredients)
            {
                Console.WriteLine("\t" + ingredient.Key.Name + " : " + ingredient.Value);
            }
        }

        Console.WriteLine("Prix total : " + sum + "€");
    }
}