namespace SandwichPatterns;

public class Ingredient
{
    private string _name;


    public string Name => _name;

    public Ingredient(string name)
    {
        this._name = name;
    }
}