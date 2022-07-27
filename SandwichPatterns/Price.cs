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

    private bool Equals(Price other)
    {
        return Currency.Equals(other.Currency) && Value.Equals(other.Value);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((Price)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Currency, Value);
    }
}