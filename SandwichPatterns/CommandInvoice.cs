namespace SandwichPatterns;

public class CommandInvoice
{
    private Dictionary<Ingredient, double> _ingredientPrices;

    public CommandInvoice(Dictionary<Ingredient, double> ingredientPrices)
    {
        this._ingredientPrices = ingredientPrices;
    }

    public void display(Dictionary<Sandwich, int> sandwich)
    {
        throw new NotImplementedException();
    }
}