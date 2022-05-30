namespace SandwichPatterns;

public class Sandwich
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Dictionary<Ingredient, int> Ingredients { get; }

    public Sandwich(string name, Dictionary<Ingredient, int> ingredients)
    {
        this._name = name;
        this.Ingredients = ingredients;
    }
}