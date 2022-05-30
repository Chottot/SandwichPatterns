namespace SandwichPatterns;

public class CommandInvoice
{
    private Dictionary<Ingredient, double> ingredientPrices;

    public CommandInvoice(Dictionary<Ingredient, double> ingredientPrices)
    {
        this.ingredientPrices = ingredientPrices;
    }

    public void display(Dictionary<Sandwich, int> sandwich)
    {
        throw new NotImplementedException();
    }
}