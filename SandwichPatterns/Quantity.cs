namespace SandwichPatterns;

public class Quantity
{
    private QuantityUnit Unit { get; }

    private double Value { get; }
    
    public Quantity(QuantityUnit unit, double value)
    {
        Unit = unit;
        Value = value;
    }
    
    public override string ToString()
    {
        return Value +" "+ Unit ;
    }

    private bool Equals(Quantity other)
    {
        return Unit.Equals(other.Unit) && Value.Equals(other.Value);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((Quantity)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Unit, Value);
    }
}