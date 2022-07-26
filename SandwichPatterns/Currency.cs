namespace SandwichPatterns;

public class Currency
{
    private string Str { get; }

    private Currency(string str)
    {
        Str = str;
    }

    public static Currency Euro => new Currency("€");

    public static Currency Dollar => new Currency("$");

    public override string ToString()
    {
        return Str;
    }

    private bool Equals(Currency other)
    {
        return Str == other.Str;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((Currency)obj);
    }

    public override int GetHashCode()
    {
        return Str.GetHashCode();
    }
}