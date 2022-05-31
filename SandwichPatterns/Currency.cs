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
}
