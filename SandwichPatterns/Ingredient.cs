namespace SandwichPatterns;

public class Ingredient
{
    public string Name { get; }

    public Ingredient(string name)
    {
        Name = name;
    }

    private bool Equals(Ingredient other)
    {
        return Name.Equals(other.Name);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Ingredient)obj);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}