namespace SandwichPatterns;

public class Sandwich
{
    private string name;
    private Dictionary<Ingredient, int> ingredients;

    public Sandwich(string name, Dictionary<Ingredient, int> ingredients)
    {
        this.name = name;
        this.ingredients = ingredients;
    }
}