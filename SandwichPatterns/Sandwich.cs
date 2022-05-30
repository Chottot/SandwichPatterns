namespace SandwichPatterns;

public class Sandwich
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    private readonly Dictionary<Ingredient, int> _ingredients;

    public Dictionary<Ingredient, int> Ingredients => _ingredients;

    public Sandwich(string name, Dictionary<Ingredient, int> ingredients)
    {
        this._name = name;
        this._ingredients = ingredients;
    }
}