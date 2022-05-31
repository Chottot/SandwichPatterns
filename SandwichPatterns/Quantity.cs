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
}