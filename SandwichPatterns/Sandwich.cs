namespace SandwichPatterns;

public class Sandwich
{
    public string Name { get; }

    public Dictionary<Ingredient, Quantity> Ingredients { get; }

    public Sandwich(string name, IDictionary<Ingredient, Quantity> ingredients)
    {
        Name = name;
        Ingredients = new Dictionary<Ingredient, Quantity>(ingredients);
    }

    private bool Equals(Sandwich other)
    {
        if (Ingredients.Count != other.Ingredients.Count || Ingredients.Except(other.Ingredients).Any())
        {
            return false;
        }

        return Name.Equals(other.Name);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Sandwich)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Ingredients);
    }
}