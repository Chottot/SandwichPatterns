namespace SandwichPatterns;

public class QuantityUnit
{
    private string Str { get; }
    
    private QuantityUnit(string str)
    {
        Str = str;
    }
    
    public static QuantityUnit Gram => new QuantityUnit("g");
    public static QuantityUnit Slice => new QuantityUnit("slice");
    public static QuantityUnit Unit => new QuantityUnit("");

    public override string ToString()
    {
        return Str;
    }

    private bool Equals(QuantityUnit other)
    {
        return Str == other.Str;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((QuantityUnit)obj);
    }

    public override int GetHashCode()
    {
        return Str.GetHashCode();
    }
}