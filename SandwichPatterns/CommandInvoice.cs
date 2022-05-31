namespace SandwichPatterns;

public class CommandInvoice
{
    private readonly Dictionary<Sandwich, Price> _sandwichPrices;

    public CommandInvoice(Dictionary<Sandwich, Price> sandwichPrices)
    {
        _sandwichPrices = sandwichPrices;
    }

    public void Display(Dictionary<Sandwich, int> command)
    {
        double sum = 0;

        foreach (var sandwich in command)
        {
            if (!_sandwichPrices.ContainsKey(sandwich.Key))
            {
                throw new Exception("undefined sandwich");
            }

            sum += _sandwichPrices[sandwich.Key].Value * sandwich.Value;

            Console.WriteLine(sandwich.Value + " " + sandwich.Key.Name);

            foreach (var ingredient in sandwich.Key.Ingredients)
            {
                Console.WriteLine("\t" + ingredient.Key.Name + " : " + ingredient.Value);
            }
        }

        Console.WriteLine("Prix total : " + sum + "€");
    }
}