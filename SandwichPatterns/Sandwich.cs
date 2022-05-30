namespace SandwichPatterns;

public class Sandwich
{
    public string Name { get; }

    public Dictionary<Ingredient, int> Ingredients { get; }

    public Sandwich(string name, Dictionary<Ingredient, int> ingredients)
    {
        Name = name;
        Ingredients = ingredients;
    }
}