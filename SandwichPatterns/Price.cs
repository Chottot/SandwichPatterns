namespace SandwichPatterns;

public class Price
{
    private Currency Currency { get; }

    public double Value { get; }

    public Price(Currency currency, double value)
    {
        Currency = currency;
        Value = value;
    }

    public override string ToString()
    {
        return Value + " " + Currency;
    }
}