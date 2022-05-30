namespace SandwichPatterns;

public class CommandInvoice
{
    private readonly Dictionary<Sandwich, double> _ingredientPrices;

    public CommandInvoice(Dictionary<Sandwich, double> ingredientPrices)
    {
        _ingredientPrices = ingredientPrices;
    }

    public void Display(Dictionary<Sandwich, int> command)
    {
        double sum = 0;

        foreach (var sandwich in command)
        {
            if (!_ingredientPrices.ContainsKey(sandwich.Key))
            {
                throw new Exception("undefined sandwich");
            }

            sum += _ingredientPrices[sandwich.Key] * sandwich.Value;
            
            Console.WriteLine(sandwich.Value + " " + sandwich.Key.Name);

            foreach (var ingredient in sandwich.Key.Ingredients)
            {
                Console.WriteLine("\t"+ingredient.Key.Name);
            }
        }
        Console.WriteLine("Prix total :" + sum +"€");
    }
}