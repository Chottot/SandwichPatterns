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
}