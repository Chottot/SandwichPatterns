namespace SandwichPatterns;

public class Order
{
    public Dictionary<Sandwich, int> Sandwich { get; }

    public Order(Dictionary<Sandwich, int> sandwich)
    {
        Sandwich = sandwich;
    }
}